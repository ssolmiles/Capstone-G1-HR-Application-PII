using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantRegister : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public frmApplicantRegister()
        {
            InitializeComponent();
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void frmApplicantRegister_Load(object sender, EventArgs e)
        {
            txtFN.Text = "e.g. Juan";
            txtMI.Text = "e.g. Santos";
            txtLN.Text = "e.g. Dela Cruz";
            txtEmail.ReadOnly = true;
            txtEmail.BackColor = System.Drawing.Color.LightGray;
            cboCountry.Items.Add("Philippines (+63)");
            cboCountry.Items.Add("United States (+1)");
            cboCountry.Items.Add("Australia (+61)");
            cboCountry.Items.Add("Japan (+81)");
            cboCountry.Items.Add("Singapore (+65)");
            cboCountry.Items.Add("Canada (+1)");
            cboCountry.Items.Add("United Kingdom (+44)");
            cboCountry.Text = "Philippines (+63)";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!chkAgree.Checked)
            {
                MessageBox.Show("Please check the box if you understand the terms.");
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;

                // Check if email already exists
                cmd.CommandText = "SELECT COUNT(*) FROM applicants WHERE email = @Email";
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Email is already registered!");
                    conn.Close();
                    cmd.Parameters.Clear();
                    return;
                }
                cmd.Parameters.Clear();

                // Insert new applicant using correct column names
                cmd.CommandText = @"INSERT INTO applicants 
                    (full_name, email, password, phone, birthdate, is_active) 
                    VALUES (@FullName, @Email, @Password, @Phone, @Bday, @IsActive)";
                cmd.Parameters.AddWithValue("@FullName", txtFN.Text.Trim() + " " + txtMI.Text.Trim() + " " + txtLN.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@IsActive", false);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration Successful!");
                frmMyProfile profile = new frmMyProfile(txtEmail.Text.Trim());
                profile.Show();
                this.Hide();
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

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}