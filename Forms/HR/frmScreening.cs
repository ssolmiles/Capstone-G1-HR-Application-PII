using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        public frmScreening()
        {
            InitializeComponent();
        }

        private void btnQualified_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Qualified";
            MessageBox.Show("Applicant marked Qualified.\nRemarks: " + txtRemarks.Text);
        }

        private void btnNotQualified_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Not Qualified";
            MessageBox.Show("Applicant marked Not Qualified.\nRemarks: " + txtRemarks.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmInterviewSchedule interviewForm = new frmInterviewSchedule();
            interviewForm.Show();
            this.Hide();
        }

        private void frmScreening_Load(object sender, EventArgs e) { }
    }
}