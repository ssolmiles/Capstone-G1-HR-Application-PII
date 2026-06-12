using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewSchedule : Form
    {
        private readonly int _applicationId;
        private int? _scheduleId;

        public frmInterviewSchedule(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;

            btnSchedule.Click += btnSchedule_Click;
            btnComplete.Click += btnComplete_Click;
            btnCancel.Click += btnCancel_Click;
            btnNext.Click += btnNext_Click;
        }

        private void frmInterviewSchedule_Load(object sender, EventArgs e)
        {
            LoadApplicationInfo();
        }

        private void LoadApplicationInfo()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Applicant + job info
                    string query = @"
                        SELECT ap.full_name AS ApplicantName, p.title AS JobTitle
                        FROM applications a
                        INNER JOIN applicants ap   ON ap.applicant_id = a.applicant_id
                        INNER JOIN job_vacancies jv ON jv.vacancy_id = a.vacancy_id
                        INNER JOIN positions p      ON p.position_id = jv.position_id
                        WHERE a.application_id = @id";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblApplicantName.Text = reader["ApplicantName"].ToString();
                                lblJobApplied.Text = reader["JobTitle"].ToString();
                            }
                            else
                            {
                                lblApplicantName.Text = "(unknown)";
                                lblJobApplied.Text = "(unknown)";
                            }
                        }
                    }

                    // Existing schedule, if any
                    string schedQuery = @"
                        SELECT TOP 1 s.schedule_id, s.scheduled_date, s.scheduled_time,
                               s.location, s.status, it.label AS ModeLabel
                        FROM interview_schedules s
                        LEFT JOIN interview_types it ON it.interview_type_id = s.interview_type_id
                        WHERE s.application_id = @id
                        ORDER BY s.schedule_id DESC";

                    using (var cmd = new SqlCommand(schedQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _scheduleId = Convert.ToInt32(reader["schedule_id"]);

                                if (reader["scheduled_date"] != DBNull.Value)
                                    dtpDate.Value = Convert.ToDateTime(reader["scheduled_date"]);

                                if (reader["scheduled_time"] != DBNull.Value)
                                {
                                    TimeSpan t = (TimeSpan)reader["scheduled_time"];
                                    dtpTime.Value = DateTime.Today.Add(t);
                                }

                                if (reader["location"] != DBNull.Value)
                                    txtLocation.Text = reader["location"].ToString();

                                if (reader["ModeLabel"] != DBNull.Value)
                                    cmbMode.Text = reader["ModeLabel"].ToString();

                                string status = reader["status"].ToString();
                                ApplyStatus(status);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading application: " + ex.Message);
            }
        }

        private void ApplyStatus(string status)
        {
            switch (status)
            {
                case "scheduled":
                    lblStatus.Text = "Status: Scheduled";
                    lblStatus.ForeColor = System.Drawing.Color.FromArgb(212, 122, 0);
                    break;
                case "completed":
                    lblStatus.Text = "Status: Completed";
                    lblStatus.ForeColor = System.Drawing.Color.FromArgb(26, 122, 60);
                    break;
                case "cancelled":
                    lblStatus.Text = "Status: Cancelled";
                    lblStatus.ForeColor = System.Drawing.Color.FromArgb(192, 57, 43);
                    break;
                default:
                    lblStatus.Text = "Status: Not Scheduled";
                    lblStatus.ForeColor = System.Drawing.Color.FromArgb(212, 122, 0);
                    break;
            }
        }

        private int? GetInterviewTypeId(SqlConnection conn, string modeLabel)
        {
            if (string.IsNullOrWhiteSpace(modeLabel)) return null;

            using (var cmd = new SqlCommand(
                "SELECT interview_type_id FROM interview_types WHERE label = @label", conn))
            {
                cmd.Parameters.AddWithValue("@label", modeLabel.Trim());
                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : (int?)null;
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInterviewer.Text))
            {
                MessageBox.Show("Please enter the interviewer's name.");
                return;
            }

            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    int? interviewTypeId = GetInterviewTypeId(conn, cmbMode.Text);

                    if (_scheduleId.HasValue)
                    {
                        string update = @"
                            UPDATE interview_schedules
                            SET interviewer_id = @interviewerId,
                                interview_type_id = @typeId,
                                scheduled_date = @date,
                                scheduled_time = @time,
                                location = @location,
                                status = 'scheduled'
                            WHERE schedule_id = @scheduleId";

                        using (var cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@interviewerId", userId);
                            cmd.Parameters.AddWithValue("@typeId", (object)interviewTypeId ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                            cmd.Parameters.AddWithValue("@time", dtpTime.Value.TimeOfDay);
                            cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                            cmd.Parameters.AddWithValue("@scheduleId", _scheduleId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insert = @"
                            INSERT INTO interview_schedules
                                (application_id, interviewer_id, interview_type_id,
                                 scheduled_date, scheduled_time, location, status, created_by, created_at)
                            OUTPUT INSERTED.schedule_id
                            VALUES
                                (@appId, @interviewerId, @typeId, @date, @time, @location, 'scheduled', @createdBy, @now)";

                        using (var cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@appId", _applicationId);
                            cmd.Parameters.AddWithValue("@interviewerId", userId);
                            cmd.Parameters.AddWithValue("@typeId", (object)interviewTypeId ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@date", dtpDate.Value.Date);
                            cmd.Parameters.AddWithValue("@time", dtpTime.Value.TimeOfDay);
                            cmd.Parameters.AddWithValue("@location", txtLocation.Text.Trim());
                            cmd.Parameters.AddWithValue("@createdBy", userId);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            _scheduleId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }

                StatusHistoryLoggerSafe("interview_scheduled", "Interview scheduled");
                ApplyStatus("scheduled");

                string info = $"Date: {dtpDate.Value.ToShortDateString()}, " +
                              $"Time: {dtpTime.Value.ToShortTimeString()}, " +
                              $"Interviewer: {txtInterviewer.Text}, " +
                              $"Mode: {cmbMode.SelectedItem}, " +
                              $"Location: {txtLocation.Text}";
                MessageBox.Show("Interview scheduled:\n" + info);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scheduling interview: " + ex.Message);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            UpdateScheduleStatus("completed", "interviewed", "Interview marked as completed.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateScheduleStatus("cancelled", "screened", "Interview cancelled.");
        }

        private void UpdateScheduleStatus(string scheduleStatus, string applicationStatus, string message)
        {
            if (!_scheduleId.HasValue)
            {
                MessageBox.Show("Please schedule the interview first.");
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "UPDATE interview_schedules SET status = @status WHERE schedule_id = @scheduleId", conn))
                    {
                        cmd.Parameters.AddWithValue("@status", scheduleStatus);
                        cmd.Parameters.AddWithValue("@scheduleId", _scheduleId.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

                StatusHistoryLoggerSafe(applicationStatus, $"Interview {scheduleStatus}");
                ApplyStatus(scheduleStatus);
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating interview status: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmInterviewEvaluation evalForm = new frmInterviewEvaluation(_applicationId);
            evalForm.Show();
            this.Hide();
        }

        private void StatusHistoryLoggerSafe(string newStatus, string remarks)
        {
            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;
                StatusHistoryLogger.LogStatusChange(_applicationId, null, newStatus, userId, remarks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning: status history could not be recorded: " + ex.Message);
            }
        }
    }
}