using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRLogin : Form
    {
        public frmHRLogin()
        {
            InitializeComponent();
        }
        private void frmHRLogin_Load(object sender, EventArgs e) { }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT password, role FROM users WHERE email = @Email AND is_active = 1",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string storedHash = dr["password"].ToString();
                                string role = dr["role"].ToString();

                                if (BCrypt.Net.BCrypt.Verify(
                                    txtPassword.Text.Trim(),
                                    storedHash))
                                {
                                    SessionManager.Login(
                                        new HRApplicantSystem.Models.User
                                        {
                                            Email = txtEmail.Text.Trim(),
                                            Role = role
                                        });

                                    frmHRDashboard dashboard = new frmHRDashboard();
                                    dashboard.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show(
                                        "Invalid Email or Password",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);

                                    txtPassword.Clear();
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid Email or Password",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                txtPassword.Clear();
                                txtPassword.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblPassword_Click(object sender, EventArgs e) { }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
    }
}