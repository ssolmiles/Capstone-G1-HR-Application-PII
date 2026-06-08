using Microsoft.Data.SqlClient;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public frmHRLogin()
        {
            InitializeComponent();
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM users WHERE email = @Email AND password = @Password AND is_active = 1";
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    frmHRDashboard dashboard = new frmHRDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Account not found or inactive.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Parameters.Clear();
            }
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}