using System;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewEvaluation : Form
    {
        private readonly int _applicationId;
        private int? _scheduleId;
        private int? _evaluationId;

        public frmInterviewEvaluation(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;

            button1.Click += btnPass_Click;
            button2.Click += btnFail_Click;
            button3.Click += btnSave_Click;
            button4.Click += btnNext_Click;
        }

        private void frmInterviewEvaluation_Load(object sender, EventArgs e)
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

                    // Latest interview schedule for this application
                    using (var cmd = new SqlCommand(
                        "SELECT TOP 1 schedule_id FROM interview_schedules WHERE application_id = @id ORDER BY schedule_id DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationId);
                        var result = cmd.ExecuteScalar();
                        if (result != null) _scheduleId = Convert.ToInt32(result);
                    }

                    // Existing evaluation, if any
                    using (var cmd = new SqlCommand(@"
                        SELECT TOP 1 evaluation_id, score, remarks, recommendation, result
                        FROM interview_evaluations
                        WHERE application_id = @id
                        ORDER BY evaluation_id DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _applicationId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                _evaluationId = Convert.ToInt32(reader["evaluation_id"]);

                                if (reader["score"] != DBNull.Value)
                                    txtScore.Text = Convert.ToDecimal(reader["score"]).ToString(CultureInfo.InvariantCulture);

                                if (reader["remarks"] != DBNull.Value)
                                    txtRemarks.Text = reader["remarks"].ToString();

                                if (reader["recommendation"] != DBNull.Value)
                                    txtRecommendation.Text = reader["recommendation"].ToString();

                                string result = reader["result"] as string;
                                if (result == "pass")
                                    SetResult("Result: Pass", true);
                                else if (result == "fail")
                                    SetResult("Result: Fail", false);
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

        private void SetResult(string text, bool pass)
        {
            lblResult.Text = text;
            lblResult.ForeColor = pass
                ? System.Drawing.Color.FromArgb(26, 122, 60)
                : System.Drawing.Color.FromArgb(192, 57, 43);
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            SetResult("Result: Pass", true);
            MessageBox.Show("Applicant marked as PASS.\nScore: " + txtScore.Text + "\nRemarks: " + txtRemarks.Text);
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            SetResult("Result: Fail", false);
            MessageBox.Show("Applicant marked as FAIL.\nScore: " + txtScore.Text + "\nRemarks: " + txtRemarks.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtScore.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal score))
            {
                MessageBox.Show("Please enter a valid numeric score (0-100).");
                return;
            }

            string result;
            if (lblResult.Text == "Result: Pass") result = "pass";
            else if (lblResult.Text == "Result: Fail") result = "fail";
            else
            {
                MessageBox.Show("Please mark the result as Pass or Fail before saving.");
                return;
            }

            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;

                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    if (_evaluationId.HasValue)
                    {
                        string update = @"
                            UPDATE interview_evaluations
                            SET score = @score, remarks = @remarks, recommendation = @recommendation,
                                result = @result, evaluated_by = @userId, evaluated_at = @now
                            WHERE evaluation_id = @evalId";

                        using (var cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@score", score);
                            cmd.Parameters.AddWithValue("@remarks", string.IsNullOrWhiteSpace(txtRemarks.Text) ? (object)DBNull.Value : txtRemarks.Text.Trim());
                            cmd.Parameters.AddWithValue("@recommendation", string.IsNullOrWhiteSpace(txtRecommendation.Text) ? (object)DBNull.Value : txtRecommendation.Text.Trim());
                            cmd.Parameters.AddWithValue("@result", result);
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            cmd.Parameters.AddWithValue("@evalId", _evaluationId.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        string insert = @"
                            INSERT INTO interview_evaluations
                                (schedule_id, application_id, score, remarks, recommendation, result, evaluated_by, evaluated_at)
                            OUTPUT INSERTED.evaluation_id
                            VALUES
                                (@scheduleId, @appId, @score, @remarks, @recommendation, @result, @userId, @now)";

                        using (var cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@scheduleId", (object)_scheduleId ?? DBNull.Value);
                            cmd.Parameters.AddWithValue("@appId", _applicationId);
                            cmd.Parameters.AddWithValue("@score", score);
                            cmd.Parameters.AddWithValue("@remarks", string.IsNullOrWhiteSpace(txtRemarks.Text) ? (object)DBNull.Value : txtRemarks.Text.Trim());
                            cmd.Parameters.AddWithValue("@recommendation", string.IsNullOrWhiteSpace(txtRecommendation.Text) ? (object)DBNull.Value : txtRecommendation.Text.Trim());
                            cmd.Parameters.AddWithValue("@result", result);
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@now", DateTime.Now);
                            _evaluationId = Convert.ToInt32(cmd.ExecuteScalar());
                        }
                    }
                }

                string newAppStatus = result == "pass" ? "interviewed" : "rejected";
                StatusHistoryLoggerSafe(newAppStatus, $"Interview evaluation result: {result}");

                string summary = $"Score: {txtScore.Text}\nRemarks: {txtRemarks.Text}\nResult: {lblResult.Text}\nRecommendation: {txtRecommendation.Text}";
                MessageBox.Show("Evaluation saved:\n" + summary);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving evaluation: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmHiringDecision finalForm = new frmHiringDecision(_applicationId);
            finalForm.Show();
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