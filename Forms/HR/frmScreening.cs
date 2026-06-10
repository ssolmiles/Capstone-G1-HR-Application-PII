using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        public frmScreening()
        {
            InitializeComponent();

            btnQualified.Click += btnQualified_Click;
            btnNotQualified.Click += btnNotQualified_Click;
            btnNext.Click += btnNext_Click;
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
            frmInterviewScheduling interviewForm = new frmInterviewScheduling();
            interviewForm.Show();
            this.Hide(); 
        }
    }
}
