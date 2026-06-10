using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
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
            listViewJobs.Columns.Clear();
            listViewJobs.Columns.Add("Vacancy ID", 80);
            listViewJobs.Columns.Add("Position", 160);
            listViewJobs.Columns.Add("Department", 140);
            listViewJobs.Columns.Add("Type", 100);
            listViewJobs.Columns.Add("Slots", 60);
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
                            v.slots
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

            string vacancyId = listViewJobs.SelectedItems[0].Text;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT 
                            p.title,
                            d.name AS department,
                            et.label AS employment_type,
                            v.description,
                            v.qualifications,
                            v.slots
                          FROM job_vacancies v
                          INNER JOIN positions p ON v.position_id = p.position_id
                          INNER JOIN departments d ON v.department_id = d.department_id
                          INNER JOIN employment_types et ON v.employment_type_id = et.type_id
                          WHERE v.vacancy_id = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", vacancyId);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                string details =
                                    $"Position: {dr["title"]}\n" +
                                    $"Department: {dr["department"]}\n" +
                                    $"Employment Type: {dr["employment_type"]}\n" +
                                    $"Slots: {dr["slots"]}\n\n" +
                                    $"Description:\n{dr["description"]}\n\n" +
                                    $"Qualifications:\n{dr["qualifications"]}";

                                MessageBox.Show(details, "Job Details");
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job to apply.");
                return;
            }

            string vacancyId = listViewJobs.SelectedItems[0].Text;
            string jobTitle = listViewJobs.SelectedItems[0].SubItems[1].Text;

            if (MessageBox.Show($"Apply for {jobTitle}?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
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
                            MessageBox.Show("Applicant not found.");
                            return;
                        }
                        applicantId = Convert.ToInt32(result);
                    }

                    // Check duplicate
                    using (SqlCommand checkCmd = new SqlCommand(
                        "SELECT COUNT(*) FROM applications WHERE applicant_id = @ApplicantId AND vacancy_id = @VacancyId",
                        conn))
                    {
                        checkCmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        checkCmd.Parameters.AddWithValue("@VacancyId", vacancyId);
                        if (Convert.ToInt32(checkCmd.ExecuteScalar()) > 0)
                        {
                            MessageBox.Show("You already applied for this job.");
                            return;
                        }
                    }

                    // Insert application
                    using (SqlCommand insertCmd = new SqlCommand(
                        @"INSERT INTO applications 
                            (applicant_id, vacancy_id, status, submitted_at, last_updated)
                          VALUES 
                            (@ApplicantId, @VacancyId, 'submitted', GETDATE(), GETDATE())",
                        conn))
                    {
                        insertCmd.Parameters.AddWithValue("@ApplicantId", applicantId);
                        insertCmd.Parameters.AddWithValue("@VacancyId", vacancyId);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Application submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmApplicantDashboard dash = new frmApplicantDashboard(userEmail);
            dash.Show();
            this.Hide();
        }

        private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}