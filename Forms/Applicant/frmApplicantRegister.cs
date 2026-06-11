using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantRegister : Form
    {
        public frmApplicantRegister()
        {
            InitializeComponent();
        }

        private void frmApplicantRegister_Load_1(object sender, EventArgs e)
        {
            txtFN.Text = "e.g. Cj";
            txtMI.Text = "e.g.  []";
            txtLN.Text = "e.g. Zamora";
            txtEmail.ReadOnly = false;

            cboCountry.Items.Add("Philippines (+63)");
            cboCountry.Items.Add("United States (+1)");
            cboCountry.Items.Add("Australia (+61)");
            cboCountry.Items.Add("Japan (+81)");
            cboCountry.Items.Add("Singapore (+65)");
            cboCountry.Items.Add("Canada (+1)");
            cboCountry.Items.Add("United Kingdom (+44)");
            cboCountry.Text = "Philippines (+63)";

            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");
            cboGender.Text = "";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!chkAgree.Checked)
            {
                MessageBox.Show("Please check the box if you understand the terms.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFN.Text) || string.IsNullOrWhiteSpace(txtLN.Text))
            {
                MessageBox.Show("Please enter your first and last name.");
                return;
            }

            if (cboGender.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Please select your gender.");
                return;
            }

            string fullName = $"{txtFN.Text.Trim()} {txtMI.Text.Trim()} {txtLN.Text.Trim()}";

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Check if email already exists
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM applicants WHERE email = @Email", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("Email is already registered!");
                            return;
                        }
                    }

                    // Insert new applicant
                    using (SqlCommand insertCmd = new SqlCommand(
                        @"INSERT INTO applicants 
                            (full_name, email, password, phone, birthdate, gender, is_active) 
                          VALUES 
                            (@FullName, @Email, @Password, @Phone, @Bday, @Gender, @IsActive)",
                        conn))
                    {
                        insertCmd.Parameters.AddWithValue("@FullName", fullName);
                        insertCmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@Password", BCrypt.Net.BCrypt.HashPassword(txtPassword.Text.Trim()));
                        insertCmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value.Date);
                        insertCmd.Parameters.AddWithValue("@Gender", cboGender.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@IsActive", true);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration Successful!");
                frmMyProfile profile = new frmMyProfile(txtEmail.Text.Trim());
                profile.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e) { }
    }
}