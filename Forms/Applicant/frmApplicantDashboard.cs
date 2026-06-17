using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantDashboard : Form
    {
        private string userEmail;

        public frmApplicantDashboard()
        {
            InitializeComponent();
            userEmail = string.Empty;
        }

        // Runtime constructor
        public frmApplicantDashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmApplicantDashboard_Load_1(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadWelcomeName();
            LoadAuditTrail();
        }

        private void LoadWelcomeName()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT full_name FROM applicants WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            textBox1.Text = $"Welcome, {result}!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading name: " + ex.Message);
            }
        }

        private void LoadAuditTrail()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT
                    al.performed_at AS [Date & Time],
                    al.action       AS [Action],
                    al.target       AS [Area],
                    al.target_id    AS [Record ID]
                  FROM audit_logs al
                  INNER JOIN applicants ap
                      ON al.user_id = ap.applicant_id
                  WHERE ap.email = @Email
                  ORDER BY al.performed_at DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        var dt = new System.Data.DataTable();
                        new SqlDataAdapter(cmd).Fill(dt);
                        dgvAuditTrail.DataSource = dt;

                        // Color rows by action type
                        foreach (DataGridViewRow row in dgvAuditTrail.Rows)
                        {
                            string action = row.Cells["Action"].Value?.ToString().ToLower() ?? "";

                            if (action.Contains("submitted"))
                                row.DefaultCellStyle.ForeColor = Color.Green;
                            else if (action.Contains("deleted") || action.Contains("withdrew"))
                                row.DefaultCellStyle.ForeColor = Color.Red;
                            else if (action.Contains("uploaded"))
                                row.DefaultCellStyle.ForeColor = Color.Blue;
                            else if (action.Contains("draft"))
                                row.DefaultCellStyle.ForeColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audit trail: " + ex.Message);
            }
        }
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // 1. Latest application status
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT TOP 1 a.status
      FROM applications a
      INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
      WHERE ap.email = @Email
      ORDER BY a.last_updated DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string appStatus = result.ToString();
                            lblStatus.Text = "Application: " + appStatus;
                            switch (appStatus)
                            {
                                case "accepted":
                                    lblStatus.ForeColor = Color.Green; break;
                                case "rejected":
                                    lblStatus.ForeColor = Color.Red; break;
                                case "draft":
                                    lblStatus.ForeColor = Color.Gray; break;
                                case "under_review":
                                case "screened":
                                case "interview_scheduled":
                                case "interviewed":
                                    lblStatus.ForeColor = Color.Blue; break;
                                default:
                                    lblStatus.ForeColor = Color.DarkOrange; break;
                            }
                        }
                        else
                        {
                            lblStatus.Text = "Application: None yet";
                            lblStatus.ForeColor = Color.Gray;
                        }
                    }

                    // 2. Document count
                    // 2. Missing document count
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) 
      FROM applicant_documents
      WHERE applicant_id =
      (SELECT applicant_id FROM applicants WHERE email = @Email)
      AND status = 'submitted'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        int submittedDocs = Convert.ToInt32(cmd.ExecuteScalar());

                        // Required documents:
                        // Resume, Valid ID, Transcript of Records, Certificates
                        int totalRequiredDocs = 4;

                        int missingDocs = totalRequiredDocs - submittedDocs;

                        if (missingDocs < 0)
                            missingDocs = 0;

                        lblMissingDocs.Text = $"Missing document count: {missingDocs}";

                        lblMissingDocs.ForeColor =
                            (missingDocs == 0) ? Color.Green : Color.Red;
                    }

                    // 3. Interview schedule
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT TOP 1 s.scheduled_date, s.scheduled_time
                          FROM interview_schedules s
                          INNER JOIN applications a ON s.application_id = a.application_id
                          INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                          WHERE ap.email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string date = Convert.ToDateTime(dr["scheduled_date"]).ToString("MMMM dd, yyyy");
                                string time = dr["scheduled_time"].ToString();
                                lblSchedule.Text = $"Interview Schedule: {date} at {time}";
                            }
                            else
                            {
                                lblSchedule.Text = "No schedule yet.";
                            }
                        }
                    }

                    // 4. Upcoming interview count
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) 
                          FROM interview_schedules s
                          INNER JOIN applications a ON s.application_id = a.application_id
                          INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                          WHERE ap.email = @Email AND s.status = 'scheduled'", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        label1.Text = $"Upcoming Interview: {count}";
                    }

                    lblUpdates.Text =
                        "RECENT UPDATES:\n" +
                        "- Application review is ongoing.\n" +
                        "- Please check your email regularly.\n" +
                        "- New requirements posted.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile profile = new frmMyProfile(userEmail);
            profile.ShowDialog();
            LoadAuditTrail();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword cp = new frmChangePassword(userEmail);
            cp.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmApplicantLogin login = new frmApplicantLogin();
            login.Show();
            this.Close();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            frmApplicationStatus statusForm = new frmApplicationStatus(userEmail);
            statusForm.Show();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            frmJobVacancies jobForm = new frmJobVacancies(userEmail);
            jobForm.Show();
            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            using (frmMyApplication myApp = new frmMyApplication(userEmail))
            {
                myApp.ShowDialog(this);
            }
            LoadDashboardData();
            LoadAuditTrail();
        }


        // --- Stub handlers ---
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void lblMissingDocs_Click(object sender, EventArgs e) { }
        private void lblSchedule_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}