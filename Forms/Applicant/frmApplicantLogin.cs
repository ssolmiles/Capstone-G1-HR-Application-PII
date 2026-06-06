using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantLogin : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        public frmApplicantLogin()
        {
            InitializeComponent();
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string login = "SELECT * FROM tbl_users WHERE username = '" + txtEmail.Text + "' and password = '" + txtPassword.Text + "'";
            cmd.Connection = conn;
            cmd.CommandText = login;

            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
            dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                frmApplicantDashboard dash = new
                frmApplicantDashboard(txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Invalid Email or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtPassword.Text = "";
                txtEmail.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';

            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void lblCreateAcc_Click(object sender, EventArgs e)
        {
            new frmApplicantRegister().Show();
            this.Hide();
        }

        private void linklblFgtPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword cp = new
            frmChangePassword(txtEmail.Text);
            cp.Show();
            this.Hide();
        }
    }
}
