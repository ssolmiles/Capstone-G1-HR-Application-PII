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
            => LoadDocumentStatus();

        private void LoadDocumentStatus()
        {
            // Reset all to Missing first
            lblResumeStatus.Text = "Missing";
            lblIDStatus.Text = "Missing";
            lblTranscriptStatus.Text = "Missing";
            lblCertStatus.Text = "Missing";
            lblResumeStatus.ForeColor = Color.Red;
            lblIDStatus.ForeColor = Color.Red;
            lblTranscriptStatus.ForeColor = Color.Red;
            lblCertStatus.ForeColor = Color.Red;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    int applicantId = GetApplicantId(conn);
                    if (applicantId == -1)
                    { MessageBox.Show("Applicant not found."); return; }

                    bool hasResume = false, hasID = false,
                         hasTranscript = false, hasCert = false;

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT rt.label, ad.file_path, ad.status
                          FROM applicant_documents ad
                          INNER JOIN requirement_types rt
                              ON ad.req_type_id = rt.req_type_id
                          WHERE ad.applicant_id = @ApplicantId", conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                string label = dr["label"].ToString().ToLower();
                                string status = dr["status"].ToString();
                                bool submitted = status == "submitted"
                                    && !string.IsNullOrEmpty(
                                        dr["file_path"].ToString());

                                if (label.Contains("resume"))
                                {
                                    lblResumeStatus.Text = submitted
                                        ? "Submitted" : "Missing";
                                    lblResumeStatus.ForeColor = submitted
                                        ? Color.Green : Color.Red;
                                    hasResume = submitted;
                                }
                                // FIX: 'Valid ID' does not match 'id' alone
                                // so match on 'id' OR 'valid'
                                else if (label.Contains(" id") || label == "valid id"
                                    || label.Contains("valid id"))
                                {
                                    lblIDStatus.Text = submitted
                                        ? "Submitted" : "Missing";
                                    lblIDStatus.ForeColor = submitted
                                        ? Color.Green : Color.Red;
                                    hasID = submitted;
                                }
                                else if (label.Contains("transcript"))
                                {
                                    lblTranscriptStatus.Text = submitted
                                        ? "Submitted" : "Missing";
                                    lblTranscriptStatus.ForeColor = submitted
                                        ? Color.Green : Color.Red;
                                    hasTranscript = submitted;
                                }
                                else if (label.Contains("cert"))
                                {
                                    lblCertStatus.Text = submitted
                                        ? "Submitted" : "Missing";
                                    lblCertStatus.ForeColor = submitted
                                        ? Color.Green : Color.Red;
                                    hasCert = submitted;
                                }
                            }
                        }
                    }

                    bool allComplete = hasResume && hasID && hasTranscript && hasCert;
                    lblOverallStatus.Text = "Overall Status: "
                        + (allComplete ? "Complete" : "Incomplete");
                    lblOverallStatus.ForeColor = allComplete
                        ? Color.Green : Color.Red;

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT TOP 1 sr.remarks
                          FROM screening_results sr
                          INNER JOIN applications a
                              ON sr.application_id = a.application_id
                          WHERE a.applicant_id = @ApplicantId
                          ORDER BY sr.reviewed_at DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        object result = cmd.ExecuteScalar();
                        txtRemarks.Text = (result != null && result != DBNull.Value)
                            ? result.ToString() : "";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
        }

        private int GetApplicantId(SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand(
                "SELECT applicant_id FROM applicants WHERE email = @Email",
                conn))
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
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    int applicantId = GetApplicantId(conn);
                    if (applicantId == -1) return;

                    // FIX: Check the req_type_id exists first
                    int reqTypeId = -1;
                    using (var rtCmd = new SqlCommand(
                        "SELECT TOP 1 req_type_id FROM requirement_types"
                        + " WHERE label LIKE @kw", conn))
                    {
                        rtCmd.Parameters.AddWithValue("@kw",
                            "%" + docTypeKeyword + "%");
                        object r = rtCmd.ExecuteScalar();
                        if (r == null || r == DBNull.Value)
                        {
                            MessageBox.Show(
                                $"Requirement type '{docTypeKeyword}' not found.\n"
                                + "Ask your admin to seed the requirement_types table.");
                            return;
                        }
                        reqTypeId = Convert.ToInt32(r);
                    }

                    // Check if record already exists
                    bool exists = false;
                    using (var check = new SqlCommand(
                        "SELECT COUNT(1) FROM applicant_documents"
                        + " WHERE applicant_id=@aid AND req_type_id=@rtid",
                        conn))
                    {
                        check.Parameters.AddWithValue("@aid", applicantId);
                        check.Parameters.AddWithValue("@rtid", reqTypeId);
                        exists = Convert.ToInt32(check.ExecuteScalar()) > 0;
                    }

                    if (exists)
                    {
                        using (var cmd = new SqlCommand(
                            @"UPDATE applicant_documents
                              SET file_path=@fp, status='submitted',
                                  uploaded_at=GETDATE()
                              WHERE applicant_id=@aid
                                AND req_type_id=@rtid", conn))
                        {
                            cmd.Parameters.AddWithValue("@fp", filePath);
                            cmd.Parameters.AddWithValue("@aid", applicantId);
                            cmd.Parameters.AddWithValue("@rtid", reqTypeId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        using (var cmd = new SqlCommand(
                            @"INSERT INTO applicant_documents
                              (applicant_id, req_type_id, file_path,
                               status, uploaded_at)
                              VALUES (@aid, @rtid, @fp, 'submitted', GETDATE())",
                            conn))
                        {
                            cmd.Parameters.AddWithValue("@aid", applicantId);
                            cmd.Parameters.AddWithValue("@rtid", reqTypeId);
                            cmd.Parameters.AddWithValue("@fp", filePath);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                statusLabel.Text = "Submitted";
                statusLabel.ForeColor = Color.Green;
                MessageBox.Show("Document uploaded successfully!");
                LoadDocumentStatus(); // Refresh all statuses
            }
            catch (Exception ex)
            { MessageBox.Show("Upload error: " + ex.Message); }
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
        private void button1_Click(object sender, EventArgs e) { }
    }
}
