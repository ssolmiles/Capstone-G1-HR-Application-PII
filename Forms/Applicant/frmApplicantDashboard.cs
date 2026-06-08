using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantDashboard : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string userEmail;

        public frmApplicantDashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void frmApplicantDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;

                // Load applicant status
                cmd.CommandText = "SELECT is_active FROM applicants WHERE email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    bool isActive = dr["is_active"] != DBNull.Value && (bool)dr["is_active"];
                    lblStatus.Text = "Status: " + (isActive ? "Active" : "Inactive");
                    lblStatus.ForeColor = isActive ? System.Drawing.Color.Green : System.Drawing.Color.Red;
                }
                dr.Close();
                cmd.Parameters.Clear();

                // Load documents
                cmd.CommandText = "SELECT COUNT(*) FROM applicant_documents WHERE applicant_id = (SELECT applicant_id FROM applicants WHERE email = @Email)";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                int docCount = Convert.ToInt32(cmd.ExecuteScalar());
                if (docCount == 0)
                {
                    lblMissingDocs.Text = "ALERT: Documents are missing!";
                    lblMissingDocs.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    lblMissingDocs.Text = "Documents Complete";
                    lblMissingDocs.ForeColor = System.Drawing.Color.Green;
                }
                cmd.Parameters.Clear();

                // Load interview schedule
                cmd.CommandText = @"SELECT s.scheduled_date, s.scheduled_time FROM interview_schedules s
                                    INNER JOIN applications a ON s.application_id = a.application_id
                                    INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                                    WHERE ap.email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
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
                dr.Close();
                cmd.Parameters.Clear();

                lblUpdates.Text = "RECENT UPDATES:\n- Application review is ongoing.\n- Please check your email regularly.\n- New requirements posted.";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile profile = new frmMyProfile(userEmail);
            profile.ShowDialog(); // ← use ShowDialog instead of Show
                                  // No need to hide dashboard, it stays open behind
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

        private void frmApplicantDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblMissingDocs_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSchedule_Click(object sender, EventArgs e)
        {

        }
    }
}