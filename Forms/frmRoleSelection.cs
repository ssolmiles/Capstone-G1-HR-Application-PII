using System;
using System.Windows.Forms;
using HRApplicantSystem.Forms.Applicant;
using HRApplicantSystem.Forms.HR;

namespace HRApplicantSystem.Forms
{
    public partial class frmRoleSelection : Form
    {
        public frmRoleSelection()
        {
            InitializeComponent();
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            new frmApplicantLogin().Show();
            this.Hide();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            new frmHRLogin().Show();
            this.Hide();
        }

        private void frmRoleSelection_Load(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }
    }
}