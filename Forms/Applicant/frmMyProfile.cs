using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                cmd.CommandText = @"SELECT FirstName, MiddleName, LastName, Birthdate, Address, Country, PhoneNumber, Email,
                                    Education, Skills, WorkExperience FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // PERSONAL INFOS
                    txtFN.Text = dr["FirstName"].ToString();
                    txtMI.Text = dr["MiddleName"].ToString();
                    txtLN.Text = dr["LastName"].ToString();
                    dtpBirthday.Value = Convert.ToDateTime(dr["BirthDate"]);
                    // ADDRESS & CONTACT
                    txtAddress.Text = dr["Address"].ToString();
                    txtCountry.Text = dr["Country"].ToString();
                    txtPhone.Text = dr["PhoneNumber"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    // OTHERS
                    txtEducation.Text = dr["Education"].ToString();
                    txtSkills.Text = dr["Skills"].ToString();
                    txtWorkExp.Text = dr["WorkExperience"].ToString();
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
            // TURN ON EDIT MODE    
            SetReadOnly(false);
            MessageBox.Show("You can now edit your profile. Click Save when done.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"UPDATE ApplicantRegister SET FirstName = @FN, MiddleName = @MI, LastName = @LN,
                                     Birthdate = @Bday, Address = @Address, Country = @Country, PhoneNumber = @Phone,
                                     Education = @Edu, Skills = @Skills, WorkExperience = @WorkExp WHERE Email = @OriginalEmail";
                // PASS VALUE
                cmd.Parameters.AddWithValue("@FN", txtFN.Text);
                cmd.Parameters.AddWithValue("@MI", txtMI.Text);
                cmd.Parameters.AddWithValue("@LN", txtLN.Text);
                cmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
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

            if (isReadOnly)
            {
                txtFN.BackColor = System.Drawing.Color.LightGray;
                txtMI.BackColor = System.Drawing.Color.LightGray;
                txtLN.BackColor = System.Drawing.Color.LightGray;
                txtAddress.BackColor = System.Drawing.Color.LightGray;
                txtCountry.BackColor = System.Drawing.Color.LightGray;
                txtPhone.BackColor = System.Drawing.Color.LightGray;
                txtEducation.BackColor = System.Drawing.Color.LightGray;
                txtSkills.BackColor = System.Drawing.Color.LightGray;
                txtWorkExp.BackColor = System.Drawing.Color.LightGray;
            }
            else
            {
                txtFN.BackColor = System.Drawing.Color.White;
                txtMI.BackColor = System.Drawing.Color.White;
                txtLN.BackColor = System.Drawing.Color.White;
                txtAddress.BackColor = System.Drawing.Color.White;
                txtCountry.BackColor = System.Drawing.Color.White;
                txtPhone.BackColor = System.Drawing.Color.White;
                txtEducation.BackColor = System.Drawing.Color.White;
                txtSkills.BackColor = System.Drawing.Color.White;
                txtWorkExp.BackColor = System.Drawing.Color.White;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmApplicantDashboard dash = new
            frmApplicantDashboard(userEmail);
            dash.Show();
            this.Hide();
        }
    }
}
