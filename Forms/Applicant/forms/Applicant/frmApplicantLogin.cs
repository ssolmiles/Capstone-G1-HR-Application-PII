using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;

        public frmApplicantLogin()
        {
            InitializeComponent();
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM applicants WHERE email = @Email AND password = @Password";
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frmApplicantDashboard dash = new frmApplicantDashboard(txtEmail.Text.Trim());
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtPassword.Text = "";
                    txtEmail.Focus();
                }
                dr.Close();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '•';
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            new frmApplicantRegister().Show();
            this.Hide();
        }

        private void linklblFgtPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword cp = new frmChangePassword(txtEmail.Text);
            cp.Show();
            this.Hide();
        }
    }
}