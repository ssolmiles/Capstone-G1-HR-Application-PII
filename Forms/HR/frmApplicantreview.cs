using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmApplicantReview : Form
    {
        public frmApplicantReview()
        {
            InitializeComponent();
            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.ReadOnly = true; dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.AllowUserToAddRows = false; dgvApplications.RowHeadersVisible = false;
        }

        // FIX: Renamed to match Designer wire-up (was frmHRApplicantReview_Load)
        private void frmApplicantReview_Load(object s, EventArgs e) => Load2();

        private void Load2(string q = "")
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT a.application_id AS [AppID],
                        ap.applicant_id AS [ApplicantID],
                        ap.full_name AS [Applicant], ap.email AS [Email],
                        p.title AS [Position], d.name AS [Department],
                        a.status AS [Status], a.submitted_at AS [Submitted]
                        FROM applications a
                        INNER JOIN applicants ap ON a.applicant_id=ap.applicant_id
                        INNER JOIN job_vacancies v ON a.vacancy_id=v.vacancy_id
                        INNER JOIN positions p ON v.position_id=p.position_id
                        INNER JOIN departments d ON v.department_id=d.department_id
                        WHERE a.status IN ('submitted','under_review')";
                    if (!string.IsNullOrEmpty(q))
                        sql += " AND (ap.full_name LIKE @q OR p.title LIKE @q)";
                    sql += " ORDER BY a.submitted_at DESC";
                    var ada = new SqlDataAdapter(sql, conn);
                    if (!string.IsNullOrEmpty(q))
                        ada.SelectCommand.Parameters.AddWithValue("@q", "%" + q + "%");
                    var dt = new DataTable(); ada.Fill(dt);
                    dgvApplications.DataSource = dt;
                    if (dgvApplications.Columns["AppID"] != null) dgvApplications.Columns["AppID"].Visible = false;
                    if (dgvApplications.Columns["ApplicantID"] != null) dgvApplications.Columns["ApplicantID"].Visible = false;
                    lblCount.Text = $"{dt.Rows.Count} application(s)";
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private int AppId()
        {
            if (dgvApplications.SelectedRows.Count == 0) return -1;
            return Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["AppID"].Value);
        }
        private int AplId()
        {
            if (dgvApplications.SelectedRows.Count == 0) return -1;
            return Convert.ToInt32(dgvApplications.SelectedRows[0].Cells["ApplicantID"].Value);
        }
        private string AplEmail()
        {
            if (dgvApplications.SelectedRows.Count == 0) return null;
            return dgvApplications.SelectedRows[0].Cells["Email"].Value?.ToString();
        }

        // FIX: Added stub to match Designer wire-up on dgvApplications.CellContentClick
        private void dgvApplicants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Row selection is handled via SelectedRows; no additional action needed here.
        }

        private void btnSearch_Click(object s, EventArgs e) => Load2(txtSearch.Text.Trim());

        private void btnViewProfile_Click(object s, EventArgs e)
        {
            var e2 = AplEmail(); if (e2 == null) { MessageBox.Show("Select first."); return; }
            new frmHRApplicantProfile(e2).ShowDialog();
        }

        private void btnViewDocuments_Click(object s, EventArgs e)
        {
            int id = AplId(); if (id == -1) { MessageBox.Show("Select first."); return; }
            new frmHRViewDocuments(id).ShowDialog();
        }

        private void btnLockReview_Click(object s, EventArgs e)
        {
            int id = AppId();
            if (id == -1) { MessageBox.Show("Select first."); return; }
            try
            {
                StatusHistoryLogger.LogStatusChange(id, "submitted", "under_review",
                    SessionManager.CurrentUserID, "Locked for review.");
                MessageBox.Show("Application locked for review."); Load2();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNext_Click(object s, EventArgs e)
        {
            int appId = AppId();

            if (appId == -1)
            {
                MessageBox.Show("Select a scheduled interview first.");
                return;
            }

            new frmScreening(appId).Show();
            this.Hide();
        }

        private void btnBack_Click(object s, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmHRDashboard)
                {
                    f.Show();
                    f.BringToFront();
                    break;
                }
            }

            this.Close();
        }
    }
}