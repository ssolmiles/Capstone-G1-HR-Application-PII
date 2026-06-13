using HRApplicantSystem.Forms.HR;
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
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new HRApplicantSystem.Forms.frmRoleSelection().Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Enter email and password."); return; }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT user_id, full_name, password, role FROM users" +
                        " WHERE email=@e AND is_active=1", conn))
                    {
                        cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read()) { ShowFail(); return; }

                            int uid = Convert.ToInt32(dr["user_id"]);
                            string name = dr["full_name"].ToString();
                            string hash = dr["password"].ToString();
                            string role = dr["role"].ToString();
                            dr.Close();

                            bool ok = false;
                            bool needsUpgrade = false;

                            if (hash.StartsWith("$2"))  // BCrypt hash
                            {
                                ok = BCrypt.Net.BCrypt.Verify(txtPassword.Text.Trim(), hash);
                            }
                            else  // plaintext (seed data) — compare directly
                            {
                                ok = hash == txtPassword.Text.Trim();
                                needsUpgrade = ok;
                            }

                            if (!ok) { ShowFail(); return; }

                            // Auto-upgrade plaintext password to BCrypt
                            if (needsUpgrade)
                            {
                                string newHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim());
                                using (var upd = new SqlCommand(
                                    "UPDATE users SET password=@h WHERE user_id=@id", conn))
                                {
                                    upd.Parameters.AddWithValue("@h", newHash);
                                    upd.Parameters.AddWithValue("@id", uid);
                                    upd.ExecuteNonQuery();
                                }
                            }

                            // Store complete user in session (with UserID!)
                            SessionManager.Login(new HRApplicantSystem.Models.User
                            {
                                UserID = uid,
                                FullName = name,
                                Email = txtEmail.Text.Trim(),
                                Role = role,
                                IsActive = true
                            });

                            new frmHRDashboard().Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Login error: " + ex.Message); }
        }

        private void ShowFail()
        {
            MessageBox.Show("Invalid email or password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtPassword.Clear(); txtPassword.Focus();
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