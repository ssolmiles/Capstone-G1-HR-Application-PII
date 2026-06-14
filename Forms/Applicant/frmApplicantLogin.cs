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

        // FIX: Renamed from btnLogin_Click → btnLogIn_Click to match Designer wire-up
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Enter email and password."); return; }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT applicant_id, full_name, password, is_active FROM applicants WHERE email=@e", conn))
                    {
                        cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                        using (var dr = cmd.ExecuteReader())
                        {
                            if (!dr.Read()) { ShowFail(); return; }

                            bool isActive = dr["is_active"] != DBNull.Value && Convert.ToBoolean(dr["is_active"]);
                            if (!isActive) { MessageBox.Show("This account is inactive."); return; }

                            string hash = dr["password"].ToString();
                            string name = dr["full_name"].ToString();
                            dr.Close();

                            bool ok = BCrypt.Net.BCrypt.Verify(txtPassword.Text.Trim(), hash);
                            if (!ok) { ShowFail(); return; }

                            SessionManager.LoginApplicant(new HRApplicantSystem.Models.Applicant
                            {
                                Email = txtEmail.Text.Trim(),
                                FullName = name
                            });

                            new frmApplicantDashboard(txtEmail.Text.Trim()).Show();
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