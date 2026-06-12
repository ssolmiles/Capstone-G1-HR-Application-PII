using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHiringDecision : Form
    {
        private readonly int _applicationId;
        private int? _decisionId;

        public frmHiringDecision(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;

            btnHire.Click += btnHire_Click;
            btnReject.Click += btnReject_Click;
            btnSave.Click += btnSave_Click;
        }

        private void frmHiringDecision_Load(object sender, EventArgs e)
        {
            // Role values from User.Role are "Admin" / "HR Manager" / "HR Staff" / "Applicant"
            if (!SessionManager.CurrentUser.CanMakeFinalDecision)
            {
                MessageBox.Show(
                    "Access denied. This screen is for HR Manager and Admin only.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            LoadApplicationInfo();
        }

        private void LoadApplicationInfo()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Applicant, job, and latest interview score
                    string query = @"
                        SELECT ap.full_name AS ApplicantName, p.title AS JobTitle,
                               (SELECT TOP 1 score FROM interview_evaluations ie
                                WHERE ie.application_id = a.application_id
                                ORDER BY ie.evaluation_id DESC) AS Score,
                               hd.final_decision AS FinalDecision,
                               hd.remarks AS FinalRemarks,
                               hd.decision_id AS DecisionID
                        FROM applications a
                        INNER JOIN applicants ap   ON ap.applicant_id = a.applicant_id
                        INNER JOIN job_vacancies jv ON jv.vacancy_id = a.vacancy_id
                        INNER JOIN positions p      ON p.position_id = jv.position_id
                        LEFT JOIN hiring_decisions hd ON hd.application_id = a.application_id
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

                                lblInterviewScore.Text = reader["Score"] != DBNull.Value
                                    ? Convert.ToDecimal(reader["Score"]).ToString("0.##")
                                    : "N/A";

                                if (reader["DecisionID"] != DBNull.Value)
                                    _decisionId = Convert.ToInt32(reader["DecisionID"]);

                                if (reader["FinalRemarks"] != DBNull.Value)
                                    txtFinalRemarks.Text = reader["FinalRemarks"].ToString();

                                string decision = reader["FinalDecision"] as string;
                                if (decision == "accepted")
                                    ApplyDecision("Hire", "Approved", true);
                                else if (decision == "rejected")
                                    ApplyDecision("Reject", "Rejected", false);
                            }
                            else
                            {
                                lblApplicantName.Text = "(unknown)";
                                lblJobApplied.Text = "(unknown)";
                                lblInterviewScore.Text = "N/A";
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

        private void ApplyDecision(string decisionText, string statusText, bool hired)
        {
            lblDecision.Text = $"Final Decision: {decisionText}";
            lblStatus.Text = $"Status: {statusText}";
            lblStatus.ForeColor = hired
                ? System.Drawing.Color.FromArgb(26, 122, 60)
                : System.Drawing.Color.FromArgb(192, 57, 43);
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            ApplyDecision("Hire", "Approved", true);
            MessageBox.Show("Applicant Hired.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            ApplyDecision("Reject", "Rejected", false);
            MessageBox.Show("Applicant Rejected.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string decision;
            if (lblDecision.Text == "Final Decision: Hire") decision = "accepted";
            else if (lblDecision.Text == "Final Decision: Reject") decision = "rejected";
            else
            {
                MessageBox.Show("Please choose Accept or Reject before saving.");
                return;
            }

            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (_decisionId.HasValue)
                    {
                        string update = @"
                            UPDATE hiring_decisions
                            SET final_decision = @decision, remarks = @remarks,
                                decided_by = @userId, decided_at = @now
                            WHERE decision_id = @decisionId";

                        using (var cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@decision", decision);
                            cmd.Parameters.AddWithValue("@remarks", string.IsNullOrWhiteSpace(txtFinalRemarks.Text) ? (object)DBNull.Value : txtFinalRemarks.Text.Trim());
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@decisionId", _decisionId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insert = @"
                            INSERT INTO hiring_decisions
                                (application_id, final_decision, remarks, decided_by, decided_at)
                            OUTPUT INSERTED.decision_id
                            VALUES
                                (@appId, @decision, @remarks, @userId, @now)";

                        using (var cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@appId", _applicationId);
                            cmd.Parameters.AddWithValue("@decision", decision);
                            cmd.Parameters.AddWithValue("@remarks", string.IsNullOrWhiteSpace(txtFinalRemarks.Text) ? (object)DBNull.Value : txtFinalRemarks.Text.Trim());
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            _decisionId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }

                string newStatus = decision == "accepted" ? "accepted" : "rejected";
                StatusHistoryLoggerSafe(newStatus, $"Final decision: {decision}");

                string summary =
                    $"Decision: {lblDecision.Text}\n" +
                    $"Status: {lblStatus.Text}\n" +
                    $"Remarks: {txtFinalRemarks.Text}";

                MessageBox.Show("Final decision saved:\n" + summary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving decision: " + ex.Message);
            }
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

        private void txtFinalRemarks_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}