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
        public frmInterviewSchedule()
        {
            InitializeComponent();
            dgvSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSchedules.ReadOnly = true; dgvSchedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedules.AllowUserToAddRows = false; dgvSchedules.RowHeadersVisible = false;
            dgvSchedules.SelectionChanged += (s, e) => {
                if (dgvSchedules.SelectedRows.Count > 0)
                    _appId = Convert.ToInt32(dgvSchedules.SelectedRows[0].Cells["AppID"].Value);
            };
        }

        private void frmInterviewSchedule_Load(object s, EventArgs e) { LoadTypes(); LoadSchedules(); }

        private void LoadTypes()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT interview_type_id,label FROM interview_types", conn))
                    using (var dr = cmd.ExecuteReader())
                    {
                        cmbMode.Items.Clear();
                        while (dr.Read()) cmbMode.Items.Add(new { Text = dr["label"].ToString(), Value = Convert.ToInt32(dr["interview_type_id"]) });
                    }
                    cmbMode.DisplayMember = "Text"; cmbMode.ValueMember = "Value";
                    if (cmbMode.Items.Count > 0) cmbMode.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
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
                    INNER JOIN applications a ON s.application_id=a.application_id
                    INNER JOIN applicants ap ON a.applicant_id=ap.applicant_id
                    INNER JOIN job_vacancies v ON a.vacancy_id=v.vacancy_id
                    INNER JOIN positions p ON v.position_id=p.position_id
                    INNER JOIN interview_types it ON s.interview_type_id=it.interview_type_id
                    ORDER BY s.scheduled_date DESC";
                    var ada = new SqlDataAdapter(sql, conn); var dt = new DataTable(); ada.Fill(dt);
                    dgvSchedules.DataSource = dt;
                    if (dgvSchedules.Columns["SchedID"] != null) dgvSchedules.Columns["SchedID"].Visible = false;
                    if (dgvSchedules.Columns["AppID"] != null) dgvSchedules.Columns["AppID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSchedule_Click(object s, EventArgs e)
        {
            if (_appId == -1) { MessageBox.Show("Select an application first."); return; }
            if (string.IsNullOrWhiteSpace(txtInterviewer.Text)) { MessageBox.Show("Enter interviewer name."); return; }
            try
            {
                dynamic sel = (dynamic)cmbMode.SelectedItem;
                int typeId = sel != null ? sel.Value : 1;
                int iviewerId = SessionManager.CurrentUserID;
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var find = new SqlCommand("SELECT TOP 1 user_id FROM users WHERE full_name LIKE @n", conn))
                    {
                        find.Parameters.AddWithValue("@n", $"%{txtInterviewer.Text.Trim()}%");
                        object r = find.ExecuteScalar(); if (r != null) iviewerId = Convert.ToInt32(r);
                    }
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO interview_schedules
                          (application_id,interviewer_id,interview_type_id,
                           scheduled_date,scheduled_time,location,status,created_by,created_at)
                          VALUES(@app,@iv,@typ,@dt,@tm,@loc,'scheduled',@by,GETDATE())", conn))
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
                lblStatus.Text = "Status: Scheduled"; lblStatus.ForeColor = Color.Blue;
                MessageBox.Show("Interview scheduled!"); LoadSchedules();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void UpdateSched(string ss, string appS)
        {
            if (_appId == -1) { MessageBox.Show("Select first."); return; }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("UPDATE interview_schedules SET status=@s WHERE application_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@s", ss); cmd.Parameters.AddWithValue("@id", _appId); cmd.ExecuteNonQuery();
                    }
                }
                StatusHistoryLogger.LogStatusChange(_appId, null, appS, SessionManager.CurrentUserID);
                lblStatus.Text = $"Status: {ss}"; MessageBox.Show($"Marked {ss}."); LoadSchedules();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }
        private void btnComplete_Click(object s, EventArgs e) => UpdateSched("completed", "interviewed");
        private void btnCancel_Click(object s, EventArgs e) => UpdateSched("cancelled", "screened");
        private void btnNext_Click(object s, EventArgs e) { new frmInterviewEvaluation().Show(); this.Hide(); }
        private void btnBack_Click(object s, EventArgs e) { new frmScreening().Show(); this.Close(); }
    }
}
