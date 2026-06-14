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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new HRApplicantSystem.Forms.frmRoleSelection().Show();
            this.Close();
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
    "SELECT user_id, full_name, password, role FROM users WHERE email = @Email AND is_active = 1",
    conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string storedHash = dr["password"].ToString();
                                string role = dr["role"].ToString();
                                int userId = Convert.ToInt32(dr["user_id"]);
                                string fullName = dr["full_name"] == DBNull.Value ? "" : dr["full_name"].ToString();

                                if (BCrypt.Net.BCrypt.Verify(txtPassword.Text.Trim(), storedHash))
                                {
                                    SessionManager.Login(
                                        new HRApplicantSystem.Models.User
                                        {
                                            UserID = userId,
                                            FullName = fullName,
                                            Email = txtEmail.Text.Trim(),
                                            Role = role,
                                            IsActive = true
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

        private void lblCreateAccount_Click(object sender, EventArgs e)
        {
            new frmHRRegister().Show();
            this.Hide();
        }
    }
}