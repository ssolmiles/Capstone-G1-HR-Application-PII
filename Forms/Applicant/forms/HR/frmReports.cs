using System;
using System.Windows.Forms;
using HRApplicantSystem.Helpers;
namespace HRApplicantSystem.Forms.HR
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();

            btnGenerateReport.Click += btnGenerateReport_Click;
            btnNext.Click += btnNext_Click;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            lstReports.Items.Add("Report generated at " + DateTime.Now);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmHRDashboard dashboard = new frmHRDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
