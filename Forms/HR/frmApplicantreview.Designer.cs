namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRApplicantReview
    {
        private System.ComponentModel.IContainer components = null;

        // Controls for Applicant Review
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstApplicants;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnViewDocuments;
        private System.Windows.Forms.Button btnLockReview;
        private System.Windows.Forms.Button btnNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstApplicants = new System.Windows.Forms.ListBox();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnViewDocuments = new System.Windows.Forms.Button();
            this.btnLockReview = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtSearch.Location = new System.Drawing.Point(97, 141);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(378, 36);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnSearch.Location = new System.Drawing.Point(496, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 52);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            // 
            // lstApplicants
            // 
            this.lstApplicants.Font = new System.Drawing.Font("Verdana", 14F);
            this.lstApplicants.ItemHeight = 28;
            this.lstApplicants.Location = new System.Drawing.Point(45, 268);
            this.lstApplicants.Name = "lstApplicants";
            this.lstApplicants.Size = new System.Drawing.Size(400, 172);
            this.lstApplicants.TabIndex = 2;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnViewProfile.Location = new System.Drawing.Point(1056, 406);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(174, 34);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            // 
            // btnViewDocuments
            // 
            this.btnViewDocuments.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnViewDocuments.Location = new System.Drawing.Point(1056, 446);
            this.btnViewDocuments.Name = "btnViewDocuments";
            this.btnViewDocuments.Size = new System.Drawing.Size(174, 34);
            this.btnViewDocuments.TabIndex = 4;
            this.btnViewDocuments.Text = "View Documents";
            // 
            // btnLockReview
            // 
            this.btnLockReview.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnLockReview.Location = new System.Drawing.Point(1056, 486);
            this.btnLockReview.Name = "btnLockReview";
            this.btnLockReview.Size = new System.Drawing.Size(174, 34);
            this.btnLockReview.TabIndex = 5;
            this.btnLockReview.Text = "Lock Application";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnNext.Location = new System.Drawing.Point(1056, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(174, 34);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next → Screening";
            // 
            // frmHRApplicantReview
            // 
            this.ClientSize = new System.Drawing.Size(1329, 650);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstApplicants);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnViewDocuments);
            this.Controls.Add(this.btnLockReview);
            this.Controls.Add(this.btnNext);
            this.Name = "frmHRApplicantReview";
            this.Text = "Applicant Review";
            this.Load += new System.EventHandler(this.frmHRApplicantReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
