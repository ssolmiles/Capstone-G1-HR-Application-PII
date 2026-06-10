using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

                cmd.CommandText = "SELECT COUNT(*) FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("Email", txtEmail.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Email is already registered!");
                    return;
                }

                cmd.Connection = conn;
                cmd.CommandText = @"INSERT INTO Applicant Register (FirstName, Middle Name, LastName, BirthDate, Email, 
                                  CountryCode, PhoneNumber, Status) VALUES (@FN, @MI, @LN, @Bday, @Email, @Country, @Phone, @Status)";

                cmd.Parameters.AddWithValue("@FN", txtFN.Text);
                cmd.Parameters.AddWithValue("@MI", txtMI.Text);
                cmd.Parameters.AddWithValue("@LN", txtLN.Text);
                cmd.Parameters.AddWithValue("@Bday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Country", cboCountry.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Status", "Inactive");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful!");

                frmMyProfile profile = new frmMyProfile();
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
    }
}
