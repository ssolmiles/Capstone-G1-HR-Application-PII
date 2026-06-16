using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewEvaluation : Form
    {
        private int _appId;
        private int _schedId = -1;   // FIX: added missing field

        public frmInterviewEvaluation()
        {
            InitializeComponent();

            dgvInterviewed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInterviewed.ReadOnly = true;
            dgvInterviewed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInterviewed.AllowUserToAddRows = false;
            dgvInterviewed.RowHeadersVisible = false;

            dgvInterviewed.SelectionChanged += (s, e) =>
            {
                if (dgvInterviewed.SelectedRows.Count > 0)
                {
                    var row = dgvInterviewed.SelectedRows[0];
                    if (row.Cells["SchedID"].Value == null || row.Cells["AppID"].Value == null) return;

                    _schedId = Convert.ToInt32(row.Cells["SchedID"].Value);
                    _appId = Convert.ToInt32(row.Cells["AppID"].Value);

                    lblApplicantName.Text = row.Cells["Applicant"].Value?.ToString() ?? "";
                    lblJobApplied.Text = row.Cells["Position"].Value?.ToString() ?? "";
                }
            };
        }

        public frmInterviewEvaluation(int appId) : this()
        {
            _appId = appId;
        }
        // FIX: removed stray "}" that prematurely closed the class here

        private void frmInterviewEvaluation_Load(object s, EventArgs e) => LoadData();

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT s.schedule_id AS [SchedID], a.application_id AS [AppID],
                                    ap.full_name AS [Applicant], p.title AS [Position],
                                    it.label AS [Interview Type], s.scheduled_date AS [Date]
                                    FROM interview_schedules s
                                    INNER JOIN applications a ON s.application_id=a.application_id
                                    INNER JOIN applicants ap ON a.applicant_id=ap.applicant_id
                                    INNER JOIN job_vacancies v ON a.vacancy_id=v.vacancy_id
                                    INNER JOIN positions p ON v.position_id=p.position_id
                                    INNER JOIN interview_types it ON s.interview_type_id=it.interview_type_id
                                    WHERE s.status='completed'
                                    AND s.interviewer_id = @userId
                                    ORDER BY s.scheduled_date DESC";

                    var ada = new SqlDataAdapter(sql, conn);

                    // THIS LINE IS REQUIRED
                    ada.SelectCommand.Parameters.AddWithValue(
                        "@userId",
                        SessionManager.CurrentUserID);

                    var dt = new DataTable();
                    ada.Fill(dt);
                    dgvInterviewed.DataSource = dt;
                    if (dgvInterviewed.Columns["SchedID"] != null) dgvInterviewed.Columns["SchedID"].Visible = false;
                    if (dgvInterviewed.Columns["AppID"] != null) dgvInterviewed.Columns["AppID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Save()
        {
            if (_schedId == -1)
            {
                MessageBox.Show("Select a completed interview.");
                return;
            }

            if (!decimal.TryParse(txtScore.Text.Trim(), out decimal score))
            {
                MessageBox.Show("Enter a valid score.");
                return;
            }

            
            string result = score >= 75 ? "pass" : "fail";

           

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(
                        @"INSERT INTO interview_evaluations
                  (schedule_id,application_id,score,remarks,result,recommendation,evaluated_by,evaluated_at)
                  VALUES(@sid,@aid,@sc,@rm,@rs,@rec,@by,GETDATE())", conn))
                    {
                        cmd.Parameters.AddWithValue("@sid", _schedId);
                        cmd.Parameters.AddWithValue("@aid", _appId);
                        cmd.Parameters.AddWithValue("@sc", score);
                        cmd.Parameters.AddWithValue("@rm", txtRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@rs", result);
                        cmd.Parameters.AddWithValue("@rec", txtRecommendation.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", SessionManager.CurrentUserID);

                        cmd.ExecuteNonQuery();
                    }
                }

                string next = result == "pass" ? "screened" : "rejected";

                StatusHistoryLogger.LogStatusChange(
                    _appId,
                    "interviewed",
                    next,
                    SessionManager.CurrentUserID,
                    $"Evaluation: {result}, score {score}.");

                lblResult.Text = $"Result: {result.ToUpper()}";
                lblResult.ForeColor = result == "pass"
                    ? Color.Green
                    : Color.Red;

                MessageBox.Show($"Applicant {result.ToUpper()}");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnPass_Click(object s, EventArgs e) => Save();
        private void btnFail_Click(object s, EventArgs e) => Save();
        private void btnNext_Click(object s, EventArgs e) { new frmHiringDecision().Show(); this.Hide(); }

        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void btnBack_Click(object s, EventArgs e) { new frmInterviewSchedule().Show(); this.Close(); }

        private void txtRemarks_TextChanged(object sender, EventArgs e) { }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}