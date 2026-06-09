namespace HRApplicantSystem.Forms.HR
{
    partial class frmScreening
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.btnQualified = new System.Windows.Forms.Button();
            this.btnNotQualified = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnQualified
            // 
            this.btnQualified.Location = new System.Drawing.Point(50, 200);
            this.btnQualified.Name = "btnQualified";
            this.btnQualified.Size = new System.Drawing.Size(120, 35);
            this.btnQualified.TabIndex = 0;
            this.btnQualified.Text = "Qualified";
            // 
            // btnNotQualified
            // 
            this.btnNotQualified.Location = new System.Drawing.Point(200, 200);
            this.btnNotQualified.Name = "btnNotQualified";
            this.btnNotQualified.Size = new System.Drawing.Size(120, 35);
            this.btnNotQualified.TabIndex = 1;
            this.btnNotQualified.Text = "Not Qualified";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(350, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 35);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next →";
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(50, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(300, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: Pending";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(50, 50);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(500, 80);
            this.txtRemarks.TabIndex = 4;
            // 
            // frmScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQualified);
            this.Controls.Add(this.btnNotQualified);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtRemarks);
            this.Name = "frmScreening";
            this.Text = "Screening";
            this.Load += new System.EventHandler(this.frmScreening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnQualified;
        private System.Windows.Forms.Button btnNotQualified;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtRemarks;
    }
}