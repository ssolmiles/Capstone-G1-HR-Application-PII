using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();

            btnApplicants.Click += btnApplicants_Click;
            btnPending.Click += btnPending_Click;
            btnInterviews.Click += btnInterviews_Click;
            btnAccepted.Click += btnAccepted_Click;
            btnRejected.Click += btnRejected_Click;
            btnMissing.Click += btnMissing_Click;
        }


        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadApplicants(); // default view
        }

        // ================= DASHBOARD STATS (CARDS) =================
        private void LoadDashboardStats()
        {
            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                lblTotalApplicants.Text = GetCount(conn, "SELECT COUNT(*) FROM applicants").ToString();

                lblPending.Text = GetCount(conn, @"
                    SELECT COUNT(*) FROM applications
                    WHERE status IN ('draft','submitted','under_review')
                ").ToString();

                lblInterviewed.Text = GetCount(conn, "SELECT COUNT(*) FROM interview_schedules").ToString();

                lblAccepted.Text = GetCount(conn, @"
                    SELECT COUNT(*) FROM hiring_decisions
                    WHERE final_decision = 'accepted'
                ").ToString();

                lblRejected.Text = GetCount(conn, @"
                    SELECT COUNT(*) FROM hiring_decisions
                    WHERE final_decision = 'rejected'
                ").ToString();
            }
        }

        private int GetCount(SqlConnection conn, string sql)
        {
            using (var cmd = new SqlCommand(sql, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // ================= LOAD GRID =================
        private void LoadReport(string sql)
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (var cmd = new SqlCommand(sql, conn))
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvReports.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= REPORTS =================

        private void LoadApplicants()
        {
            LoadReport(@"
                SELECT applicant_id, full_name, email, phone, city, created_at
                FROM applicants
                ORDER BY created_at DESC
            ");
        }

        private void LoadPending()
        {
            LoadReport(@"
                SELECT a.application_id, ap.full_name, a.status, a.submitted_at
                FROM applications a
                INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
                WHERE a.status IN ('draft','submitted','under_review')
            ");
        }

        private void LoadInterviews()
        {
            LoadReport(@"
                SELECT ap.full_name, s.scheduled_date, s.scheduled_time, s.status
                FROM interview_schedules s
                INNER JOIN applications a ON a.application_id = s.application_id
                INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
                ORDER BY s.scheduled_date DESC
            ");
        }

        private void LoadAccepted()
        {
            LoadReport(@"
                SELECT ap.full_name, hd.decided_at
                FROM hiring_decisions hd
                INNER JOIN applications a ON a.application_id = hd.application_id
                INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
                WHERE hd.final_decision = 'accepted'
            ");
        }

        private void LoadRejected()
        {
            LoadReport(@"
                SELECT ap.full_name, hd.decided_at
                FROM hiring_decisions hd
                INNER JOIN applications a ON a.application_id = hd.application_id
                INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
                WHERE hd.final_decision = 'rejected'
            ");
        }

        private void LoadMissingRequirements()
        {
            LoadReport(@"
                SELECT ap.full_name, rt.label, ad.status
                FROM applicant_documents ad
                INNER JOIN applicants ap ON ap.applicant_id = ad.applicant_id
                INNER JOIN requirement_types rt ON rt.req_type_id = ad.req_type_id
                WHERE ad.status = 'missing'
            ");
        }

        // ================= BUTTON EVENTS =================



        private void btnApplicants_Click(object sender, EventArgs e)
        {
            LoadReport(@"SELECT applicant_id, full_name, email FROM applicants");
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            LoadReport(@"
        SELECT a.application_id, ap.full_name, a.status
        FROM applications a
        INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
        WHERE a.status IN ('draft','submitted','under_review')
    ");
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
            LoadReport(@"
        SELECT ap.full_name, s.scheduled_date, s.status
        FROM interview_schedules s
        INNER JOIN applications a ON a.application_id = s.application_id
        INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
    ");
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            LoadReport(@"
        SELECT ap.full_name, hd.decided_at
        FROM hiring_decisions hd
        INNER JOIN applications a ON a.application_id = hd.application_id
        INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
        WHERE hd.final_decision = 'accepted'
    ");
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            LoadReport(@"
        SELECT ap.full_name, hd.decided_at
        FROM hiring_decisions hd
        INNER JOIN applications a ON a.application_id = hd.application_id
        INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
        WHERE hd.final_decision = 'rejected'
    ");
        }

        private void btnMissing_Click(object sender, EventArgs e)
        {
            LoadReport(@"
        SELECT ap.full_name, rt.label, ad.status
        FROM applicant_documents ad
        INNER JOIN applicants ap ON ap.applicant_id = ad.applicant_id
        INNER JOIN requirement_types rt ON rt.req_type_id = ad.req_type_id
        WHERE ad.status = 'missing'
    ");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmHRDashboard().Show();
            this.Close();
        }
    }
}