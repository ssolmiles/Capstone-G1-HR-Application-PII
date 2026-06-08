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
using Microsoft.Data.SqlClient;

namespace HRApplicantSystem.Forms.Applicant
{
    public partial class frmApplicationStatus : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        string userEmail;
        public frmApplicationStatus(string email)
        {
            InitializeComponent();
            userEmail = email;
            string connString = "Server=g1-hr-processing-server.database.windows.net;Database=HR_Applicant_Processing_System;User ID=hradmin;Password=@Ssolshine2006;";
            conn = new SqlConnection(connString);
            cmd = new SqlCommand();
        }
        private void frmApplicationStatus_Load(object sender, EventArgs e)
        {
            LoadStatusDetails();
        }
        private void LoadStatusDetails()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT Status, HR_Remarks, Interview_Date, Interview_Time, Interview_Location, Final_Result
                                    FROM ApplicantRegister WHERE Email = @Email";
                cmd.Parameters.AddWithValue("@Email", userEmail);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    // 1. CURRENT STATUS
                    string currentStatus = dr["Status"].ToString();
                    lblCurrentStatus.Text = "Current Status: " + currentStatus;
                    if (currentStatus == "Pending")
                    {
                        lblStep1.BackColor = System.Drawing.Color.Green;
                        lblStep2.BackColor = System.Drawing.Color.Gray;
                        lblStep3.BackColor = System.Drawing.Color.Gray;
                        lblStep4.BackColor = System.Drawing.Color.Gray;
                    }
                    else if (currentStatus == "Under Review")
                    {
                        lblStep1.BackColor = System.Drawing.Color.Green;
                        lblStep2.BackColor = System.Drawing.Color.Orange;
                        lblStep3.BackColor = System.Drawing.Color.Gray;
                        lblStep4.BackColor = System.Drawing.Color.Gray;
                    }
                    else if (currentStatus == "Scheduled")
                    {
                        lblStep1.BackColor = System.Drawing.Color.Green;
                        lblStep2.BackColor = System.Drawing.Color.Green;
                        lblStep3.BackColor = System.Drawing.Color.Orange;
                        lblStep4.BackColor = System.Drawing.Color.Gray;
                    }
                    else if (currentStatus == "Approved" || currentStatus == "Rejected")
                    {
                        lblStep1.BackColor = System.Drawing.Color.Green;
                        lblStep2.BackColor = System.Drawing.Color.Green;
                        lblStep3.BackColor = System.Drawing.Color.Green;
                        lblStep4.BackColor = System.Drawing.Color.Blue;
                    }
                    // 2. HR REMARKS
                    string remarks = dr["HR_Remarks"].ToString();
                    if (string.IsNullOrEmpty(remarks))
                        lblRemarks.Text = "Remarks: No remarks yet.";
                    else
                        lblRemarks.Text = "Remarks: " + remarks;
                    // 3. INTERVIEW SCHEDULE DETAILS
                    if (dr["Interview_Date"] != DBNull.Value)
                    {
                        DateTime date = Convert.ToDateTime(dr["Interview_Date"]);
                        string time = dr["Interview_Time"].ToString();
                        string venue = dr["Interview_Location"].ToString();
                        lblSchedule.Text = $"Schedule: {date:MMMM dd, yyyy}\n Time: {time}\n Where: {venue}";
                    }
                    else
                    {
                        lblSchedule.Text = "Schedule: Not yet scheduled";
                    }
                    // 4. FINAL RESULT
                    string result = dr["Final_Result"].ToString();
                    if (string.IsNullOrEmpty(result) || result == "Pending")
                    {
                        lblResult.Text = "Final Result: PENDING";
                        lblResult.ForeColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        lblResult.Text = "Final Result: " + result.ToUpper();
                        if (result.ToLower() == "passed" || result.ToLower() == "approved")
                            lblResult.ForeColor = System.Drawing.Color.Green;
                        else
                            lblResult.ForeColor = System.Drawing.Color.Red;
                    }
                }
                dr.Close();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
