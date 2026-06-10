using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewSchedule : Form
    {
        public frmInterviewSchedule()
        {
            InitializeComponent();
            btnSchedule.Click += btnSchedule_Click;
            btnComplete.Click += btnComplete_Click;
            btnCancel.Click += btnCancel_Click;
            btnNext.Click += btnNext_Click;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            string info = $"Date: {dtpDate.Value.ToShortDateString()}, " +
                          $"Time: {dtpTime.Value.ToShortTimeString()}, " +
                          $"Interviewer: {txtInterviewer.Text}, " +
                          $"Mode: {cmbMode.SelectedItem}, " +
                          $"Location: {txtLocation.Text}";
            lblStatus.Text = "Status: Scheduled";
            MessageBox.Show("Interview scheduled:\n" + info);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Completed";
            MessageBox.Show("Interview marked as completed.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Status: Cancelled";
            MessageBox.Show("Interview cancelled.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmInterviewEvaluation evalForm = new frmInterviewEvaluation();
            evalForm.Show();
            this.Hide();
        }

        private void frmInterviewSchedule_Load(object sender, EventArgs e) { }
    }
}