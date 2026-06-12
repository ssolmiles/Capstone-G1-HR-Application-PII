using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        private readonly int _applicationId;

        public frmScreening(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;

            btnQualified.Click += btnQualified_Click;
            btnNotQualified.Click += btnNotQualified_Click;
            btnNext.Click += btnNext_Click;
        }

        private void frmScreening_Load(object sender, EventArgs e)
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

                    string query = @"
                        SELECT ap.full_name AS ApplicantName,
                               p.title      AS JobTitle,
                               a.status     AS Status,
                               sr.result    AS ScreeningResult,
                               sr.remarks   AS ScreeningRemarks
                        FROM applications a
                        INNER JOIN applicants ap    ON ap.applicant_id = a.applicant_id
                        INNER JOIN job_vacancies jv  ON jv.vacancy_id = a.vacancy_id
                        INNER JOIN positions p       ON p.position_id = jv.position_id
                        LEFT JOIN screening_results sr ON sr.application_id = a.application_id
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

                                string result = reader["ScreeningResult"] as string;
                                if (result == "qualified")
                                    SetStatus("Status: Qualified", true);
                                else if (result == "not_qualified")
                                    SetStatus("Status: Not Qualified", false);
                                else
                                    lblStatus.Text = "Status: Pending";

                                if (reader["ScreeningRemarks"] != DBNull.Value)
                                    txtRemarks.Text = reader["ScreeningRemarks"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Application not found.");
                                lblApplicantName.Text = "(unknown)";
                                lblJobApplied.Text = "(unknown)";
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

        private void SetStatus(string text, bool qualified)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = qualified
                ? System.Drawing.Color.FromArgb(26, 122, 60)
                : System.Drawing.Color.FromArgb(192, 57, 43);
        }

        private void btnQualified_Click(object sender, EventArgs e)
        {
            SaveScreening("qualified");
        }

        private void btnNotQualified_Click(object sender, EventArgs e)
        {
            SaveScreening("not_qualified");
        }

        private void SaveScreening(string result)
        {
            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string upsert = @"
                        MERGE screening_results AS target
                        USING (SELECT @appId AS application_id) AS src
                            ON target.application_id = src.application_id
                        WHEN MATCHED THEN
                            UPDATE SET result = @result, remarks = @remarks,
                                       reviewed_by = @userId, reviewed_at = @now
                        WHEN NOT MATCHED THEN
                            INSERT (application_id, reviewed_by, result, remarks, reviewed_at)
                            VALUES (@appId, @userId, @result, @remarks, @now);";

                    using (var cmd = new SqlCommand(upsert, conn))
                    {
                        cmd.Parameters.AddWithValue("@appId", _applicationId);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@result", result);
                        cmd.Parameters.AddWithValue("@remarks",
                            string.IsNullOrWhiteSpace(txtRemarks.Text) ? (object)DBNull.Value : txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@now", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }

                string newStatus = result == "qualified" ? "screened" : "rejected";
                StatusHistoryLoggerSafe(newStatus, $"Screening result: {result}");

                bool qualified = result == "qualified";
                SetStatus(qualified ? "Status: Qualified" : "Status: Not Qualified", qualified);

                MessageBox.Show(
                    (qualified ? "Applicant marked Qualified." : "Applicant marked Not Qualified.")
                    + "\nRemarks: " + txtRemarks.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving screening result: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmInterviewSchedule interviewForm = new frmInterviewSchedule(_applicationId);
            interviewForm.Show();
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}