using System;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            // Admin only check - Sisiguraduhin na admin lang ang makakapasok
            if (SessionManager.CurrentRole != "admin")
            {
                MessageBox.Show("Access denied. Admins only.");
                this.Close();
                return;
            }

            InitializeComponent();
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            new frmDepartments().ShowDialog();
        }

        private void btnPositions_Click(object sender, EventArgs e)
        {
            new frmPositions().ShowDialog();
        }

        private void btnEmploymentTypes_Click(object sender, EventArgs e)
        {
            new frmEmploymentTypes().ShowDialog();
        }

        private void btnRequirementTypes_Click(object sender, EventArgs e)
        {
            new frmRequirementTypes().ShowDialog();
        }

        private void btnInterviewTypes_Click(object sender, EventArgs e)
        {
            new frmInterviewTypes().ShowDialog();
        }

        private void btnAssessmentTypes_Click(object sender, EventArgs e)
        {
            new frmAssessmentTypes().ShowDialog();
        }

        private void btnJobVacancy_Click(object sender, EventArgs e)
        {
            new frmJobVacancyManagement().ShowDialog();
        }
    }
}
