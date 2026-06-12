using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmMyDocuments : Form
    {
        private string userEmail;

        public frmMyDocuments(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmMyDocuments_Load_1(object sender, EventArgs e)
        {
            LoadDocumentStatus();
        }

        private void LoadDocumentStatus()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    int applicantId = GetApplicantId(conn);
                    if (applicantId == -1)
                    {
                        MessageBox.Show("Applicant not found.");
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT rt.label, ad.file_path, ad.status
                          FROM applicant_documents ad
                          INNER JOIN requirement_types rt ON ad.req_type_id = rt.req_type_id
                          WHERE ad.applicant_id = @ApplicantId", conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);

                        bool hasResume = false, hasID = false, hasTranscript = false, hasCert = false;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string label = dr["label"].ToString().ToLower();
                                string status = dr["status"].ToString();
                                bool submitted = status == "submitted" && !string.IsNullOrEmpty(dr["file_path"].ToString());

                                if (label.Contains("resume")) { lblResumeStatus.Text = submitted ? "Submitted" : "Missing"; hasResume = submitted; }
                                else if (label.Contains("id")) { lblIDStatus.Text = submitted ? "Submitted" : "Missing"; hasID = submitted; }
                                else if (label.Contains("transcript")) { lblTranscriptStatus.Text = submitted ? "Submitted" : "Missing"; hasTranscript = submitted; }
                                else if (label.Contains("cert")) { lblCertStatus.Text = submitted ? "Submitted" : "Missing"; hasCert = submitted; }
                            }
                        }

                        bool allComplete = hasResume && hasID && hasTranscript && hasCert;
                        lblOverallStatus.Text = "Overall Status: " + (allComplete ? "Complete" : "Incomplete");
                        lblOverallStatus.ForeColor = allComplete ? Color.Green : Color.Red;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT TOP 1 sr.remarks 
                          FROM screening_results sr
                          INNER JOIN applications a ON sr.application_id = a.application_id
                          WHERE a.applicant_id = @ApplicantId
                          ORDER BY sr.reviewed_at DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        object result = cmd.ExecuteScalar();
                        txtRemarks.Text = result != null && result != DBNull.Value ? result.ToString() : "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetApplicantId(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT applicant_id FROM applicants WHERE email = @Email", conn))
            {
                cmd.Parameters.AddWithValue("@Email", userEmail);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }

        private void UploadDocument(string docTypeKeyword, Label statusLabel)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            string filePath = openFileDialog1.FileName;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    int applicantId = GetApplicantId(conn);
                    if (applicantId == -1) return;

                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE applicant_documents 
                          SET file_path = @FilePath, status = 'submitted', uploaded_at = GETDATE()
                          WHERE applicant_id = @ApplicantId
                            AND req_type_id = (
                              SELECT TOP 1 req_type_id FROM requirement_types 
                              WHERE label LIKE @Keyword)", conn))
                    {
                        cmd.Parameters.AddWithValue("@FilePath", filePath);
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        cmd.Parameters.AddWithValue("@Keyword", "%" + docTypeKeyword + "%");
                        cmd.ExecuteNonQuery();
                    }
                }

                statusLabel.Text = "Submitted";
                statusLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving: " + ex.Message);
            }
        }

        private void btnUploadResume_Click(object sender, EventArgs e)
            => UploadDocument("resume", lblResumeStatus);

        private void btnUploadID_Click(object sender, EventArgs e)
            => UploadDocument("id", lblIDStatus);

        private void btnUploadTranscipt_Click(object sender, EventArgs e)
            => UploadDocument("transcript", lblTranscriptStatus);

        private void btnUploadCerts_Click(object sender, EventArgs e)
            => UploadDocument("cert", lblCertStatus);

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMyProfile profile = new frmMyProfile(userEmail);
            profile.Show();
            this.Hide();
        }

        private void lblIDStatus_Click(object sender, EventArgs e) { }
    }
}