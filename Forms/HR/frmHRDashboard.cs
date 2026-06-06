using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRDashboard : Form
    {
        public frmHRDashboard()
        {
            InitializeComponent();
            LoadRecruitmentSummary();
        }

        private void LoadRecruitmentSummary()
        {
            lstRecruitmentSummary.Items.Clear();
            lstRecruitmentSummary.Items.Add("Applicants Submitted: 25");
            lstRecruitmentSummary.Items.Add("Pending Applications: 8");
            lstRecruitmentSummary.Items.Add("Interviews Scheduled: 5");
            lstRecruitmentSummary.Items.Add("Accepted: 2 | Rejected: 3");
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Applicants Module.");
        }

        private void btnInterviews_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Interviews Module.");
        }

             private void btnReports_Click(object sender, EventArgs e)
        {
            frmHRReports reportsForm = new frmHRReports();
            reportsForm.Show();
        }
    }
}
