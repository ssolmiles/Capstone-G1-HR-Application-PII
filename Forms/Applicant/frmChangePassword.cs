using Microsoft.Data.SqlClient;
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

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmChangePassword : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string currentUserEmail;
        public frmChangePassword(string userEmail)
        {
            InitializeComponent();
            currentUserEmail = userEmail; 
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtCurrentPass.Text) ||
                string.IsNullOrWhiteSpace(txtNewPass.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("New Password does not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtNewPass.TextLength < 5)
            {
                MessageBox.Show(" The new password should be of at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtCurrentPass.Text == txtNewPass.Text)
            {
                MessageBox.Show("Password is the same. Re-enter new password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT password FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", currentUserEmail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string dbPassword = dr["password"].ToString();
                    dr.Close();
                    if (dbPassword != txtCurrentPass.Text)
                    {
                        MessageBox.Show("Current Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.CommandText = "UPDATE ApplicantRegister SET password = @NewPass WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@NewPass", txtNewPass.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Password Changed Successfully!");
                this.Close();
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
        private void chkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPass.Checked)
            {
                txtCurrentPass.PasswordChar = '\0';
                txtNewPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtCurrentPass.PasswordChar = '•';
                txtNewPass.PasswordChar = '•';
                txtConfirmPass.PasswordChar = '•';
            }
        }
    }
}
