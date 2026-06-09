using System;
using System.Windows.Forms;
using HRApplicantSystem.Helpers;
namespace HRApplicantSystem.Forms.HR
{
    public partial class frmApplicantReview : Form
    {
        public frmApplicantReview()
        {
            InitializeComponent();

            // Wire up events
            btnSearch.Click += btnSearch_Click;
            btnViewProfile.Click += btnViewProfile_Click;
            btnViewDocuments.Click += btnViewDocuments_Click;
            btnLockReview.Click += btnLockReview_Click;
            btnNext.Click += btnNext_Click;   // ✅ added Next button event
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Example: filter applicants based on search text
            string query = txtSearch.Text.Trim();
            MessageBox.Show("Searching applicants for: " + query);
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            if (lstApplicants.SelectedItem != null)
                MessageBox.Show("Viewing profile of: " + lstApplicants.SelectedItem.ToString());
            else
                MessageBox.Show("Please select an applicant first.");
        }

        private void btnViewDocuments_Click(object sender, EventArgs e)
        {
            if (lstApplicants.SelectedItem != null)
                MessageBox.Show("Viewing documents of: " + lstApplicants.SelectedItem.ToString());
            else
                MessageBox.Show("Please select an applicant first.");
        }

        private void btnLockReview_Click(object sender, EventArgs e)
        {
            if (lstApplicants.SelectedItem != null)
                MessageBox.Show("Application locked for: " + lstApplicants.SelectedItem.ToString());
            else
                MessageBox.Show("Please select an applicant first.");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmScreening screeningForm = new frmScreening();
            screeningForm.Show();
            this.Hide();
        }

        private void frmHRApplicantReview_Load(object sender, EventArgs e)
        {

        }
    }
}
