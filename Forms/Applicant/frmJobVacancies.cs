using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmJobVacancies : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string userEmail;

        public frmJobVacancies(string email)
        {
            InitializeComponent();
            userEmail = email;

            string connString =
                "Server=g1-hr-processing-server.database.windows.net;" +
                "Database=HR_Applicant_Processing_System;" +
                "User ID=hradmin;" +
                "Password=@Ssolshine2006;";

            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }

        private void frmJobVacancies_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadJobList();
        }

        private void SetupListView()
        {
            listViewJobs.Columns.Clear();
            listViewJobs.Columns.Add("Job ID", 80);
            listViewJobs.Columns.Add("Title", 150);
            listViewJobs.Columns.Add("Department", 120);
            listViewJobs.Columns.Add("Location", 100);
            listViewJobs.Columns.Add("Salary", 120);
        }

        private void LoadJobList(string searchText = "")
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;

                string query =
                    "SELECT JobID, Title, Department, Location, Salary_Range " +
                    "FROM JobVacancies WHERE Status = 'Open'";

                if (!string.IsNullOrEmpty(searchText))
                {
                    query += " AND (Title LIKE @Search OR Department LIKE @Search)";
                    cmd.Parameters.AddWithValue("@Search", "%" + searchText + "%");
                }

                cmd.CommandText = query;
                dr = cmd.ExecuteReader();

                listViewJobs.Items.Clear();

                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["JobID"].ToString());
                    item.SubItems.Add(dr["Title"].ToString());
                    item.SubItems.Add(dr["Department"].ToString());
                    item.SubItems.Add(dr["Location"].ToString());
                    item.SubItems.Add(dr["Salary_Range"].ToString());
                    listViewJobs.Items.Add(item);
                }

                dr.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

            string jobId = listViewJobs.SelectedItems[0].Text;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM JobVacancies WHERE JobID = @ID";
                cmd.Parameters.AddWithValue("@ID", jobId);

                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    string details =
                        $"Title: {dr["Title"]}\n" +
                        $"Department: {dr["Department"]}\n" +
                        $"Location: {dr["Location"]}\n" +
                        $"Salary: {dr["Salary_Range"]}\n\n" +
                        $"Requirements:\n{dr["Requirements"]}\n\n" +
                        $"Responsibilities:\n{dr["Responsibilities"]}";

                    MessageBox.Show(details, "Job Details");
                }

                dr.Close();
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (listViewJobs.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a job to apply.");
                return;
            }

            string jobId = listViewJobs.SelectedItems[0].Text;
            string jobTitle = listViewJobs.SelectedItems[0].SubItems[1].Text;

            if (MessageBox.Show($"Apply for {jobTitle}?", "Confirm",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            try
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText =
                    "SELECT COUNT(*) FROM Applications WHERE Email=@Email AND JobID=@JobID";

                cmd.Parameters.AddWithValue("@Email", userEmail);
                cmd.Parameters.AddWithValue("@JobID", jobId);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("You already applied for this job.");
                    return;
                }

                cmd.CommandText =
                    "INSERT INTO Applications (Email, JobID, Application_Date, Status) " +
                    "VALUES (@Email, @JobID, GETDATE(), 'Pending')";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Application submitted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
                conn.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmApplicantDashboard dash = new frmApplicantDashboard(userEmail);
            dash.Show();
            this.Hide();
        }

        private void listViewJobs_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}