using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmMyApplication : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string userEmail;
        public frmMyApplication(string email)
        {
            InitializeComponent();
            userEmail = email;
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }
        private void frmMyApplications_Load(object sender, EventArgs e)
        {
            LoadMyApplications();
        }
        private void LoadMyApplications()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT a.ApplicationID, j.Title, a.Status, a.Application_Date FROM Applications a INNER JOIN JobVacancies j ON 
                                    a.JobID = j.JobID WHERE a.Email = @Email ORDER BY a.Application_Date DESC";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
                listViewApps.Items.Clear();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ApplicationID"].ToString());
                    item.SubItems.Add(dr["Title"].ToString());
                    item.SubItems.Add(dr["Status"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(dr["Application_Date"]).ToString("MM/dd/yyyy"));

                    if (dr["Status"].ToString() == "Pending")
                        item.ForeColor = System.Drawing.Color.Orange;
                    else if (dr["Status"].ToString() == "Approved")
                        item.ForeColor = System.Drawing.Color.Green;
                    else if (dr["Status"].ToString() == "Rejected")
                        item.ForeColor = System.Drawing.Color.Red;
                    listViewApps.Items.Add(item);
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

        private void btnSaveDraft_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count > 0)
            {
                string jobId = listViewApps.SelectedItems[0].Text;
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = "SELECT COUNT (*) FROM Applications WHERE Email = @Email AND JobID = @JobID";
                    cmd.Parameters.AddWithValue("@Email", userEmail);
                    cmd.Parameters.AddWithValue("@JobID", jobId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Application already exists!");
                        return;
                    }
                    cmd.CommandText = "INSERT INTO Applications (Email, JobID, Status, Application_Date) VALUES (@Email, @JobID, 'Draft', GETDATE())";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved as Draft!");
                    LoadMyApplications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    cmd.Parameters.Clear();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count > 0)
            {
                string appId = listViewApps.SelectedItems[0].Text;
                string currentStatus = "";
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Status FROM Applications WHERE ApplicationID = @ID";
                cmd.Parameters.AddWithValue("@ID", appId);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    currentStatus = dr["Status"].ToString();
                }
                dr.Close();
                if (currentStatus != "Draft" && currentStatus != "Pending")
                {
                    MessageBox.Show("Cannot edit or submit! Application is already processed.");
                    return;
                }
                try
                {
                    conn.Open();
                    cmd.CommandText = "UPDATE Applications SET Status = 'Submitted' WHERE ApplicationID = @ID";
                    cmd.Parameters.AddWithValue("@ID", appId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Application Submitted Successfully!");
                    LoadMyApplications();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    cmd.Parameters.Clear();
                }
            }
            else
            {
                MessageBox.Show("Select an application first.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count > 0)
            {
                string status = listViewApps.SelectedItems[0].SubItems[2].Text;
                if (status == "Draft" || status == "Pending")
                {
                    MessageBox.Show("You can edit this application.");
                }
                else
                {
                    MessageBox.Show("Cannot edit! Already reviewed by HR.");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewApps.SelectedItems.Count > 0)
            {
                string status = listViewApps.SelectedItems[0].SubItems[2].Text;
                if (status == "Draft")
                {
                    DialogResult res = MessageBox.Show("Delete this draft?", "Confirm", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        MessageBox.Show("Draft deleted.");
                        LoadMyApplications();
                    }
                }
                else
                {
                    MessageBox.Show("Cannot delete! Application is already submitted.");
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
