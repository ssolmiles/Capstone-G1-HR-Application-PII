namespace HRApplicantSystem.Forms.HR
{
    partial class frmApplicantList
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dvgApplicants = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnViewDocuments = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplicants)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgApplicants
            // 
            this.dvgApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgApplicants.Location = new System.Drawing.Point(63, 95);
            this.dvgApplicants.Name = "dvgApplicants";
            this.dvgApplicants.RowHeadersWidth = 51;
            this.dvgApplicants.RowTemplate.Height = 24;
            this.dvgApplicants.Size = new System.Drawing.Size(191, 133);
            this.dvgApplicants.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(349, 108);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(632, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(140, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(632, 151);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 35);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(632, 198);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(140, 35);
            this.btnViewProfile.TabIndex = 4;
            this.btnViewProfile.Text = "btnViewProfile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            // 
            // btnViewDocuments
            // 
            this.btnViewDocuments.Location = new System.Drawing.Point(632, 237);
            this.btnViewDocuments.Name = "btnViewDocuments";
            this.btnViewDocuments.Size = new System.Drawing.Size(140, 35);
            this.btnViewDocuments.TabIndex = 5;
            this.btnViewDocuments.Text = "btnViewDocuments";
            this.btnViewDocuments.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(632, 278);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 35);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(318, 170);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(55, 16);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "lblCount";
            // 
            // frmApplicantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 615);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewDocuments);
            this.Controls.Add(this.btnViewProfile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dvgApplicants);
            this.Name = "frmApplicantList";
            this.Text = "btnViewDocuments";
            this.Load += new System.EventHandler(this.frmApplicantList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgApplicants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dvgApplicants;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnViewDocuments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCount;
    }
}