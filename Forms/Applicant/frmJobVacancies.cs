using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmJobVacancies : Form
    {
        private string userEmail;

        public frmJobVacancies(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void frmJobVacancies_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadJobList();
        }

        private void SetupListView()
        {
            listViewJobs.View = System.Windows.Forms.View.Details;
            listViewJobs.FullRowSelect = true;
            listViewJobs.GridLines = true;
            listViewJobs.Columns.Clear();
            listViewJobs.Columns.Add("Vacancy ID", 80);
            listViewJobs.Columns.Add("Position", 180);
            listViewJobs.Columns.Add("Department", 160);
            listViewJobs.Columns.Add("Type", 110);
            listViewJobs.Columns.Add("Slots", 60);
            listViewJobs.Columns.Add("Description", 580);
            listViewJobs.Columns.Add("Qualifications", 580);
        }

        private void LoadJobList(string searchText = "")
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"SELECT 
                            v.vacancy_id,
                            p.title,
                            d.name AS department,
                            et.label AS employment_type,
                            v.slots,
                            v.description,
                            v.qualifications
                          FROM job_vacancies v
                          INNER JOIN positions p ON v.position_id = p.position_id
                          INNER JOIN departments d ON v.department_id = d.department_id
                          INNER JOIN employment_types et ON v.employment_type_id = et.type_id
                          WHERE v.status = 'open'";

                    if (!string.IsNullOrEmpty(searchText))
                        query += " AND (p.title LIKE @Search OR d.name LIKE @Search)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchText))
                            cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listViewJobs.Items.Clear();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["vacancy_id"].ToString());
                                item.SubItems.Add(dr["title"].ToString());
                                item.SubItems.Add(dr["department"].ToString());
                                item.SubItems.Add(dr["employment_type"].ToString());
                                item.SubItems.Add(dr["slots"].ToString());

                                string description = dr["description"] == DBNull.Value ? "" : dr["description"].ToString();
                                string qualifications = dr["qualifications"] == DBNull.Value ? "" : dr["qualifications"].ToString();

                                // Show a single-line preview in the table itself (per request).
                                item.SubItems.Add(SingleLine(description));
                                item.SubItems.Add(SingleLine(qualifications));

                                // Keep the full, untrimmed text for "View Full Details".
                                item.Tag = new string[] { description, qualifications };

                                listViewJobs.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private static string SingleLine(string text)
        {
            if (string.IsNullOrEmpty(text)) return "";
            string flat = text.Replace("\r\n", " ")
                               .Replace("\n", " ")
                               .Replace("\r", " ")
                               .Trim();
            return flat.Length > 180 ? flat.Substring(0, 180) + "…" : flat;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadJobList(txtSearch.Text);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job first.");
                return;
            }

            ListViewItem selected = listViewJobs.SelectedItems[0];
            string position = selected.SubItems[1].Text;
            string department = selected.SubItems[2].Text;
            string employmentType = selected.SubItems[3].Text;
            string slots = selected.SubItems[4].Text;

            string description = "";
            string qualifications = "";
            if (selected.Tag is string[] full)
            {
                description = full[0];
                qualifications = full[1];
            }

            string details =
                $"Position: {position}\n" +
                $"Department: {department}\n" +
                $"Employment Type: {employmentType}\n" +
                $"Slots: {slots}\n\n" +
                $"Description:\n{description}\n\n" +
                $"Qualifications:\n{qualifications}";

            MessageBox.Show(details, "Job Details");
        }

        // Checks every profile field for the applicant tied to userEmail.
        // Returns true only if ALL fields are filled in. On failure,
        // missingFields lists the human-readable names of what's blank.
        private bool IsProfileComplete(SqlConnection conn, string email, out string missingFields)
        {
            missingFields = "";

            using (SqlCommand cmd = new SqlCommand(
                @"SELECT full_name, birthdate, address, city, province, zip_code,
                         phone, gender, school, degree, year_grad, skills,
                         company, position, duration
                  FROM applicants WHERE email = @Email", conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (!dr.Read())
                    {
                        missingFields = "Profile not found.";
                        return false;
                    }

                    var missing = new List<string>();

                    void CheckText(string column, string label)
                    {
                        if (dr[column] == DBNull.Value || string.IsNullOrWhiteSpace(dr[column].ToString()))
                            missing.Add(label);
                    }

                    CheckText("full_name", "Full Name");
                    if (dr["birthdate"] == DBNull.Value) missing.Add("Birthdate");
                    CheckText("address", "Address");
                    CheckText("city", "City");
                    CheckText("province", "Province");
                    CheckText("zip_code", "Zip Code");
                    CheckText("phone", "Phone");
                    CheckText("gender", "Gender");
                    CheckText("school", "School");
                    CheckText("degree", "Degree");
                    CheckText("year_grad", "Year Graduated");
                    CheckText("skills", "Skills");
                    CheckText("company", "Company");
                    CheckText("position", "Work Position");
                    CheckText("duration", "Work Duration");

                    if (missing.Count > 0)
                    {
                        missingFields = string.Join(", ", missing);
                        return false;
                    }

                    return true;
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job to apply.");
                return;
            }

            string vacancyIdStr = listViewJobs.SelectedItems[0].Text.Trim();
            string jobTitle = listViewJobs.SelectedItems[0].SubItems[1].Text;

            if (MessageBox.Show($"Apply for {jobTitle}?", "Confirm Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    // Get applicant_id
                    int applicantId;
                    using (SqlCommand idCmd = new SqlCommand(
                        "SELECT applicant_id FROM applicants WHERE email = @Email", conn))
                    {
                        idCmd.Parameters.AddWithValue("@Email", userEmail);
                        object result = idCmd.ExecuteScalar();
                        if (result == null)
                        {
                            MessageBox.Show("Applicant account not found.");
                            return;
                        }
                        applicantId = Convert.ToInt32(result);
                    }

                    // Profile must be fully filled out before applying.
                    if (!IsProfileComplete(conn, userEmail, out string missingFields))
                    {
                        DialogResult goToProfile = MessageBox.Show(
                            $"Please complete your profile before applying.\n\nMissing: {missingFields}\n\nGo to My Profile now?",
                            "Profile Incomplete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (goToProfile == DialogResult.Yes)
                        {
                            using (var frm = new frmMyProfile(userEmail))
                            {
                                frm.ShowDialog();
                            }
                        }
                        return;
                    }

                    // Parse vacancy ID safely
                    if (!int.TryParse(vacancyIdStr, out int vacancyId) || vacancyId <= 0)
                    {
                        MessageBox.Show("Invalid job vacancy selected.");
                        return;
                    }

                    // === IMPROVED DUPLICATE CHECK ===
                    using (SqlCommand checkCmd = new SqlCommand(
                        @"SELECT application_id, status 
                  FROM applications 
                  WHERE applicant_id = @ApplicantId 
                    AND vacancy_id = @VacancyId", conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        checkCmd.Parameters.AddWithValue("@VacancyId", vacancyId);

                        using (SqlDataReader reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string existingStatus = reader["status"].ToString();
                                MessageBox.Show($"You have already applied for this position.\n\nCurrent status: {existingStatus}",
                                    "Already Applied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                    }

                    // Validate vacancy still exists and is open
                    using (SqlCommand validateCmd = new SqlCommand(
                        "SELECT status FROM job_vacancies WHERE vacancy_id = @VacancyId AND status = 'open'", conn))
                    {
                        validateCmd.Parameters.AddWithValue("@VacancyId", vacancyId);
                        if (validateCmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("This job vacancy is no longer available.");
                            return;
                        }
                    }

                    // INSERT the application
                    int newAppId;
                    using (SqlCommand insertCmd = new SqlCommand(
                        @"INSERT INTO applications 
                    (applicant_id, vacancy_id, status, submitted_at, last_updated)
                  OUTPUT INSERTED.application_id
                  VALUES (@ApplicantId, @VacancyId, 'submitted', GETDATE(), GETDATE())", conn))
                    {
                        insertCmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        insertCmd.Parameters.AddWithValue("@VacancyId", vacancyId);

                        newAppId = Convert.ToInt32(insertCmd.ExecuteScalar());
                    }

                    // Log status history
                    StatusHistoryLogger.LogStatusChange(
                        newAppId, "draft", "submitted", applicantId,
                        "Applicant submitted application.");

                    MessageBox.Show("Application submitted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Refresh the list
                    LoadJobList(txtSearch.Text);
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                MessageBox.Show("Error: The job vacancy or your account is no longer valid.", "Database Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f is frmApplicantDashboard)
                {
                    f.Show();
                    f.BringToFront();
                    break;
                }
            }
            this.Close();
        }

        private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}