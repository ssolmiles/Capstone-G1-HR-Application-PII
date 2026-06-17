using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewSchedule : Form
    {
        private int _appId = -1;

        // Tracks whether the current selection came from the "to schedule" grid.
        private bool _selectedFromToSchedule = false;

        // Prevents the two grids' SelectionChanged events from firing each other
        // in a loop when we call ClearSelection() on the opposite grid.
        private bool _suppressSelectionEvents = false;

        public frmInterviewSchedule()
        {
            InitializeComponent();

            // Grid of screened applicants waiting to be scheduled
            dgvToSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToSchedule.ReadOnly = true;
            dgvToSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvToSchedule.AllowUserToAddRows = false;
            dgvToSchedule.RowHeadersVisible = false;
            dgvToSchedule.SelectionChanged += Dgv_ToSchedule_SelectionChanged;

            // Grid of existing/past schedules
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.ReadOnly = true;
            dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.AllowUserToAddRows = false;
            dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.SelectionChanged += Dgv_Schedules_SelectionChanged;
        }

        private void Dgv_ToSchedule_SelectionChanged(object s, EventArgs e)
        {
            // Guard: ignore if we triggered this by clearing the other grid
            if (_suppressSelectionEvents) return;
            if (dgvToSchedule.SelectedRows.Count == 0) return;

            var row = dgvToSchedule.SelectedRows[0];
            if (row.Cells["AppID"].Value == null) return;

            // Deselect dgvSchedules without triggering its SelectionChanged handler
            _suppressSelectionEvents = true;
            dgvSchedules.ClearSelection();
            _suppressSelectionEvents = false;

            _appId = Convert.ToInt32(row.Cells["AppID"].Value);
            _selectedFromToSchedule = true;

            lblApplicantName.Text = row.Cells["Applicant"].Value?.ToString() ?? "";
            lblJobApplied.Text = row.Cells["Position"].Value?.ToString() ?? "";
            lblSelectedApplicant.Text = "Selected: " + row.Cells["Applicant"].Value;
            lblStatus.Text = "Status: Not Scheduled";
            lblStatus.ForeColor = Color.OrangeRed;

            btnSchedule.Enabled = true;
            btnComplete.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void Dgv_Schedules_SelectionChanged(object s, EventArgs e)
        {
            // Guard: ignore if we triggered this by clearing the other grid
            if (_suppressSelectionEvents) return;
            if (dgvSchedules.SelectedRows.Count == 0) return;

            var row = dgvSchedules.SelectedRows[0];
            if (row.Cells["AppID"].Value == null) return;

            // Deselect dgvToSchedule without triggering its SelectionChanged handler
            _suppressSelectionEvents = true;
            dgvToSchedule.ClearSelection();
            _suppressSelectionEvents = false;

            _appId = Convert.ToInt32(row.Cells["AppID"].Value);
            _selectedFromToSchedule = false;

            lblApplicantName.Text = row.Cells["Applicant"].Value?.ToString() ?? "";
            lblJobApplied.Text = row.Cells["Position"].Value?.ToString() ?? "";
            lblSelectedApplicant.Text = "Selected: " + row.Cells["Applicant"].Value;
            lblStatus.Text = "Status: " + row.Cells["Sched Status"].Value;
            lblStatus.ForeColor = Color.DimGray;

            btnSchedule.Enabled = false;
            btnComplete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void frmInterviewSchedule_Load(object s, EventArgs e)
        {
            // FIX: Start with Complete/Cancel disabled until an existing schedule is selected
            btnComplete.Enabled = false;
            btnCancel.Enabled = false;

            LoadTypes();
            LoadInterviewers();
            LoadToSchedule();
            LoadSchedules();
        }

        private void LoadTypes()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT interview_type_id, label FROM interview_types", conn))
                    using (var dr = cmd.ExecuteReader())
                    {
                        cmbMode.Items.Clear();
                        while (dr.Read())
                            cmbMode.Items.Add(new { Text = dr["label"].ToString(), Value = Convert.ToInt32(dr["interview_type_id"]) });
                    }
                    cmbMode.DisplayMember = "Text";
                    cmbMode.ValueMember = "Value";
                    if (cmbMode.Items.Count > 0) cmbMode.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading interview types: " + ex.Message); }
        }

        private void LoadInterviewers()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "SELECT user_id, full_name FROM users WHERE is_active=1 ORDER BY full_name", conn))
                    using (var dr = cmd.ExecuteReader())
                    {
                        cboInterviewer.Items.Clear();
                        while (dr.Read())
                            cboInterviewer.Items.Add(new
                            {
                                Text = dr["full_name"].ToString(),
                                Value = Convert.ToInt32(dr["user_id"])
                            });
                        cboInterviewer.DisplayMember = "Text";
                        cboInterviewer.ValueMember = "Value";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading interviewers: " + ex.Message); }
        }

        // Applicants who passed screening and don't have an interview scheduled yet
        private void LoadToSchedule()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT a.application_id AS [AppID],
                        ap.full_name AS [Applicant], p.title AS [Position],
                        d.name AS [Department], a.status AS [Status]
                        FROM applications a
                        INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                        INNER JOIN job_vacancies v ON a.vacancy_id = v.vacancy_id
                        INNER JOIN positions p ON v.position_id = p.position_id
                        INNER JOIN departments d ON v.department_id = d.department_id
                        WHERE a.status = 'screened'
                        AND a.application_id NOT IN (SELECT application_id FROM interview_schedules)
                        ORDER BY a.submitted_at";
                    var ada = new SqlDataAdapter(sql, conn);
                    var dt = new DataTable();
                    ada.Fill(dt);
                    dgvToSchedule.DataSource = dt;
                    if (dgvToSchedule.Columns["AppID"] != null)
                        dgvToSchedule.Columns["AppID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading applicants to schedule: " + ex.Message); }
        }

        private void LoadSchedules()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT s.schedule_id AS [SchedID], a.application_id AS [AppID],
                        ap.full_name AS [Applicant], p.title AS [Position],
                        it.label AS [Type], s.scheduled_date AS [Date],
                        s.scheduled_time AS [Time], s.location AS [Location],
                        s.status AS [Sched Status]
                        FROM interview_schedules s
                        INNER JOIN applications a ON s.application_id = a.application_id
                        INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                        INNER JOIN job_vacancies v ON a.vacancy_id = v.vacancy_id
                        INNER JOIN positions p ON v.position_id = p.position_id
                        INNER JOIN interview_types it ON s.interview_type_id = it.interview_type_id
                        ORDER BY s.scheduled_date DESC";
                    var ada = new SqlDataAdapter(sql, conn);
                    var dt = new DataTable();
                    ada.Fill(dt);
                    dgvSchedules.DataSource = dt;
                    if (dgvSchedules.Columns["SchedID"] != null)
                        dgvSchedules.Columns["SchedID"].Visible = false;
                    if (dgvSchedules.Columns["AppID"] != null)
                        dgvSchedules.Columns["AppID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading schedules: " + ex.Message); }
        }

        private void btnSchedule_Click(object s, EventArgs e)
        {
            // FIX 1: Block if no applicant selected at all
            if (_appId == -1)
            {
                MessageBox.Show("Select an applicant from the 'To Schedule' list first.");
                return;
            }

            // FIX 2: Block if the selected applicant came from the already-scheduled grid
            if (!_selectedFromToSchedule)
            {
                MessageBox.Show("This applicant already has an interview scheduled. Use 'Complete Interview' or 'Cancel Interview' to update the existing schedule.");
                return;
            }

            if (cboInterviewer.SelectedItem == null)
            {
                MessageBox.Show("Select an interviewer.");
                return;
            }

            try
            {
                // FIX 3: DB-level duplicate check as a final safety net
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var chk = new SqlCommand(
                        "SELECT COUNT(*) FROM interview_schedules WHERE application_id = @app", conn))
                    {
                        chk.Parameters.AddWithValue("@app", _appId);
                        int existing = (int)chk.ExecuteScalar();
                        if (existing > 0)
                        {
                            MessageBox.Show("A schedule already exists for this applicant. Duplicate scheduling is not allowed.");
                            // Refresh grids so UI matches DB state
                            LoadToSchedule();
                            LoadSchedules();
                            return;
                        }
                    }

                    dynamic selType = (dynamic)cmbMode.SelectedItem;
                    int typeId = selType != null ? selType.Value : 1;

                    dynamic selInt = (dynamic)cboInterviewer.SelectedItem;
                    int iviewerId = selInt != null ? selInt.Value : SessionManager.CurrentUserID;

                    using (var cmd = new SqlCommand(
                        @"INSERT INTO interview_schedules
                          (application_id, interviewer_id, interview_type_id,
                           scheduled_date, scheduled_time, location, status, created_by, created_at)
                          VALUES (@app, @iv, @typ, @dt, @tm, @loc, 'scheduled', @by, GETDATE())", conn))
                    {
                        cmd.Parameters.AddWithValue("@app", _appId);
                        cmd.Parameters.AddWithValue("@iv", iviewerId);
                        cmd.Parameters.AddWithValue("@typ", typeId);
                        cmd.Parameters.AddWithValue("@dt", dtpDate.Value.Date);
                        cmd.Parameters.AddWithValue("@tm", dtpTime.Value.TimeOfDay);
                        cmd.Parameters.AddWithValue("@loc", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", SessionManager.CurrentUserID);
                        cmd.ExecuteNonQuery();
                    }
                }

                StatusHistoryLogger.LogStatusChange(_appId, "screened", "interview_scheduled",
                    SessionManager.CurrentUserID, "Interview scheduled.");

                lblStatus.Text = "Status: Scheduled";
                lblStatus.ForeColor = Color.Blue;

                // FIX 4: Reset state after successful schedule so double-click can't re-fire
                _appId = -1;
                _selectedFromToSchedule = false;
                btnSchedule.Enabled = false;
                btnComplete.Enabled = false;
                btnCancel.Enabled = false;
                lblSelectedApplicant.Text = "Selected: (none)";

                MessageBox.Show("Interview scheduled successfully!");
                LoadToSchedule();
                LoadSchedules();
            }
            catch (Exception ex) { MessageBox.Show("Error scheduling interview: " + ex.Message); }
        }

        private void UpdateSched(string schedStatus, string appStatus)
        {
            if (_appId == -1) { MessageBox.Show("Select a schedule first."); return; }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        "UPDATE interview_schedules SET status=@s WHERE application_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@s", schedStatus);
                        cmd.Parameters.AddWithValue("@id", _appId);
                        cmd.ExecuteNonQuery();
                    }
                }
                StatusHistoryLogger.LogStatusChange(_appId, null, appStatus, SessionManager.CurrentUserID);

                lblStatus.Text = $"Status: {schedStatus}";
                MessageBox.Show($"Marked as {schedStatus}.");

                // FIX: Reset state after update
                _appId = -1;
                _selectedFromToSchedule = false;
                btnSchedule.Enabled = false;
                btnComplete.Enabled = false;
                btnCancel.Enabled = false;
                lblSelectedApplicant.Text = "Selected: (none)";

                LoadToSchedule();
                LoadSchedules();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnComplete_Click(object s, EventArgs e) => UpdateSched("completed", "interviewed");
        private void btnCancel_Click(object s, EventArgs e) => UpdateSched("cancelled", "screened");
        private void btnNext_Click(object s, EventArgs e) { new frmInterviewEvaluation().Show(); this.Hide(); }
        private void btnBack_Click(object s, EventArgs e) { new frmScreening().Show(); this.Close(); }

        private void groupBox3_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        private void dgvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvToSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}