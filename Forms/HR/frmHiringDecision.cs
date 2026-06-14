using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHiringDecision : Form
    {
        private int _appId = -1;

        public frmHiringDecision()
        {
            InitializeComponent();
            dgvPassed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPassed.ReadOnly = true; dgvPassed.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPassed.AllowUserToAddRows = false; dgvPassed.RowHeadersVisible = false;
            dgvPassed.SelectionChanged += (s, e) =>
            {
                if (dgvPassed.SelectedRows.Count > 0)
                {
                    _appId = Convert.ToInt32(dgvPassed.SelectedRows[0].Cells["AppID"].Value);
                    lblDecision.Text = "Selected: " + dgvPassed.SelectedRows[0].Cells["Applicant"].Value;
                }
            };
        }

        private void frmHiringDecision_Load(object s, EventArgs e)
        {
            if (SessionManager.CurrentRole != "admin" && SessionManager.CurrentRole != "hr_manager")
            { MessageBox.Show("Access denied. Admin or HR Manager only."); this.Close(); return; }
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT a.application_id AS [AppID],
                    ap.full_name AS [Applicant], ap.email AS [Email],
                    p.title AS [Position], d.name AS [Department],
                    ie.score AS [Score], ie.recommendation AS [Recommendation]
                    FROM applications a
                    INNER JOIN applicants ap ON a.applicant_id=ap.applicant_id
                    INNER JOIN job_vacancies v ON a.vacancy_id=v.vacancy_id
                    INNER JOIN positions p ON v.position_id=p.position_id
                    INNER JOIN departments d ON v.department_id=d.department_id
                    INNER JOIN interview_evaluations ie ON ie.application_id=a.application_id
                    WHERE a.status='screened' AND ie.result='pass'";
                    var ada = new SqlDataAdapter(sql, conn); var dt = new DataTable(); ada.Fill(dt);
                    dgvPassed.DataSource = dt;
                    if (dgvPassed.Columns["AppID"] != null) dgvPassed.Columns["AppID"].Visible = false;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void Decide(string decision)
        {
            if (_appId == -1) { MessageBox.Show("Select an applicant first."); return; }
            if (MessageBox.Show($"Mark as {decision.ToUpper()}?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"IF EXISTS(SELECT 1 FROM hiring_decisions WHERE application_id=@id)
                              UPDATE hiring_decisions SET final_decision=@d,remarks=@rm,
                              decided_by=@by,decided_at=GETDATE() WHERE application_id=@id
                          ELSE
                              INSERT INTO hiring_decisions(application_id,final_decision,remarks,decided_by,decided_at)
                              VALUES(@id,@d,@rm,@by,GETDATE())", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", _appId);
                        cmd.Parameters.AddWithValue("@d", decision);
                        cmd.Parameters.AddWithValue("@rm", txtFinalRemarks.Text.Trim());
                        cmd.Parameters.AddWithValue("@by", SessionManager.CurrentUserID);
                        cmd.ExecuteNonQuery();
                    }
                }
                StatusHistoryLogger.LogStatusChange(_appId, "screened", decision,
                    SessionManager.CurrentUserID, $"Final: {decision}.");
                lblDecision.Text = $"Decision: {decision.ToUpper()}";
                lblDecision.ForeColor = decision == "accepted" ? Color.Green : Color.Red;
                lblStatus.Text = "Status: " + decision;
                MessageBox.Show($"Decision saved: {decision.ToUpper()}"); LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnHire_Click(object s, EventArgs e) => Decide("accepted");
        private void btnReject_Click(object s, EventArgs e) => Decide("rejected");
        private void btnBack_Click(object s, EventArgs e) { new frmInterviewEvaluation().Show(); this.Close(); }

        // FIX: Added stub to match Designer wire-up on txtFinalRemarks.TextChanged
        private void txtFinalRemarks_TextChanged(object sender, EventArgs e)
        {
            // No action needed; txtFinalRemarks.Text is read at decision time.
        }
    }
}