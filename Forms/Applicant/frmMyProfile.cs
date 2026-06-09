using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmMyProfile : Form
    {
        private string userEmail;

        public frmMyProfile(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmMyProfile_Load_1(object sender, EventArgs e)
        {
            LoadProfileData();
            SetReadOnly(true);
        }

        private void LoadProfileData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT full_name, birthdate, address, phone, email,
                                 school, skills, company
                          FROM applicants WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string fullName = dr["full_name"].ToString();
                                string[] nameParts = fullName.Split(' ');
                                txtFN.Text = nameParts.Length > 0 ? nameParts[0] : "";
                                txtMI.Text = nameParts.Length > 2 ? nameParts[1] : "";
                                txtLN.Text = nameParts.Length > 1 ? nameParts[nameParts.Length - 1] : "";

                                if (dr["birthdate"] != DBNull.Value)
                                    dtpBirthday.Value = Convert.ToDateTime(dr["birthdate"]);

                                txtAddress.Text = dr["address"].ToString();
                                txtPhone.Text = dr["phone"].ToString();
                                txtEmail.Text = dr["email"].ToString();
                                txtEducation.Text = dr["school"].ToString();
                                txtSkills.Text = dr["skills"].ToString();
                                txtWorkExp.Text = dr["company"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetReadOnly(false);
            MessageBox.Show("You can now edit your profile. Click Save when done.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE applicants SET 
                            full_name = @FullName,
                            birthdate = @Bday,
                            address   = @Address,
                            phone     = @Phone,
                            school    = @Edu,
                            skills    = @Skills,
                            company   = @WorkExp
                          WHERE email = @OriginalEmail", conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", $"{txtFN.Text.Trim()} {txtMI.Text.Trim()} {txtLN.Text.Trim()}");
                        cmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value.Date);
                        cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Edu", txtEducation.Text.Trim());
                        cmd.Parameters.AddWithValue("@Skills", txtSkills.Text.Trim());
                        cmd.Parameters.AddWithValue("@WorkExp", txtWorkExp.Text.Trim());
                        cmd.Parameters.AddWithValue("@OriginalEmail", userEmail);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Profile Updated Successfully!");
                SetReadOnly(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void SetReadOnly(bool isReadOnly)
        {
            txtFN.ReadOnly = isReadOnly;
            txtMI.ReadOnly = isReadOnly;
            txtLN.ReadOnly = isReadOnly;
            txtAddress.ReadOnly = isReadOnly;
            txtCountry.ReadOnly = isReadOnly;
            txtPhone.ReadOnly = isReadOnly;
            txtEducation.ReadOnly = isReadOnly;
            txtSkills.ReadOnly = isReadOnly;
            txtWorkExp.ReadOnly = isReadOnly;

            Color c = isReadOnly ? Color.LightGray : Color.White;
            txtFN.BackColor = c;
            txtMI.BackColor = c;
            txtLN.BackColor = c;
            txtAddress.BackColor = c;
            txtCountry.BackColor = c;
            txtPhone.BackColor = c;
            txtEducation.BackColor = c;
            txtSkills.BackColor = c;
            txtWorkExp.BackColor = c;
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        // --- Stub handlers wired in Designer ---
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void lblEducationBg_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void textBox6_TextChanged(object sender, EventArgs e) { }
    }
}