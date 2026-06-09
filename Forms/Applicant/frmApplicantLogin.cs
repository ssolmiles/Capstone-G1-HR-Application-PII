using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantLogin : Form
    {
        public frmApplicantLogin()
        {
            InitializeComponent();
        }

        private void frmApplicantLogin_Load(object sender, EventArgs e)
        {
            // Initialization on form load if needed
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT COUNT(*) FROM applicants WHERE email = @Email AND password = @Password",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                        int result = (int)cmd.ExecuteScalar();

                        if (result > 0)
                        {
                            frmApplicantDashboard dash =
                                new frmApplicantDashboard(txtEmail.Text.Trim());
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Invalid Email or Password",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtEmail.Clear();
                            txtPassword.Clear();
                            txtEmail.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            txtEmail.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = CheckbxShowPas.Checked ? '\0' : '•';
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