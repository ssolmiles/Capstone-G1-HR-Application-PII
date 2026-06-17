using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRDashboard : Form
    {
        public frmHRDashboard()
        {
            InitializeComponent();
        }

        private void frmHRDashboard_Load(object sender, EventArgs e)
        {
            lblTitle.Text = $"Welcome, {SessionManager.CurrentUser?.FullName ?? "HR"}!";
            LoadRecruitmentSummary();
            button6.Visible = (SessionManager.CurrentRole == "admin");
        }

        private void LoadRecruitmentSummary()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM applicants", conn))
                    {
                        textBox1.Text = "Total Applicants: " + cmd.ExecuteScalar();
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM interview_schedules WHERE status = 'scheduled'", conn))
                    {
                        textBox2.Text = "Interviews Scheduled: " + cmd.ExecuteScalar();
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM hiring_decisions WHERE final_decision = 'accepted'", conn))
                    {
                        textBox3.Text = "Accepted: " + cmd.ExecuteScalar();
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM hiring_decisions WHERE final_decision = 'rejected'", conn))
                    {
                        textBox4.Text = "Rejected: " + cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                textBox1.Text = "Total Applicants: —";
                textBox2.Text = "Interviews Scheduled: —";
                textBox3.Text = "Accepted: —";
                textBox4.Text = "Rejected: —";
                MessageBox.Show("Error loading summary: " + ex.Message);
            }
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            frmApplicantList applicantListForm = new frmApplicantList();
            applicantListForm.Show();
            this.Hide();
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
            frmApplicantReview reviewForm = new frmApplicantReview();
            reviewForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reportsForm = new frmReports();
            reportsForm.Show();
            this.Hide();
        }

        private void btnVacancyManagement_Click(object sender, EventArgs e)
        {
            new HRApplicantSystem.Forms.Maintenance.frmJobVacancyManagement().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
            new HRApplicantSystem.Forms.HR.frmHRLogin().Show();
            this.Close();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            new HRApplicantSystem.Forms.Maintenance.frmMaintenance().ShowDialog();
        }

        // --- Stub handlers wired in Designer ---
        private void grpQuickLinks_Enter(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}