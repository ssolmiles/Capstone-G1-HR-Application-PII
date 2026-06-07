using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using HRApplicantSystem.Models;

namespace HRApplicantSystem.Helpers
{
    // ─────────────────────────────────────────
    // DATABASE HELPER
    // ─────────────────────────────────────────
    public static class DatabaseHelper
    {
        private static string _connectionString =
            "Server=localhost;Database=HRApplicantDB;Uid=root;Pwd=YOUR_PASSWORD;";

        public static void LoadConfig(string iniPath)
        {
            var config = new Dictionary<string, string>();
            foreach (var line in File.ReadAllLines(iniPath))
            {
                if (line.Contains("="))
                {
                    var parts = line.Split('=');
                    config[parts[0].Trim()] = parts[1].Trim();
                }
            }
            _connectionString =
                $"Server={config["server"]};" +
                $"Database={config["database"]};" +
                $"Uid={config["user"]};" +
                $"Pwd={config["password"]};";
        }

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }

    // ─────────────────────────────────────────
    // SESSION MANAGER
    // ─────────────────────────────────────────
    public static class SessionManager
    {
        public static User CurrentUser { get; private set; }
        public static string CurrentRole => CurrentUser?.Role;
        public static Applicant CurrentApplicant { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Login(User user)
        {
            CurrentUser = user;
        }

        public static void LoginApplicant(Applicant applicant)
        {
            CurrentApplicant = applicant;
        }

        public static void Logout()
        {
            CurrentUser = null;
            CurrentApplicant = null;
        }
    }

    // ─────────────────────────────────────────
    // VALIDATION HELPER
    // ─────────────────────────────────────────
    public static class ValidationHelper
    {
        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        public static bool IsPasswordStrong(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6) return false;
            return true;
        }

        public static bool IsFieldEmpty(string value)
        {
            return string.IsNullOrWhiteSpace(value);
        }

        public static bool IsEmailTaken(string email)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new MySqlCommand(
                    "SELECT COUNT(1) FROM users WHERE email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email.Trim().ToLower());
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch
            {
                return true;
            }
        }
    }

    // ─────────────────────────────────────────
    // AUDIT LOGGER
    // ─────────────────────────────────────────
    public static class AuditLogger
    {
        public static void LogAction(int userId, string action,
            string tableAffected, int? recordId = null, string details = null)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        INSERT INTO audit_logs
                            (user_id, action, table_affected, record_id, details, logged_at)
                        VALUES
                            (@userId, @action, @table, @recordId, @details, @loggedAt)";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@action", action ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@table", tableAffected ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@recordId", (object)recordId ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@details", (object)details ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@loggedAt", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { }
        }
    }

    // ─────────────────────────────────────────
    // STATUS HISTORY LOGGER
    // ─────────────────────────────────────────
    public static class StatusHistoryLogger
    {
        public static void LogStatusChange(int applicationId, string previousStatus,
            string newStatus, int changedByUserId, string remarks = null)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    var tx = conn.BeginTransaction();
                    try
                    {
                        string insertSql = @"
                            INSERT INTO status_history
                                (application_id, changed_by_user_id, previous_status,
                                 new_status, remarks, changed_at)
                            VALUES
                                (@appId, @changedBy, @prevStatus,
                                 @newStatus, @remarks, @changedAt)";

                        using (var cmd = new MySqlCommand(insertSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@appId", applicationId);
                            cmd.Parameters.AddWithValue("@changedBy", changedByUserId);
                            cmd.Parameters.AddWithValue("@prevStatus", previousStatus ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@newStatus", newStatus);
                            cmd.Parameters.AddWithValue("@remarks", (object)remarks ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@changedAt", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        string updateSql = @"
                            UPDATE applications
                            SET status = @newStatus, updated_at = @now
                            WHERE application_id = @appId";

                        using (var cmd = new MySqlCommand(updateSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@newStatus", newStatus);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@appId", applicationId);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();

                        AuditLogger.LogAction(
                            changedByUserId,
                            $"Status changed to '{newStatus}'",
                            "applications",
                            applicationId,
                            $"From: {previousStatus} -> To: {newStatus}"
                        );
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(
                    $"StatusHistoryLogger error: {ex.Message}", ex);
            }
        }
    }
}