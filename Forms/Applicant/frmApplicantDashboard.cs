using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantDashboard : Form
    {
        private string userEmail;

        public frmApplicantDashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmApplicantDashboard_Load_1(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadWelcomeName();
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

        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // 1. Applicant status
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT is_active FROM applicants WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                bool isActive = dr["is_active"] != DBNull.Value && (bool)dr["is_active"];
                                lblStatus.Text = "Status: " + (isActive ? "Active" : "Inactive");
                                lblStatus.ForeColor = isActive ? Color.Green : Color.Red;
                            }
                        }
                    }

                    // 2. Document count
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) 
                          FROM applicant_documents 
                          WHERE applicant_id = 
                          (SELECT applicant_id FROM applicants WHERE email = @Email)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        int docCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (docCount == 0)
                        {
                            lblMissingDocs.Text = "ALERT: Documents are missing!";
                            lblMissingDocs.ForeColor = Color.Red;
                        }
                        else
                        {
                            lblMissingDocs.Text = "Documents Complete";
                            lblMissingDocs.ForeColor = Color.Green;
                        }
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
                                lblSchedule.Text = "No schedule yet. Please wait.";
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

        // --- Stub handlers ---
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void lblMissingDocs_Click(object sender, EventArgs e) { }
        private void lblSchedule_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}