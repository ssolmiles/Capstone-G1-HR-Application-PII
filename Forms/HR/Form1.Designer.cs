namespace HRApplicantSystem.Forms.HR
{
    partial class frmScreening
    {
        private System.ComponentModel.IContainer components = null;

        // Controls for Screening
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnQualified;
        private System.Windows.Forms.Button btnNotQualified;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnNext;

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
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnQualified = new System.Windows.Forms.Button();
            this.btnNotQualified = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(20, 65);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(300, 41);
            this.txtRemarks.TabIndex = 0;
            // 
            // btnQualified
            // 
            this.btnQualified.Location = new System.Drawing.Point(23, 131);
            this.btnQualified.Name = "btnQualified";
            this.btnQualified.Size = new System.Drawing.Size(94, 23);
            this.btnQualified.TabIndex = 1;
            this.btnQualified.Text = "Qualified";
            // 
            // btnNotQualified
            // 
            this.btnNotQualified.Location = new System.Drawing.Point(141, 131);
            this.btnNotQualified.Name = "btnNotQualified";
            this.btnNotQualified.Size = new System.Drawing.Size(119, 23);
            this.btnNotQualified.TabIndex = 2;
            this.btnNotQualified.Text = "Not Qualified";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(17, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Pending";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(461, 227);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next → Interview Scheduling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnQualified);
            this.Controls.Add(this.btnNotQualified);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Screening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
