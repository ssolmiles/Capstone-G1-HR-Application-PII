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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstApplicants = new System.Windows.Forms.ListBox();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnViewDocuments = new System.Windows.Forms.Button();
            this.btnLockReview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(280, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            // 
            // lstApplicants
            // 
            this.lstApplicants.ItemHeight = 16;
            this.lstApplicants.Location = new System.Drawing.Point(20, 60);
            this.lstApplicants.Name = "lstApplicants";
            this.lstApplicants.Size = new System.Drawing.Size(400, 196);
            this.lstApplicants.TabIndex = 2;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(450, 60);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(126, 23);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            // 
            // btnViewDocuments
            // 
            this.btnViewDocuments.Location = new System.Drawing.Point(450, 100);
            this.btnViewDocuments.Name = "btnViewDocuments";
            this.btnViewDocuments.Size = new System.Drawing.Size(126, 23);
            this.btnViewDocuments.TabIndex = 4;
            this.btnViewDocuments.Text = "View Documents";
            // 
            // btnLockReview
            // 
            this.btnLockReview.Location = new System.Drawing.Point(450, 140);
            this.btnLockReview.Name = "btnLockReview";
            this.btnLockReview.Size = new System.Drawing.Size(126, 23);
            this.btnLockReview.TabIndex = 5;
            this.btnLockReview.Text = "Lock Application";
            // 
            // frmHRApplicantReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lstApplicants);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnViewDocuments);
            this.Controls.Add(this.btnLockReview);
            this.Name = "frmHRApplicantReview";
            this.Text = "Applicant Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
