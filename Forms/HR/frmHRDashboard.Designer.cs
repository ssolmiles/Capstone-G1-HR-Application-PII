namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecruitmentSummary;
        private System.Windows.Forms.ListBox lstRecruitmentSummary;
        private System.Windows.Forms.GroupBox grpQuickLinks;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnReports;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRecruitmentSummary = new System.Windows.Forms.Label();
            this.lstRecruitmentSummary = new System.Windows.Forms.ListBox();
            this.grpQuickLinks = new System.Windows.Forms.GroupBox();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.grpQuickLinks.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "HR Dashboard";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);

            // lblRecruitmentSummary
            this.lblRecruitmentSummary.Text = "Recruitment Summary:";
            this.lblRecruitmentSummary.Location = new System.Drawing.Point(20, 70);

            // lstRecruitmentSummary
            this.lstRecruitmentSummary.Location = new System.Drawing.Point(20, 100);
            this.lstRecruitmentSummary.Size = new System.Drawing.Size(300, 150);

            // grpQuickLinks
            this.grpQuickLinks.Text = "Quick Links";
            this.grpQuickLinks.Location = new System.Drawing.Point(350, 70);
            this.grpQuickLinks.Size = new System.Drawing.Size(200, 180);

            // btnApplicants
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.Location = new System.Drawing.Point(20, 30);
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);

            // btnInterviews
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.Location = new System.Drawing.Point(20, 70);
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click);

            // btnReports
            this.btnReports.Text = "Reports";
            this.btnReports.Location = new System.Drawing.Point(20, 110);
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);

            // Add buttons to group
            this.grpQuickLinks.Controls.Add(this.btnApplicants);
            this.grpQuickLinks.Controls.Add(this.btnInterviews);
            this.grpQuickLinks.Controls.Add(this.btnReports);

            // frmHRDashboard
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecruitmentSummary);
            this.Controls.Add(this.lstRecruitmentSummary);
            this.Controls.Add(this.grpQuickLinks);
            this.Text = "HR Dashboard";
            this.grpQuickLinks.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
