namespace HRApplicantSystem.Forms.HR
{
    partial class frmScreening
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstApplicants;
        private System.Windows.Forms.Button btnQualified;
        private System.Windows.Forms.Button btnNotQualified;
        private System.Windows.Forms.Button btnNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstApplicants = new System.Windows.Forms.ListBox();
            this.btnQualified = new System.Windows.Forms.Button();
            this.btnNotQualified = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(315, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicant Screening";
            // 
            // lstApplicants
            // 
            this.lstApplicants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstApplicants.Font = new System.Drawing.Font("Verdana", 10F);
            this.lstApplicants.ItemHeight = 20;
            this.lstApplicants.Location = new System.Drawing.Point(20, 60);
            this.lstApplicants.Name = "lstApplicants";
            this.lstApplicants.Size = new System.Drawing.Size(340, 142);
            this.lstApplicants.TabIndex = 1;
            // 
            // btnQualified
            // 
            this.btnQualified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnQualified.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnQualified.ForeColor = System.Drawing.Color.White;
            this.btnQualified.Location = new System.Drawing.Point(20, 230);
            this.btnQualified.Name = "btnQualified";
            this.btnQualified.Size = new System.Drawing.Size(120, 35);
            this.btnQualified.TabIndex = 2;
            this.btnQualified.Text = "Qualified";
            this.btnQualified.UseVisualStyleBackColor = false;
            // 
            // btnNotQualified
            // 
            this.btnNotQualified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnNotQualified.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnNotQualified.ForeColor = System.Drawing.Color.White;
            this.btnNotQualified.Location = new System.Drawing.Point(146, 230);
            this.btnNotQualified.Name = "btnNotQualified";
            this.btnNotQualified.Size = new System.Drawing.Size(161, 35);
            this.btnNotQualified.TabIndex = 3;
            this.btnNotQualified.Text = "Not Qualified";
            this.btnNotQualified.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnNext.Location = new System.Drawing.Point(247, 282);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 35);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next → Interview Scheduling";
            // 
            // frmScreening
            // 
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstApplicants);
            this.Controls.Add(this.btnQualified);
            this.Controls.Add(this.btnNotQualified);
            this.Controls.Add(this.btnNext);
            this.Name = "frmScreening";
            this.Text = "Applicant Screening";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
