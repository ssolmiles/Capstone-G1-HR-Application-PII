using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using HRApplicantSystem.Helpers;
using System.Web;
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportFullReport();
        }

        private void ExportFullReport()
        {
            using (var saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "HTML Report (*.html)|*.html";
                saveDialog.FileName = $"HR_Report_{DateTime.Now:yyyyMMdd_HHmmss}.html";
                saveDialog.Title = "Export Full HR Report";

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var sb = new System.Text.StringBuilder();

                    // ── PAGE HEADER ──────────────────────────────────
                    sb.AppendLine(@"<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8'>
<title>HR Applicant System — Full Report</title>
<style>
  body        { font-family: Verdana, sans-serif; margin: 40px;
                background: #f4f6f9; color: #333; }
  h1          { color: #1f3864; border-bottom: 3px solid #1f5c99;
                padding-bottom: 10px; }
  h2          { color: #1f5c99; margin-top: 40px;
                border-left: 5px solid #1f5c99;
                padding-left: 10px; }
  .meta       { color: #888; font-size: 12px; margin-bottom: 30px; }
  .summary    { display: flex; gap: 20px; flex-wrap: wrap;
                margin-bottom: 30px; }
  .card       { background: #1f5c99; color: white; border-radius: 8px;
                padding: 16px 24px; min-width: 140px; text-align: center; }
  .card span  { display: block; font-size: 28px; font-weight: bold; }
  .card label { font-size: 12px; opacity: 0.85; }
  table       { border-collapse: collapse; width: 100%;
                margin-bottom: 20px; background: white;
                box-shadow: 0 1px 4px rgba(0,0,0,0.1); }
  th          { background: #1f5c99; color: white; padding: 10px 14px;
                text-align: left; font-size: 13px; }
  td          { padding: 9px 14px; font-size: 13px;
                border-bottom: 1px solid #eee; }
  tr:hover td { background: #f0f5ff; }
  .badge      { padding: 3px 10px; border-radius: 12px;
                font-size: 11px; font-weight: bold; color: white;
                display: inline-block; }
  .badge-green  { background: #27ae60; }
  .badge-red    { background: #c0392b; }
  .badge-orange { background: #e67e22; }
  .badge-gray   { background: #95a5a6; }
  .badge-blue   { background: #2980b9; }
  .no-data    { color: #aaa; font-style: italic; padding: 12px; }
  .footer     { margin-top: 50px; color: #aaa; font-size: 11px;
                text-align: center; border-top: 1px solid #ddd;
                padding-top: 16px; }
</style>
</head>
<body>");

                    sb.AppendLine($@"
<h1>HR Applicant System — Full Report</h1>
<p class='meta'>Generated on: {DateTime.Now:MMMM dd, yyyy — hh:mm tt}</p>");

                    // ── SUMMARY CARDS ────────────────────────────────
                    using (var conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        int totalApplicants = GetCount(conn,
                            "SELECT COUNT(*) FROM applicants");
                        int pending = GetCount(conn,
                            "SELECT COUNT(*) FROM applications WHERE status IN ('draft','submitted','under_review')");
                        int interviews = GetCount(conn,
                            "SELECT COUNT(*) FROM interview_schedules");
                        int accepted = GetCount(conn,
                            "SELECT COUNT(*) FROM hiring_decisions WHERE final_decision = 'accepted'");
                        int rejected = GetCount(conn,
                            "SELECT COUNT(*) FROM hiring_decisions WHERE final_decision = 'rejected'");
                        int missing = GetCount(conn,
                            "SELECT COUNT(*) FROM applicant_documents WHERE status = 'missing'");

                        sb.AppendLine($@"
<div class='summary'>
  <div class='card'><span>{totalApplicants}</span><label>Total Applicants</label></div>
  <div class='card'><span>{pending}</span><label>Pending Applications</label></div>
  <div class='card'><span>{interviews}</span><label>Interviews</label></div>
  <div class='card' style='background:#27ae60'><span>{accepted}</span><label>Accepted</label></div>
  <div class='card' style='background:#c0392b'><span>{rejected}</span><label>Rejected</label></div>
  <div class='card' style='background:#e67e22'><span>{missing}</span><label>Missing Docs</label></div>
</div>");

                        // ── SECTION 1: APPLICANT LIST ────────────────
                        sb.AppendLine("<h2>1. Applicant List</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        ap.applicant_id         AS [ID],
                        ap.full_name            AS [Full Name],
                        ap.email                AS [Email],
                        ap.phone                AS [Phone],
                        ap.city                 AS [City],
                        COUNT(a.application_id) AS [Total Applications],
                        CONVERT(varchar, ap.created_at, 107) AS [Registered On]
                    FROM applicants ap
                    LEFT JOIN applications a ON a.applicant_id = ap.applicant_id
                    GROUP BY ap.applicant_id, ap.full_name, ap.email,
                             ap.phone, ap.city, ap.created_at
                    ORDER BY ap.created_at DESC");

                        // ── SECTION 2: PENDING APPLICATIONS ─────────
                        sb.AppendLine("<h2>2. Pending Applications</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        a.application_id        AS [App ID],
                        ap.full_name            AS [Applicant],
                        ap.email                AS [Email],
                        p.title                 AS [Position],
                        d.name                  AS [Department],
                        et.label                AS [Employment Type],
                        a.status                AS [Status],
                        CONVERT(varchar, a.submitted_at, 107)  AS [Submitted On],
                        CONVERT(varchar, a.last_updated, 107)  AS [Last Updated]
                    FROM applications a
                    INNER JOIN applicants ap      ON ap.applicant_id    = a.applicant_id
                    INNER JOIN job_vacancies v    ON v.vacancy_id       = a.vacancy_id
                    INNER JOIN positions p        ON p.position_id      = v.position_id
                    INNER JOIN departments d      ON d.department_id    = v.department_id
                    INNER JOIN employment_types et ON et.type_id        = v.employment_type_id
                    WHERE a.status IN ('draft','submitted','under_review')
                    ORDER BY a.last_updated DESC", statusCol: "Status");

                        // ── SECTION 3: INTERVIEWS ────────────────────
                        sb.AppendLine("<h2>3. Interview Schedule</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        ap.full_name            AS [Applicant],
                        ap.email                AS [Email],
                        p.title                 AS [Position],
                        d.name                  AS [Department],
                        CONVERT(varchar, s.scheduled_date, 107) AS [Interview Date],
                        CONVERT(varchar, s.scheduled_time, 108) AS [Interview Time],
                        s.status                AS [Interview Status],
                        s.location              AS [Location]
                    FROM interview_schedules s
                    INNER JOIN applications a   ON a.application_id  = s.application_id
                    INNER JOIN applicants ap    ON ap.applicant_id   = a.applicant_id
                    INNER JOIN job_vacancies v  ON v.vacancy_id      = a.vacancy_id
                    INNER JOIN positions p      ON p.position_id     = v.position_id
                    INNER JOIN departments d    ON d.department_id   = v.department_id
                    ORDER BY s.scheduled_date DESC", statusCol: "Interview Status");

                        // ── SECTION 4: ACCEPTED ──────────────────────
                        sb.AppendLine("<h2>4. Accepted Applicants</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        ap.full_name            AS [Applicant],
                        ap.email                AS [Email],
                        ap.phone                AS [Phone],
                        p.title                 AS [Position],
                        d.name                  AS [Department],
                        et.label                AS [Employment Type],
                        CONVERT(varchar, hd.decided_at, 107) AS [Date Accepted],
                        hd.remarks              AS [Remarks]
                    FROM hiring_decisions hd
                    INNER JOIN applications a    ON a.application_id  = hd.application_id
                    INNER JOIN applicants ap     ON ap.applicant_id   = a.applicant_id
                    INNER JOIN job_vacancies v   ON v.vacancy_id      = a.vacancy_id
                    INNER JOIN positions p       ON p.position_id     = v.position_id
                    INNER JOIN departments d     ON d.department_id   = v.department_id
                    INNER JOIN employment_types et ON et.type_id      = v.employment_type_id
                    WHERE hd.final_decision = 'accepted'
                    ORDER BY hd.decided_at DESC");

                        // ── SECTION 5: REJECTED ──────────────────────
                        sb.AppendLine("<h2>5. Rejected Applicants</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        ap.full_name            AS [Applicant],
                        ap.email                AS [Email],
                        p.title                 AS [Position],
                        d.name                  AS [Department],
                        CONVERT(varchar, hd.decided_at, 107) AS [Date Rejected],
                        hd.remarks              AS [Remarks]
                    FROM hiring_decisions hd
                    INNER JOIN applications a   ON a.application_id  = hd.application_id
                    INNER JOIN applicants ap    ON ap.applicant_id   = a.applicant_id
                    INNER JOIN job_vacancies v  ON v.vacancy_id      = a.vacancy_id
                    INNER JOIN positions p      ON p.position_id     = v.position_id
                    INNER JOIN departments d    ON d.department_id   = v.department_id
                    WHERE hd.final_decision = 'rejected'
                    ORDER BY hd.decided_at DESC");

                        // ── SECTION 6: MISSING REQUIREMENTS ─────────
                        sb.AppendLine("<h2>6. Missing Requirements</h2>");
                        AppendTable(conn, sb, @"
                    SELECT
                        ap.full_name            AS [Applicant],
                        ap.email                AS [Email],
                        p.title                 AS [Position],
                        d.name                  AS [Department],
                        rt.label                AS [Missing Document],
                        a.status                AS [Application Status],
                        CONVERT(varchar, a.submitted_at, 107) AS [Submitted On]
                    FROM applicant_documents ad
                    INNER JOIN applicants ap    ON ap.applicant_id   = ad.applicant_id
                    INNER JOIN requirement_types rt ON rt.req_type_id = ad.req_type_id
                    INNER JOIN applications a   ON a.applicant_id    = ap.applicant_id
                    INNER JOIN job_vacancies v  ON v.vacancy_id      = a.vacancy_id
                    INNER JOIN positions p      ON p.position_id     = v.position_id
                    INNER JOIN departments d    ON d.department_id   = v.department_id
                    WHERE ad.status = 'missing'
                    ORDER BY ap.full_name, rt.label",
                            statusCol: "Application Status");
                    }

                    // ── PAGE FOOTER ──────────────────────────────────
                    sb.AppendLine($@"
<div class='footer'>
    HR Applicant System &nbsp;|&nbsp; Report generated {DateTime.Now:yyyy}
</div>
</body></html>");

                    System.IO.File.WriteAllText(
                        saveDialog.FileName, sb.ToString(),
                        System.Text.Encoding.UTF8);

                    // Open in browser automatically
                    System.Diagnostics.Process.Start(
                        new System.Diagnostics.ProcessStartInfo(saveDialog.FileName)
                        { UseShellExecute = true });

                    MessageBox.Show("Report exported and opened successfully!",
                        "Export Complete", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export error: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Builds one HTML table from a SQL query and appends it to the report
        private void AppendTable(SqlConnection conn,
            System.Text.StringBuilder sb,
            string sql,
            string statusCol = "")
        {
            using (var cmd = new SqlCommand(sql, conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    sb.AppendLine("<p class='no-data'>No records found.</p>");
                    return;
                }

                sb.AppendLine($"<p style='color:#888;font-size:12px'>{dt.Rows.Count} record(s)</p>");
                sb.AppendLine("<table><thead><tr>");

                foreach (DataColumn col in dt.Columns)
                    sb.AppendLine($"<th>{col.ColumnName}</th>");

                sb.AppendLine("</tr></thead><tbody>");

                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendLine("<tr>");
                    foreach (DataColumn col in dt.Columns)
                    {
                        string val = row[col]?.ToString() ?? "";

                        // Apply colour badges to status columns
                        if (col.ColumnName == statusCol && !string.IsNullOrEmpty(val))
                        {
                            string badgeClass;
                            switch (val.ToLower())
                            {
                                case "accepted":
                                case "hired":
                                case "completed":
                                    badgeClass = "badge-green"; break;
                                case "rejected":
                                case "cancelled":
                                    badgeClass = "badge-red"; break;
                                case "submitted":
                                case "screened":
                                case "interview_scheduled":
                                case "interviewed":
                                case "scheduled":
                                    badgeClass = "badge-blue"; break;
                                case "under_review":
                                    badgeClass = "badge-orange"; break;
                                case "draft":
                                default:
                                    badgeClass = "badge-gray"; break;
                            }
                            sb.AppendLine(
                                $"<td><span class='badge {badgeClass}'>{val}</span></td>");
                        }
                        else
                        {
                            sb.AppendLine($"<td>{val.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;")}</td>");
                        }
                    }
                    sb.AppendLine("</tr>");
                }

                sb.AppendLine("</tbody></table>");
            }
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
        private void LoadReport(string sql, string reportTitle = "")
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

                        // Fix ###### — auto size all columns to fit content
                        dgvReports.AutoSizeColumnsMode =
                            DataGridViewAutoSizeColumnsMode.AllCells;

                        // Show report title and record count
                        if (!string.IsNullOrEmpty(reportTitle))
                            lblReportTitle.Text =
                                $"{reportTitle}  —  {dt.Rows.Count} record(s)";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ================= REPORTS =================

        // ================= REPORTS =================

        private void LoadApplicants()
        {
            LoadReport(@"
        SELECT
            ap.applicant_id         AS [ID],
            ap.full_name            AS [Full Name],
            ap.email                AS [Email],
            ap.phone                AS [Phone],
            ap.city                 AS [City],
            COUNT(a.application_id) AS [Total Applications],
            ap.created_at           AS [Registered On]
        FROM applicants ap
        LEFT JOIN applications a ON a.applicant_id = ap.applicant_id
        GROUP BY ap.applicant_id, ap.full_name, ap.email,
                 ap.phone, ap.city, ap.created_at
        ORDER BY ap.created_at DESC",
                "Applicant List");
        }

        private void LoadPending()
        {
            LoadReport(@"
        SELECT
            a.application_id        AS [App ID],
            ap.full_name            AS [Applicant],
            ap.email                AS [Email],
            p.title                 AS [Position],
            d.name                  AS [Department],
            et.label                AS [Employment Type],
            a.status                AS [Status],
            a.submitted_at          AS [Submitted On],
            a.last_updated          AS [Last Updated]
        FROM applications a
        INNER JOIN applicants ap    ON ap.applicant_id     = a.applicant_id
        INNER JOIN job_vacancies v  ON v.vacancy_id        = a.vacancy_id
        INNER JOIN positions p      ON p.position_id       = v.position_id
        INNER JOIN departments d    ON d.department_id     = v.department_id
        INNER JOIN employment_types et ON et.type_id       = v.employment_type_id
        WHERE a.status IN ('draft', 'submitted', 'under_review')
        ORDER BY a.last_updated DESC",
                "Pending Applications");
        }

        private void LoadInterviews()
        {
            LoadReport(@"
        SELECT
            ap.full_name            AS [Applicant],
            ap.email                AS [Email],
            p.title                 AS [Position],
            d.name                  AS [Department],
            s.scheduled_date        AS [Interview Date],
            s.scheduled_time        AS [Interview Time],
            s.status                AS [Interview Status],
            s.location              AS [Location]
        FROM interview_schedules s
        INNER JOIN applications a   ON a.application_id   = s.application_id
        INNER JOIN applicants ap    ON ap.applicant_id    = a.applicant_id
        INNER JOIN job_vacancies v  ON v.vacancy_id       = a.vacancy_id
        INNER JOIN positions p      ON p.position_id      = v.position_id
        INNER JOIN departments d    ON d.department_id    = v.department_id
        ORDER BY s.scheduled_date DESC",
                "Interview Schedule");
        }

        private void LoadAccepted()
        {
            LoadReport(@"
        SELECT
            ap.full_name            AS [Applicant],
            ap.email                AS [Email],
            ap.phone                AS [Phone],
            p.title                 AS [Position],
            d.name                  AS [Department],
            et.label                AS [Employment Type],
            hd.decided_at           AS [Date Accepted],
            hd.remarks              AS [Remarks]
        FROM hiring_decisions hd
        INNER JOIN applications a   ON a.application_id   = hd.application_id
        INNER JOIN applicants ap    ON ap.applicant_id    = a.applicant_id
        INNER JOIN job_vacancies v  ON v.vacancy_id       = a.vacancy_id
        INNER JOIN positions p      ON p.position_id      = v.position_id
        INNER JOIN departments d    ON d.department_id    = v.department_id
        INNER JOIN employment_types et ON et.type_id      = v.employment_type_id
        WHERE hd.final_decision = 'accepted'
        ORDER BY hd.decided_at DESC",
                "Accepted Applicants");
        }

        private void LoadRejected()
        {
            LoadReport(@"
        SELECT
            ap.full_name            AS [Applicant],
            ap.email                AS [Email],
            p.title                 AS [Position],
            d.name                  AS [Department],
            hd.decided_at           AS [Date Rejected],
            hd.remarks              AS [Remarks]
        FROM hiring_decisions hd
        INNER JOIN applications a   ON a.application_id   = hd.application_id
        INNER JOIN applicants ap    ON ap.applicant_id    = a.applicant_id
        INNER JOIN job_vacancies v  ON v.vacancy_id       = a.vacancy_id
        INNER JOIN positions p      ON p.position_id      = v.position_id
        INNER JOIN departments d    ON d.department_id    = v.department_id
        WHERE hd.final_decision = 'rejected'
        ORDER BY hd.decided_at DESC",
                "Rejected Applicants");
        }

        private void LoadMissingRequirements()
        {
            LoadReport(@"
        SELECT
            ap.full_name            AS [Applicant],
            ap.email                AS [Email],
            p.title                 AS [Position],
            d.name                  AS [Department],
            rt.label                AS [Missing Document],
            a.status                AS [Application Status],
            a.submitted_at          AS [Submitted On]
        FROM applicant_documents ad
        INNER JOIN applicants ap    ON ap.applicant_id    = ad.applicant_id
        INNER JOIN requirement_types rt ON rt.req_type_id = ad.req_type_id
        INNER JOIN applications a   ON a.applicant_id     = ap.applicant_id
        INNER JOIN job_vacancies v  ON v.vacancy_id       = a.vacancy_id
        INNER JOIN positions p      ON p.position_id      = v.position_id
        INNER JOIN departments d    ON d.department_id    = v.department_id
        WHERE ad.status = 'missing'
        ORDER BY ap.full_name, rt.label",
                "Missing Requirements");
        }

        // ================= BUTTON EVENTS =================

        private void btnApplicants_Click(object sender, EventArgs e)
            => LoadApplicants();

        private void btnPending_Click(object sender, EventArgs e)
            => LoadPending();

        private void btnInterviews_Click(object sender, EventArgs e)
            => LoadInterviews();

        private void btnAccepted_Click(object sender, EventArgs e)
            => LoadAccepted();

        private void btnRejected_Click(object sender, EventArgs e)
            => LoadRejected();

        private void btnMissing_Click(object sender, EventArgs e)
            => LoadMissingRequirements();
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            new frmHRDashboard().Show();
            this.Close();
        }
    }
}