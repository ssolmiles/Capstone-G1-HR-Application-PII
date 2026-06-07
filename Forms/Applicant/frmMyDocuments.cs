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
    public partial class frmMyDocuments : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string userEmail;
        public frmMyDocuments(string email)
        {
            InitializeComponent();
            userEmail = email;
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }
        private void frmMyDocuments_Load(object sender, EventArgs e)
        {
            LoadDocumentStatus();
        }
        private void LoadDocumentStatus()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT Resume, ID_Card, Transcript, Certificates, Remarks, Doc_Status FROM ApplicantRegister
                                    WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    lblResumeStatus.Text = string.IsNullOrEmpty(dr["Resume"].ToString()) ? "Missing" : "Submitted";
                    lblIDStatus.Text = string.IsNullOrEmpty(dr["ID_Card"].ToString()) ? "Missing" : "Submitted";
                    lblTranscriptStatus.Text = string.IsNullOrEmpty(dr["Transcript"].ToString()) ? "Missing" : "Submitted";
                    lblCertStatus.Text = string.IsNullOrEmpty(dr["Certificates"].ToString()) ? "Missing" : "Submitted";

                    txtRemarks.Text = dr["Remarks"].ToString();
                    string overall = dr["Doc_Status"].ToString();
                    lblOverallStatus.Text = "Overall Status: " + overall;
                    if (overall == "Complete")
                        lblOverallStatus.ForeColor = System.Drawing.Color.Green;
                    else
                        lblOverallStatus.ForeColor = System.Drawing.Color.Red;
                }
                dr.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUploadResume_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                UpdateDataBase("Resume", filePath);
                lblResumeStatus.Text = "Submitted";
            }
        }

        private void btnUploadID_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                UpdateDataBase("ID_Card", filePath);
                lblIDStatus.Text = "Submitted";
            }
        }

        private void btnUploadTranscipt_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                UpdateDataBase("Transcript", filePath);
                lblTranscriptStatus.Text = "Submitted";
            }
        }

        private void btnUploadCerts_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                UpdateDataBase("Certificates", filePath);
                lblCertStatus.Text = "Submitted";
            }
        }
        private void UpdateDataBase(string columnName, string value)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = $"UPDATE ApplicantRegister SET [{columnName}] = @Value WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Value", value);
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.ExecuteNonQuery();

                CheckAndUpdateOverallStatus();
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
        private void CheckAndUpdateOverallStatus()
        {
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Resume, ID_Card, Transcript, Certificates FROM ApplicantRegister WHERE Email = @Email";
            cmd.Parameters.AddWithValue("@Email", userEmail);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read()){
                bool allComplete =! string.IsNullOrEmpty(dr["Resume"].ToString()) && !
                                    string.IsNullOrEmpty(dr["ID_Card"].ToString()) && !
                                    string.IsNullOrEmpty(dr["Transcript"].ToString()) && !
                                    string.IsNullOrEmpty(dr["Certificates"].ToString());
                dr.Close();
                string status = allComplete ? "Complete" : "Missing";
                cmd.CommandText = "UPDATE ApplicantRegister SET Doc_Status = @Status WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();
                lblOverallStatus.Text = "Overall Status: " + status;
                lblOverallStatus.ForeColor = allComplete ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
        }

        private void btnSaveRemarks_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE ApplicantRegister SET Remarks = @Remarks HGERE Email = @Email";
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Remarks Saved!");
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMyProfile profile = new frmMyProfile(userEmail);
            profile.Show();
            this.Hide();
        }
    }
}
