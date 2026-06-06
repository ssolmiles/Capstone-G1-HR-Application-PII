using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmFinalDecision : Form
    {
        public frmFinalDecision()
        {
            InitializeComponent();

            btnHire.Click += btnHire_Click;
            btnReject.Click += btnReject_Click;
            btnSave.Click += btnSave_Click;
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            lblDecision.Text = "Final Decision: Hire";
            lblStatus.Text = "Status: Approved";
            MessageBox.Show("Applicant Hired.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            lblDecision.Text = "Final Decision: Reject";
            lblStatus.Text = "Status: Rejected";
            MessageBox.Show("Applicant Rejected.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string summary = $"Decision: {lblDecision.Text}\nStatus: {lblStatus.Text}\nRemarks: {txtFinalRemarks.Text}";
            MessageBox.Show("Final decision saved:\n" + summary);
        }
    }
}
