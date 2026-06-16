using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmMyApplication : Form
    {
        private string userEmail;

        public frmMyApplication(string email)
        {
            InitializeComponent();
            userEmail = email;

            listViewApps.View = System.Windows.Forms.View.Details;
            listViewApps.FullRowSelect = true;
            listViewApps.GridLines = true;
            listViewApps.Columns.Clear();
            listViewApps.Columns.Add("App ID", 70);
            listViewApps.Columns.Add("Position", 200);
            listViewApps.Columns.Add("Department", 160);
            listViewApps.Columns.Add("Status", 110);
            listViewApps.Columns.Add("Submitted", 110);
        }

        private void frmMyApplication_Load(object sender, EventArgs e)
        {
            LoadMyApplications();
        }

        private void LoadMyApplications()
        {
            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT 
                            a.application_id,
                            p.title AS position_title,
                            d.name AS department_name,
                            a.status,
                            a.submitted_at
                          FROM applications a
                          INNER JOIN applicants ap ON a.applicant_id = ap.applicant_id
                          INNER JOIN job_vacancies v ON a.vacancy_id = v.vacancy_id
                          INNER JOIN positions p ON v.position_id = p.position_id
                          INNER JOIN departments d ON v.department_id = d.department_id
                          WHERE ap.email = @Email
                          ORDER BY a.last_updated DESC", conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            listViewApps.Items.Clear();
                            while (dr.Read())
                            {
                                ListViewItem item = new ListViewItem(dr["application_id"].ToString());
                                item.SubItems.Add(dr["position_title"].ToString());
                                item.SubItems.Add(dr["department_name"].ToString());
                                item.SubItems.Add(dr["status"].ToString());
                                item.SubItems.Add(
                                    dr["submitted_at"] == DBNull.Value
                                    ? "Not submitted"
                                    : Convert.ToDateTime(dr["submitted_at"]).ToString("MM/dd/yyyy"));

                                switch (dr["status"].ToString())
                                {
                                    case "draft": item.ForeColor = Color.Gray; break;
                                    case "submitted":
                                    case "under_review": item.ForeColor = Color.Orange; break;
                                    case "accepted": item.ForeColor = Color.Green; break;
                                    case "rejected": item.ForeColor = Color.Red; break;
                                }

                                listViewApps.Items.Add(item);
                            }

                            // FIX: Show a helpful message when the list is empty
                            if (listViewApps.Items.Count == 0)
                            {
                                ListViewItem empty = new ListViewItem("—");
                                empty.SubItems.Add("No applications found.");
                                empty.SubItems.Add(""); empty.SubItems.Add(""); empty.SubItems.Add("");
                                empty.ForeColor = Color.Gray;
                                listViewApps.Items.Add(empty);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applications: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To apply for a job, please use the Job Vacancies page.",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an application first.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string appId = listViewApps.SelectedItems[0].Text;
            string currentStatus = listViewApps.SelectedItems[0].SubItems[3].Text;

            if (currentStatus != "draft")
            {
                MessageBox.Show("Cannot submit — this application has already been processed.",
                    "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to submit this application?",
                "Confirm Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE applications 
                          SET status = 'submitted', submitted_at = GETDATE(), last_updated = GETDATE()
                          WHERE application_id = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", appId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Application submitted successfully!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMyApplications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error submitting application: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // FIX: Guard was missing; only drafts are editable
            if (listViewApps.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an application to edit.",
                    "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = listViewApps.SelectedItems[0].SubItems[3].Text;

            if (status != "draft")
            {
                MessageBox.Show("Cannot edit — only draft applications can be modified.",
                    "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            MessageBox.Show("Edit feature: open your edit form here.",
                "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewApps_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    

        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}