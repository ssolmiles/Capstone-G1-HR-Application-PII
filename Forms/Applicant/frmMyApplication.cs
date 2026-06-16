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
            listViewApps.Columns.Add("Position", 160);
            listViewApps.Columns.Add("Department", 130);
            listViewApps.Columns.Add("Status", 100);
            listViewApps.Columns.Add("Submitted", 100);
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To apply for a job, please use the Job Vacancies page.");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select an application first.");
                return;
            }

            string appId = listViewApps.SelectedItems[0].Text;
            string currentStatus = listViewApps.SelectedItems[0].SubItems[3].Text;

            if (currentStatus != "draft")
            {
                MessageBox.Show("Cannot submit! Application is already processed.");
                return;
            }

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

                MessageBox.Show("Application Submitted Successfully!");
                LoadMyApplications();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count > 0)
            {
                string status = listViewApps.SelectedItems[0].SubItems[3].Text;
                if (status == "draft" || status == "submitted")
                    MessageBox.Show("You can edit this application.");
                else
                    MessageBox.Show("Cannot edit — HR is already reviewing this application.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count == 0) return;

            string status = listViewApps.SelectedItems[0].SubItems[3].Text;
            string appId = listViewApps.SelectedItems[0].Text;

            if (status != "draft")
            {
                MessageBox.Show("Cannot delete! Application is already submitted.");
                return;
            }

            if (MessageBox.Show("Delete this draft?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM applications WHERE application_id = @ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", appId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Draft deleted.");
                    LoadMyApplications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmJobVacancies jobs = new frmJobVacancies(userEmail);
            jobs.Show();
            this.Hide();
        }
    }
}