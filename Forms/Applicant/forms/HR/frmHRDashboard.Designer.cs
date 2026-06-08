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
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HR Dashboard";
            // 
            // lblRecruitmentSummary
            // 
            this.lblRecruitmentSummary.Location = new System.Drawing.Point(20, 70);
            this.lblRecruitmentSummary.Name = "lblRecruitmentSummary";
            this.lblRecruitmentSummary.Size = new System.Drawing.Size(100, 23);
            this.lblRecruitmentSummary.TabIndex = 1;
            this.lblRecruitmentSummary.Text = "Recruitment Summary:";
            // 
            // lstRecruitmentSummary
            // 
            this.lstRecruitmentSummary.ItemHeight = 16;
            this.lstRecruitmentSummary.Location = new System.Drawing.Point(20, 100);
            this.lstRecruitmentSummary.Name = "lstRecruitmentSummary";
            this.lstRecruitmentSummary.Size = new System.Drawing.Size(300, 148);
            this.lstRecruitmentSummary.TabIndex = 2;
            // 
            // grpQuickLinks
            // 
            this.grpQuickLinks.Controls.Add(this.btnApplicants);
            this.grpQuickLinks.Controls.Add(this.btnInterviews);
            this.grpQuickLinks.Controls.Add(this.btnReports);
            this.grpQuickLinks.Location = new System.Drawing.Point(350, 70);
            this.grpQuickLinks.Name = "grpQuickLinks";
            this.grpQuickLinks.Size = new System.Drawing.Size(200, 180);
            this.grpQuickLinks.TabIndex = 3;
            this.grpQuickLinks.TabStop = false;
            this.grpQuickLinks.Text = "Quick Links";
            // 
            // btnApplicants
            // 
            this.btnApplicants.Location = new System.Drawing.Point(20, 30);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(75, 23);
            this.btnApplicants.TabIndex = 0;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // btnInterviews
            // 
            this.btnInterviews.Location = new System.Drawing.Point(20, 70);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 23);
            this.btnInterviews.TabIndex = 1;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(20, 110);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 23);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // frmHRDashboard
            // 
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRecruitmentSummary);
            this.Controls.Add(this.lstRecruitmentSummary);
            this.Controls.Add(this.grpQuickLinks);
            this.Name = "frmHRDashboard";
            this.Text = "HR Dashboard";
            this.grpQuickLinks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
