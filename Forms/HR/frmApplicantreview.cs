using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmApplicantReview : Form
    {
        public frmApplicantReview()
        {
            InitializeComponent();

            btnSearch.Click += btnSearch_Click;
            btnClear.Click += btnClear_Click;
            btnViewProfile.Click += btnViewProfile_Click;
            btnViewDocuments.Click += btnViewDocuments_Click;
            btnLockReview.Click += btnLockReview_Click;
            btnNext.Click += btnNext_Click;
        }

        private void frmApplicantReview_Load(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void LoadData(string searchTerm)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            a.application_id   AS ApplicationID,
                            ap.full_name        AS Applicant,
                            p.title             AS [Position],
                            d.name              AS Department,
                            a.status            AS Status,
                            a.submitted_at      AS Submitted
                        FROM applications a
                        INNER JOIN applicants ap     ON ap.applicant_id = a.applicant_id
                        INNER JOIN job_vacancies jv  ON jv.vacancy_id = a.vacancy_id
                        INNER JOIN positions p       ON p.position_id = jv.position_id
                        LEFT JOIN departments d      ON d.department_id = jv.department_id
                        WHERE (@search IS NULL
                               OR ap.full_name LIKE '%' + @search + '%'
                               OR p.title LIKE '%' + @search + '%')
                        ORDER BY a.last_updated DESC";

                    var adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@search",
                        string.IsNullOrWhiteSpace(searchTerm) ? (object)DBNull.Value : searchTerm.Trim());

                    var table = new DataTable();
                    adapter.Fill(table);

                    dgvApplicants.DataSource = table;
                    dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    if (dgvApplicants.Columns.Contains("ApplicationID"))
                        dgvApplicants.Columns["ApplicationID"].Visible = false;

                    lblCount.Text = $"{table.Rows.Count} applicant(s)";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadData(null);
        }

        private bool TryGetSelectedApplicationId(out int applicationId)
        {
            applicationId = 0;
            if (dgvApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant first.");
                return false;
            }

            applicationId = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["ApplicationID"].Value);
            return true;
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedApplicationId(out int applicationId)) return;
            MessageBox.Show($"Viewing profile for application #{applicationId}.");
            // TODO: open applicant profile view (frmMyProfile read-only) for this applicant
        }

        private void btnViewDocuments_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedApplicationId(out int applicationId)) return;
            MessageBox.Show($"Viewing documents for application #{applicationId}.");
            // TODO: open document viewer for this applicant
        }

        private void btnLockReview_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedApplicationId(out int applicationId)) return;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "UPDATE applications SET status = 'under_review', last_updated = @now WHERE application_id = @id AND status = 'submitted'", conn))
                    {
                        cmd.Parameters.AddWithValue("@now", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", applicationId);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            StatusHistoryLoggerSafe(applicationId, "submitted", "under_review", "Locked for review by HR");
                            MessageBox.Show("Application locked for review.");
                            LoadData(txtSearch.Text);
                        }
                        else
                        {
                            MessageBox.Show("This application is not in 'submitted' status, or is already locked.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error locking application: " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!TryGetSelectedApplicationId(out int applicationId)) return;

            frmScreening screeningForm = new frmScreening(applicationId);
            screeningForm.Show();
            this.Hide();
        }

        private void StatusHistoryLoggerSafe(int applicationId, string oldStatus, string newStatus, string remarks)
        {
            try
            {
                int userId = SessionManager.CurrentUser?.UserID ?? 0;
                StatusHistoryLogger.LogStatusChange(applicationId, oldStatus, newStatus, userId, remarks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning: status history could not be recorded: " + ex.Message);
            }
        }
    }
}