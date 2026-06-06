using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewScheduling : Form
    {
        public frmInterviewScheduling()
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
            frmEvaluation evalForm = new frmEvaluation();
            evalForm.Show();
            this.Hide(); // optional
        }

        private void btnComplete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
