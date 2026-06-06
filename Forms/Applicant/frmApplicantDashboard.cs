using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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
                cmd.CommandText = "SELECT Status FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string status = dr["Status"].ToString();
                    lblStatus.Text = "Status: " + status;
                    if (status == "Active")
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                    else if (status == "Inactive")
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                    else
                        lblStatus.ForeColor = System.Drawing.Color.Orange;
                }
                dr.Close();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT DocumentsSubmitted FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                var docs = cmd.ExecuteScalar();
                if (docs == null || string.IsNullOrEmpty(docs.ToString()))
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
                cmd.CommandText = "SELECT ScheduleDate, Time FROM InterviewSchedule WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string date = Convert.ToDateTime(dr["ScheduleDate"]).ToString("MMMM dd, yyyy");
                    string time = dr["Time"].ToString();
                    lblSchedule.Text = $"Interview Schedule: {date} at {time}";
                }
                else
                {
                    lblSchedule.Text = "No schedule yet. Please wait.";
                }
                dr.Close();
                cmd.Parameters.Clear();

                lblUpdates.Text = "RECENT UPDATES:\n" + "- Application review is ongoing.\n" + "- Please check your email regularly.\n"
                    + "- New requirements posted.";
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
            profile.Show();
            this.Hide();
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
            frmApplicationStatus statusForm = new
            frmApplicationStatus(userEmail);
            statusForm.Show();
        }
    }
}
