using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmEvaluation : Form
    {
        public frmEvaluation()
        {
            InitializeComponent();

            btnPass.Click += btnPass_Click;
            btnFail.Click += btnFail_Click;
            btnSave.Click += btnSave_Click;
            btnNext.Click += btnNext_Click;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result: Pass";
            MessageBox.Show("Applicant marked as PASS.\nScore: " + txtScore.Text + "\nRemarks: " + txtRemarks.Text);
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Result: Fail";
            MessageBox.Show("Applicant marked as FAIL.\nScore: " + txtScore.Text + "\nRemarks: " + txtRemarks.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string summary = $"Score: {txtScore.Text}\nRemarks: {txtRemarks.Text}\nResult: {lblResult.Text}\nRecommendation: {txtRecommendation.Text}";
            MessageBox.Show("Evaluation saved:\n" + summary);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmFinalDecision finalForm = new frmFinalDecision();
            finalForm.Show();
            this.Hide(); // optional
        }
    }
}
