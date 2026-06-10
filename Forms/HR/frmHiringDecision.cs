using System;
using System.Windows.Forms;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHiringDecision : Form
    {
        public frmHiringDecision()
        {
            InitializeComponent();

            // ✅ Button events are safe to wire here
            btnHire.Click += btnHire_Click;
            btnReject.Click += btnReject_Click;
            btnSave.Click += btnSave_Click;
        }

        // ✅ ONE Load method ONLY
        private void frmHiringDecision_Load(object sender, EventArgs e)
        {
            string role = SessionManager.CurrentRole;

            if (role != "admin" && role != "hr_manager")
            {
                MessageBox.Show(
                    "Access denied. This screen is for HR Manager and Admin only.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                this.Close();
                return;
            }

            // put any other load logic here
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            lblDecision.Text = "Final Decision: Hire";
            lblStatus.Text = "Status: Approved";

            MessageBox.Show(
                "Applicant Hired.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            lblDecision.Text = "Final Decision: Reject";
            lblStatus.Text = "Status: Rejected";

            MessageBox.Show(
                "Applicant Rejected.\nRemarks: " + txtFinalRemarks.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string summary =
                $"Decision: {lblDecision.Text}\n" +
                $"Status: {lblStatus.Text}\n" +
                $"Remarks: {txtFinalRemarks.Text}";

            MessageBox.Show(
                "Final decision saved:\n" + summary);
        }

        private void txtFinalRemarks_TextChanged(object sender, EventArgs e)
        {
        }
    }
}