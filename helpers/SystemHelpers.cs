using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text.RegularExpressions;
using HRApplicantSystem.Models;

namespace HRApplicantSystem.Helpers
{
    // ─────────────────────────────────────────────────────────────────────────
    // DatabaseHelper
    // Reads connection string from db_config.ini and opens Azure SQL connections.
    // ─────────────────────────────────────────────────────────────────────────
    public static class DatabaseHelper
    {
        private static string _connectionString;

        /// <summary>
        /// Call once at startup (Program.cs) to load the connection string.
        /// Expected db_config.ini format:
        ///   [Database]
        ///   ConnectionString=Server=tcp:yourserver.database.windows.net,...
        /// </summary>
        public static void LoadConfig(string iniPath)
        {
            if (!File.Exists(iniPath))
                throw new FileNotFoundException($"Config file not found: {iniPath}");

            foreach (string line in File.ReadAllLines(iniPath))
            {
                string trimmed = line.Trim();
                if (trimmed.StartsWith("ConnectionString=", StringComparison.OrdinalIgnoreCase))
                {
                    _connectionString = trimmed.Substring("ConnectionString=".Length).Trim();
                    return;
                }
            }

            throw new InvalidOperationException("ConnectionString key not found in db_config.ini.");
        }

        /// <summary>
        /// Opens and returns a new SqlConnection.
        /// Caller is responsible for disposing (use in a using block).
        /// </summary>
        public static SqlConnection GetConnection()
        {
            if (string.IsNullOrEmpty(_connectionString))
                throw new InvalidOperationException("Call DatabaseHelper.LoadConfig() before GetConnection().");

            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }


    // ─────────────────────────────────────────────────────────────────────────
    // SessionManager
    // Holds the currently logged-in user/applicant in memory for the session.
    // ─────────────────────────────────────────────────────────────────────────
    public static class SessionManager
    {
        public static User CurrentUser { get; private set; }
        public static string CurrentRole => CurrentUser?.Role;
        public static Applicant CurrentApplicant { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        /// <summary>
        /// Authenticates an HR user (Admin, HR Staff, HR Manager).
        /// Returns true on success; out message contains error details on failure.
        /// </summary>
        public static bool Login(string email, string password, out string message)
        {
            if (!ValidationHelper.IsEmailValid(email))
            {
                message = "Invalid email format.";
                return false;
            }

            if (ValidationHelper.IsFieldEmpty(password))
            {
                message = "Password cannot be empty.";
                return false;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        SELECT UserID, Email, PasswordHash, Role, IsActive
                        FROM Users
                        WHERE Email = @Email
                          AND Role IN ('Admin','HR Staff','HR Manager')";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim().ToLower());

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                message = "Account not found.";
                                return false;
                            }

                            bool isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            if (!isActive)
                            {
                                message = "This account is inactive. Contact your administrator.";
                                return false;
                            }

                            string storedHash = reader.GetString(reader.GetOrdinal("PasswordHash"));

                            // Replace BCrypt.Verify() with your hashing library if different.
                            if (!BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                message = "Incorrect password.";
                                return false;
                            }

                            CurrentUser = new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                PasswordHash = storedHash,
                                Role = reader.GetString(reader.GetOrdinal("Role")),
                                IsActive = isActive
                            };
                        }
                    }

                    // Update last login timestamp
                    string update = "UPDATE Users SET LastLoginAt = @Now WHERE UserID = @UserID";
                    using (var cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
                        cmd.ExecuteNonQuery();
                    }
                }

                AuditLogger.LogAction(CurrentUser.UserID, "Login", "Users", CurrentUser.UserID, "HR login.");
                message = "Login successful.";
                return true;
            }
            catch (Exception ex)
            {
                message = $"Login error: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// Authenticates an Applicant and loads their Applicant record.
        /// Returns true on success; out message contains error details on failure.
        /// </summary>
        public static bool LoginApplicant(string email, string password, out string message)
        {
            if (!ValidationHelper.IsEmailValid(email))
            {
                message = "Invalid email format.";
                return false;
            }

            if (ValidationHelper.IsFieldEmpty(password))
            {
                message = "Password cannot be empty.";
                return false;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        SELECT u.UserID, u.Email, u.PasswordHash, u.IsActive,
                               a.ApplicantID, a.FirstName, a.MiddleName, a.LastName
                        FROM Users u
                        INNER JOIN Applicants a ON a.UserID = u.UserID
                        WHERE u.Email = @Email
                          AND u.Role = 'Applicant'";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Trim().ToLower());

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                message = "Account not found.";
                                return false;
                            }

                            bool isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            if (!isActive)
                            {
                                message = "Your account is inactive. Contact HR.";
                                return false;
                            }

                            string storedHash = reader.GetString(reader.GetOrdinal("PasswordHash"));

                            if (!BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                message = "Incorrect password.";
                                return false;
                            }

                            CurrentUser = new User
                            {
                                UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                PasswordHash = storedHash,
                                Role = "Applicant",
                                IsActive = isActive
                            };

                            CurrentApplicant = new Applicant
                            {
                                ApplicantID = reader.GetInt32(reader.GetOrdinal("ApplicantID")),
                                UserID = CurrentUser.UserID,
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                MiddleName = reader.IsDBNull(reader.GetOrdinal("MiddleName"))
                                                ? null
                                                : reader.GetString(reader.GetOrdinal("MiddleName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName"))
                            };
                        }
                    }

                    string update = "UPDATE Users SET LastLoginAt = @Now WHERE UserID = @UserID";
                    using (var cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                        cmd.Parameters.AddWithValue("@UserID", CurrentUser.UserID);
                        cmd.ExecuteNonQuery();
                    }
                }

                AuditLogger.LogAction(CurrentUser.UserID, "Login", "Users", CurrentUser.UserID, "Applicant login.");
                message = "Login successful.";
                return true;
            }
            catch (Exception ex)
            {
                message = $"Login error: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// Clears the session. Call on logout or when closing the main form.
        /// </summary>
        public static void Logout()
        {
            if (CurrentUser != null)
                AuditLogger.LogAction(CurrentUser.UserID, "Logout", "Users", CurrentUser.UserID, "User logged out.");

            CurrentUser = null;
            CurrentApplicant = null;
        }
    }


    // ─────────────────────────────────────────────────────────────────────────
    // ValidationHelper
    // Reusable input-validation utilities.
    // ─────────────────────────────────────────────────────────────────────────
    public static class ValidationHelper
    {
        /// <summary>Returns true if the string is a well-formed email address.</summary>
        public static bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            return Regex.IsMatch(email.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                RegexOptions.IgnoreCase);
        }

        /// <summary>
        /// Returns true if the password meets minimum requirements:
        /// at least 8 characters, one uppercase, one lowercase, one digit.
        /// </summary>
        public static bool IsPasswordStrong(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8) return false;
            bool hasUpper = Regex.IsMatch(password, @"[A-Z]");
            bool hasLower = Regex.IsMatch(password, @"[a-z]");
            bool hasDigit = Regex.IsMatch(password, @"\d");
            return hasUpper && hasLower && hasDigit;
        }

        /// <summary>Returns true if the string is null, empty, or whitespace only.</summary>
        public static bool IsFieldEmpty(string value) => string.IsNullOrWhiteSpace(value);

        /// <summary>
        /// Checks if an email already exists in the Users table.
        /// Use during registration to prevent duplicates.
        /// </summary>
        public static bool IsEmailTaken(string email)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var cmd = new SqlCommand(
                    "SELECT COUNT(1) FROM Users WHERE Email = @Email", conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email.Trim().ToLower());
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
            catch
            {
                // Fail-safe: treat as taken so registration is blocked
                return true;
            }
        }
    }


    // ─────────────────────────────────────────────────────────────────────────
    // AuditLogger
    // Writes a record to AuditLogs for every significant action.
    // Fire-and-forget — exceptions are swallowed so they never crash the UI.
    // ─────────────────────────────────────────────────────────────────────────
    public static class AuditLogger
    {
        /// <summary>
        /// Inserts a row into AuditLogs.
        /// </summary>
        /// <param name="userID">Who performed the action.</param>
        /// <param name="action">Short verb phrase, e.g. "Submitted Application".</param>
        /// <param name="tableAffected">DB table involved, e.g. "Applications".</param>
        /// <param name="recordID">Primary key of the affected row (nullable).</param>
        /// <param name="details">Optional extra info or JSON snapshot.</param>
        public static void LogAction(int userID, string action, string tableAffected,
                                     int? recordID = null, string details = null)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    string sql = @"
                        INSERT INTO AuditLogs
                            (UserID, Action, TableAffected, RecordID, Details, LoggedAt)
                        VALUES
                            (@UserID, @Action, @TableAffected, @RecordID, @Details, @LoggedAt)";

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@Action", action ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@TableAffected", tableAffected ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@RecordID", (object)recordID ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Details", (object)details ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoggedAt", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                // Do not propagate — logging must never crash the main workflow.
            }
        }
    }


    // ─────────────────────────────────────────────────────────────────────────
    // StatusHistoryLogger
    // Records every application status change for the applicant timeline view.
    // ─────────────────────────────────────────────────────────────────────────
    public static class StatusHistoryLogger
    {
        /// <summary>
        /// Inserts a row into StatusHistory and updates Applications.Status atomically.
        /// </summary>
        /// <param name="applicationID">The application being updated.</param>
        /// <param name="previousStatus">The status before the change.</param>
        /// <param name="newStatus">The status after the change.</param>
        /// <param name="changedByUserID">The user making the change.</param>
        /// <param name="remarks">Optional HR remarks visible to the applicant.</param>
        public static void LogStatusChange(int applicationID, string previousStatus,
                                           string newStatus, int changedByUserID,
                                           string remarks = null)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                using (var tx = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert history row
                        string insertSql = @"
                            INSERT INTO StatusHistory
                                (ApplicationID, ChangedByUserID, PreviousStatus, NewStatus, Remarks, ChangedAt)
                            VALUES
                                (@ApplicationID, @ChangedByUserID, @PreviousStatus, @NewStatus, @Remarks, @ChangedAt)";

                        using (var cmd = new SqlCommand(insertSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                            cmd.Parameters.AddWithValue("@ChangedByUserID", changedByUserID);
                            cmd.Parameters.AddWithValue("@PreviousStatus", previousStatus ?? (object)DBNull.Value);
                            cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                            cmd.Parameters.AddWithValue("@Remarks", (object)remarks ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@ChangedAt", DateTime.Now);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update the application's current status
                        string updateSql = @"
                            UPDATE Applications
                            SET Status = @NewStatus, UpdatedAt = @Now
                            WHERE ApplicationID = @ApplicationID";

                        using (var cmd = new SqlCommand(updateSql, conn, tx))
                        {
                            cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                            cmd.Parameters.AddWithValue("@Now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@ApplicationID", applicationID);
                            cmd.ExecuteNonQuery();
                        }

                        tx.Commit();

                        // 3. Audit log
                        AuditLogger.LogAction(
                            changedByUserID,
                            $"Status changed to '{newStatus}'",
                            "Applications",
                            applicationID,
                            $"From: {previousStatus} → To: {newStatus}"
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
                // Surface this one — a failed status change is a real problem.
                throw new InvalidOperationException($"StatusHistoryLogger error: {ex.Message}", ex);
            }
        }
    }
}

