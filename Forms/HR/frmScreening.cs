using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        private int _appId = -1, _aplId = -1;

        // ✅ DEFAULT CONSTRUCTOR (Designer-safe)
        public frmScreening()
        {
            InitializeComponent();
            SetupGrid();
        }

        // ✅ NEW CONSTRUCTOR (FROM PREVIOUS FORM)
        public frmScreening(int appId) : this()
        {
            _appId = appId;
        }

        // 🔧 Grid setup extracted to avoid duplication
        private void SetupGrid()
        {
            dgvApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvApplications.ReadOnly = true;
            dgvApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplications.AllowUserToAddRows = false;
            dgvApplications.RowHeadersVisible = false;
            dgvApplications.SelectionChanged += Dgv_SelectionChanged;
        }

        private void frmScreening_Load(object s, EventArgs e)
        {
            LoadData();

            // 🔎 Auto-select passed application
            if (_appId != -1)
            {
                foreach (DataGridViewRow row in dgvApplications.Rows)
                {
                    if (Convert.ToInt32(row.Cells["AppID"].Value) == _appId)
                    {
                        row.Selected = true;
                        dgvApplications.CurrentCell = row.Cells[2];
                        break;
                    }
                }
            }
        }

        private void Dgv_SelectionChanged(object s, EventArgs e)
        {
            if (dgvApplications.SelectedRows.Count > 0)
            {
                var row = dgvApplications.SelectedRows[0];
                _appId = Convert.ToInt32(row.Cells["AppID"].Value);
                _aplId = Convert.ToInt32(row.Cells["ApplicantID"].Value);

                lblApplicantName.Text = row.Cells["Applicant"].Value?.ToString() ?? "";
                lblJobApplied.Text = row.Cells["Position"].Value?.ToString() ?? "";
                lblSelectedApplicant.Text = "Selected: " + row.Cells["Applicant"].Value;

                lblStatus.Text = "Status: " + row.Cells["Status"].Value;
                lblStatus.ForeColor = Color.Gray;
            }
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT a.application_id AS [AppID],
                        ap.applicant_id AS [ApplicantID], ap.full_name AS [Applicant],
                        p.title AS [Position], d.name AS [Department],
                        a.status AS [Status], a.submitted_at AS [Submitted]
                        FROM applications a
                        INNER JOIN applicants ap ON a.applicant_id=ap.applicant_id
                        INNER JOIN job_vacancies v ON a.vacancy_id=v.vacancy_id
                        INNER JOIN positions p ON v.position_id=p.position_id
                        INNER JOIN departments d ON v.department_id=d.department_id
                        WHERE a.status='under_review'
                        ORDER BY a.submitted_at";

                    var ada = new SqlDataAdapter(sql, conn);
                    var dt = new DataTable();
                    ada.Fill(dt);
                    dgvApplications.DataSource = dt;

                    if (dgvApplications.Columns["AppID"] != null)
                        dgvApplications.Columns["AppID"].Visible = false;
                    if (dgvApplications.Columns["ApplicantID"] != null)
                        dgvApplications.Columns["ApplicantID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SaveResult(string result)
        {
            if (_appId == -1)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"IF EXISTS(SELECT 1 FROM screening_results WHERE application_id=@id)
                              UPDATE screening_results
                              SET result=@r, remarks=@rm,
                                  reviewed_by=@by, reviewed_at=GETDATE()
                              WHERE application_id=@id
                          ELSE
                              INSERT INTO screening_results
                              (application_id, reviewed_by, result, remarks, reviewed_at)
                              VALUES(@id, @by, @r, @rm, GETDATE())", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _appId);
                        cmd.Parameters.AddWithValue("@by", SessionManager.CurrentUserID);
                        cmd.Parameters.AddWithValue("@r", result);
                        cmd.Parameters.AddWithValue("@rm", txtRemarks.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                string next = result == "qualified" ? "screened" : "rejected";
                StatusHistoryLogger.LogStatusChange(
                    _appId, "under_review", next,
                    SessionManager.CurrentUserID,
                    $"Screening: {result}.");

                lblStatus.Text = "Status: " + next;
                lblStatus.ForeColor = result == "qualified" ? Color.Green : Color.Red;

                MessageBox.Show($"Marked as {result.ToUpper()}.");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnQualified_Click(object s, EventArgs e) => SaveResult("qualified");
        private void btnNotQualified_Click(object s, EventArgs e) => SaveResult("not_qualified");

        private void btnViewDocuments_Click(object s, EventArgs e)
        {
            if (_aplId == -1)
            {
                MessageBox.Show("Select first.");
                return;
            }
            new frmHRViewDocuments(_aplId).ShowDialog();
        }

        private void btnNext_Click(object s, EventArgs e)
        {
            var next = new frmInterviewSchedule();
            next.AppId = _appId;
            next.Show();
            this.Hide();
        }

        private void btnBack_Click(object s, EventArgs e)
        {
            new frmApplicantReview().Show();
            this.Close();
        }

        private void txtRemarks_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // ✔ Designer-safe stub
        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}