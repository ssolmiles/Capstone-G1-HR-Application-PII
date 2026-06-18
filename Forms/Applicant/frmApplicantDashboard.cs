using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicantDashboard : Form
    {
        private string userEmail;

        public frmApplicantDashboard()
        {
            InitializeComponent();
            userEmail = string.Empty;
        }

        // Runtime constructor
        public frmApplicantDashboard(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmApplicantDashboard_Load_1(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadWelcomeName();
            LoadAuditTrail();
        }

        private void LoadWelcomeName()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT full_name FROM applicants WHERE email = @Email", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            textBox1.Text = $"Welcome, {result}!";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading name: " + ex.Message);
            }
        }

        private void LoadAuditTrail()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT
                    al.performed_at AS [Date & Time],
                    al.action       AS [Action],
                    al.target       AS [Area],
                    al.target_id    AS [Record ID]
                  FROM audit_logs al
                  INNER JOIN applicants ap
                      ON al.user_id = ap.applicant_id
                  WHERE ap.email = @Email
                  ORDER BY al.performed_at DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        var dt = new System.Data.DataTable();
                        new SqlDataAdapter(cmd).Fill(dt);
                        dgvAuditTrail.DataSource = dt;

                        // Color rows by action type
                        foreach (DataGridViewRow row in dgvAuditTrail.Rows)
                        {
                            string action = row.Cells["Action"].Value?.ToString().ToLower() ?? "";

                            if (action.Contains("submitted"))
                                row.DefaultCellStyle.ForeColor = Color.Green;
                            else if (action.Contains("deleted") || action.Contains("withdrew"))
                                row.DefaultCellStyle.ForeColor = Color.Red;
                            else if (action.Contains("uploaded"))
                                row.DefaultCellStyle.ForeColor = Color.Blue;
                            else if (action.Contains("draft"))
                                row.DefaultCellStyle.ForeColor = Color.Gray;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading audit trail: " + ex.Message);
            }
        }
        private void LoadDashboardData()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // 1. Latest application status
                    string appStatus = ""; // declared here so accessible throughout

                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT TOP 1 a.status
                  FROM applications a
                  INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
                  WHERE ap.email = @Email
                  ORDER BY a.last_updated DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            appStatus = result.ToString();
                            lblStatus.Text = "Application: " + appStatus;
                            switch (appStatus)
                            {
                                case "accepted":
                                    lblStatus.ForeColor = Color.Green; break;
                                case "rejected":
                                case "interview_cancelled":
                                    lblStatus.ForeColor = Color.Red; break;
                                case "draft":
                                    lblStatus.ForeColor = Color.Gray; break;
                                case "under_review":
                                case "screened":
                                case "interview_scheduled":
                                case "interviewed":
                                case "evaluated":
                                    lblStatus.ForeColor = Color.Blue; break;
                                default:
                                    lblStatus.ForeColor = Color.DarkOrange; break;
                            }
                        }
                        else
                        {
                            lblStatus.Text = "Application: None yet";
                            lblStatus.ForeColor = Color.Gray;
                        }
                    }

                    // 2. Missing document count
                    // 2. Missing document count — based on actual job requirements
                    using (SqlCommand cmd = new SqlCommand(
    @"SELECT 
        COUNT(jr.req_type_id) AS total_required,
        SUM(CASE WHEN ad.status = 'submitted' AND ad.file_path IS NOT NULL 
                 THEN 1 ELSE 0 END) AS total_submitted
      FROM applications a
      INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
      INNER JOIN job_requirements jr ON jr.job_id = a.vacancy_id
      LEFT JOIN applicant_documents ad 
          ON ad.req_type_id = jr.req_type_id 
          AND ad.applicant_id = ap.applicant_id
      WHERE ap.email = @Email
      AND a.last_updated = (
          SELECT MAX(a2.last_updated) 
          FROM applications a2 
          INNER JOIN applicants ap2 ON ap2.applicant_id = a2.applicant_id
          WHERE ap2.email = @Email
      )", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                int totalRequired = Convert.ToInt32(dr["total_required"]);
                                int totalSubmitted = dr["total_submitted"] == DBNull.Value
                                                     ? 0
                                                     : Convert.ToInt32(dr["total_submitted"]);
                                int missingDocs = totalRequired - totalSubmitted;
                                if (missingDocs < 0) missingDocs = 0;

                                if (totalRequired == 0)
                                {
                                    lblMissingDocs.Text = "Missing document count: N/A";
                                    lblMissingDocs.ForeColor = Color.Gray;
                                }
                                else
                                {
                                    lblMissingDocs.Text = $"Missing document count: {missingDocs}";
                                    lblMissingDocs.ForeColor = (missingDocs == 0) ? Color.Green : Color.Red;
                                }
                            }
                            else
                            {
                                lblMissingDocs.Text = "Missing document count: N/A";
                                lblMissingDocs.ForeColor = Color.Gray;
                            }
                        }
                    }

                    // 3. Interview schedule — hide if applicant is already accepted
                    if (appStatus == "accepted")
                    {
                        lblSchedule.Text = "Interview Schedule: N/A (Accepted)";
                        lblSchedule.ForeColor = Color.Green;
                    }
                    else
                    {
                        using (SqlCommand schedCmd = new SqlCommand(
                            @"SELECT TOP 1 s.scheduled_date, s.scheduled_time
                      FROM interview_schedules s
                      INNER JOIN applications a ON s.application_id = a.application_id
                      INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                      WHERE ap.email = @Email
                      AND s.status NOT IN ('cancelled', 'completed')
                        AND s.scheduled_date >= CAST(GETDATE() AS DATE)", conn))
                        {
                            schedCmd.Parameters.AddWithValue("@Email", userEmail);
                            using (SqlDataReader dr = schedCmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    string date = Convert.ToDateTime(dr["scheduled_date"]).ToString("MMMM dd, yyyy");
                                    string time = dr["scheduled_time"].ToString();
                                    lblSchedule.Text = $"Interview Schedule: {date} at {time}";
                                    lblSchedule.ForeColor = Color.Black;
                                }
                                else
                                {
                                    lblSchedule.Text = "No schedule yet.";
                                    lblSchedule.ForeColor = Color.Black;
                                }
                            }
                        }
                    }

                    // 4. Upcoming interview count
                    // 4. Upcoming interview count — match same condition as schedule display
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT COUNT(*) 
                          FROM interview_schedules s
                          INNER JOIN applications a ON s.application_id = a.application_id
                          INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                          WHERE ap.email = @Email 
                          AND s.status NOT IN ('cancelled', 'completed')
                          AND s.scheduled_date >= CAST(GETDATE() AS DATE)", conn))
                                        {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        label1.Text = $"Upcoming Interview: {count}";
                    }

                    // 5. Recent updates based on application status
                    switch (appStatus)
                    {
                        case "accepted":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- Congratulations! You have been accepted.\n" +
                                "- Please wait for further onboarding instructions.\n" +
                                "- Check your email for the job offer details.";
                            lblUpdates.ForeColor = Color.Green;
                            break;
                        case "rejected":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- We regret to inform you that your application was not successful.\n" +
                                "- Thank you for your time and interest.\n" +
                                "- You may re-apply for other positions in the future.";
                            lblUpdates.ForeColor = Color.Red;
                            break;
                        case "interview_scheduled":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- Your interview has been scheduled.\n" +
                                "- Please check the schedule details above.\n" +
                                "- Be on time and prepare well.";
                            lblUpdates.ForeColor = Color.Blue;
                            break;
                        case "interviewed":
                        case "evaluated":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- Your interview has been completed.\n" +
                                "- Results are being reviewed by HR.\n" +
                                "- Please wait for the final decision.";
                            lblUpdates.ForeColor = Color.Blue;
                            break;
                        case "screened":
                        case "under_review":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- Your application is currently under review.\n" +
                                "- Please check your email regularly.\n" +
                                "- Ensure all documents are submitted.";
                            lblUpdates.ForeColor = Color.DarkOrange;
                            break;
                        case "interview_cancelled":
                            lblUpdates.Text =
                                "RECENT UPDATES:\n" +
                                "- Your interview has been cancelled.\n" +
                                "- Please contact HR for more information.\n" +
                                "- A new schedule may be arranged.";
                            lblUpdates.ForeColor = Color.Red;
                            break;
                        default:
                            // Check if the vacancy is closed
                            string vacancyStatus = "";
                            using (SqlCommand vacCmd = new SqlCommand(
                                @"SELECT TOP 1 v.status
          FROM job_vacancies v
          INNER JOIN applications a ON a.vacancy_id = v.vacancy_id
          INNER JOIN applicants ap ON ap.applicant_id = a.applicant_id
          WHERE ap.email = @Email
          ORDER BY a.last_updated DESC", conn))
                            {
                                vacCmd.Parameters.AddWithValue("@Email", userEmail);
                                object vacResult = vacCmd.ExecuteScalar();
                                vacancyStatus = vacResult?.ToString() ?? "";
                            }

                            if (vacancyStatus == "closed")
                            {
                                lblUpdates.Text =
                                    "RECENT UPDATES:\n" +
                                    "- ⚠ The vacancy you applied for has been closed.\n" +
                                    "- No further action is required for this application.\n" +
                                    "- You may check other open vacancies.";
                                lblUpdates.ForeColor = Color.OrangeRed;
                                lblStatus.Text = "Application: Vacancy Closed";
                                lblStatus.ForeColor = Color.OrangeRed;
                            }
                            else
                            {
                                lblUpdates.Text =
                                    "RECENT UPDATES:\n" +
                                    "- Application review is ongoing.\n" +
                                    "- Please check your email regularly.\n" +
                                    "- New requirements posted.";
                                lblUpdates.ForeColor = Color.Black;
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmMyProfile profile = new frmMyProfile(userEmail);
            profile.Show();
            this.Hide();
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            frmChangePassword cp = new frmChangePassword(userEmail);
            cp.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AuditLogger.LogActionByEmail(userEmail, "Logged out", "applicants");

            frmApplicantLogin login = new frmApplicantLogin();
            login.Show();
            this.Close();
        }

        private void btnViewStatus_Click(object sender, EventArgs e)
        {
            frmApplicationStatus statusForm = new frmApplicationStatus(userEmail);
            statusForm.Show();
        }

        private void btnJobVacancies_Click(object sender, EventArgs e)
        {
            frmJobVacancies jobForm = new frmJobVacancies(userEmail);
            jobForm.Show();
            this.Hide();
        }

        private void btnMyApplication_Click(object sender, EventArgs e)
        {
            using (frmMyApplication myApp = new frmMyApplication(userEmail))
            {
                myApp.ShowDialog(this);
            }
            LoadDashboardData();
            LoadAuditTrail();
        }


        // --- Stub handlers ---
        private void lblStatus_Click(object sender, EventArgs e) { }
        private void lblMissingDocs_Click(object sender, EventArgs e) { }
        private void lblSchedule_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void groupBox4_Enter(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
    }
}