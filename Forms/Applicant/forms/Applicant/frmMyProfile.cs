using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmMyProfile : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string userEmail;

        public frmMyProfile(string email)
        {
            InitializeComponent();
            userEmail = email;
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void frmMyProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
            SetReadOnly(true);
        }

        private void LoadProfileData()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT full_name, birthdate, address, phone, email,
                                    school, skills, company FROM applicants WHERE email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                SqlDataReader dr = cmd.ExecuteReader();
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
                dr.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"UPDATE applicants SET 
                                    full_name = @FullName,
                                    birthdate = @Bday, 
                                    address = @Address, 
                                    phone = @Phone,
                                    school = @Edu, 
                                    skills = @Skills, 
                                    company = @WorkExp 
                                    WHERE email = @OriginalEmail";
                cmd.Parameters.AddWithValue("@FullName", txtFN.Text + " " + txtMI.Text + " " + txtLN.Text);
                cmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Edu", txtEducation.Text);
                cmd.Parameters.AddWithValue("@Skills", txtSkills.Text);
                cmd.Parameters.AddWithValue("@WorkExp", txtWorkExp.Text);
                cmd.Parameters.AddWithValue("@OriginalEmail", userEmail);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile Updated Successfully");
                SetReadOnly(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
            finally
            {
                conn.Close();
                cmd.Parameters.Clear();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}