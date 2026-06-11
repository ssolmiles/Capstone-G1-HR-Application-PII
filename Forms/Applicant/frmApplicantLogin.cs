using System;
using System.Windows.Forms;
using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;

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
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT password FROM applicants WHERE email = @Email AND (is_active = 1 OR is_active IS NULL)",
                        conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null &&
                            BCrypt.Net.BCrypt.Verify(
                                txtPassword.Text.Trim(),
                                result.ToString()))
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

                            txtPassword.Clear();
                            txtPassword.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MigratePasswords()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    var users = new System.Collections.Generic.List<(int id, string pass)>();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT applicant_id, password FROM applicants WHERE password NOT LIKE '$2%'", conn))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            users.Add(((int)dr["applicant_id"], dr["password"].ToString()));
                    }

                    foreach (var (id, pass) in users)
                    {
                        string hashed = BCrypt.Net.BCrypt.HashPassword(pass);
                        using (SqlCommand upd = new SqlCommand(
                            "UPDATE applicants SET password = @Hash WHERE applicant_id = @Id", conn))
                        {
                            upd.Parameters.AddWithValue("@Hash", hashed);
                            upd.Parameters.AddWithValue("@Id", id);
                            upd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Migration complete! All passwords are now hashed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Migration error: " + ex.Message);
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}