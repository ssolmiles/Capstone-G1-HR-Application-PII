using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRLogin : Form
    {
        // Simple in-memory account store (replace with DB later)
        private static List<UserAccount> accounts = new List<UserAccount>();

        private UserAccount loggedInUser = null;

        public frmHRLogin()
        {
            InitializeComponent();
        }

        // LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            var account = accounts.FirstOrDefault(a => a.Email == email);

            if (account == null)
            {
                MessageBox.Show("Account not found.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!account.IsActive)
            {
                MessageBox.Show("Account is inactive. Contact admin.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (account.Password == password)
            {
                loggedInUser = account;
                MessageBox.Show("Login successful!", "Welcome",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Navigate to Dashboard
                frmHRDashboard dashboard = new frmHRDashboard();
                dashboard.Show();

                // Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid password.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // REGISTER
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (accounts.Any(a => a.Email == email))
            {
                MessageBox.Show("Email already exists.", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            accounts.Add(new UserAccount
            {
                Email = email,
                Password = password,
                IsActive = true
            });

            MessageBox.Show("Account registered successfully!", "Registration",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    // Simple account model
    public class UserAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
