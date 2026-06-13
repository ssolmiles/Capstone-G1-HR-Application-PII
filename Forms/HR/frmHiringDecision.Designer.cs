namespace HRApplicantSystem.Forms.HR
{
    partial class frmHiringDecision
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblAccessNotice;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNameCaption;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblJobTitleCaption;
        private System.Windows.Forms.Label lblJobApplied;
        private System.Windows.Forms.Label lblScoreCaption;
        private System.Windows.Forms.Label lblInterviewScore;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnReject;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblRemarksCaption;
        private System.Windows.Forms.TextBox txtFinalRemarks;

        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblAccessNotice = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNameCaption = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblJobTitleCaption = new System.Windows.Forms.Label();
            this.lblJobApplied = new System.Windows.Forms.Label();
            this.lblScoreCaption = new System.Windows.Forms.Label();
            this.lblInterviewScore = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDecision = new System.Windows.Forms.Label();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRemarksCaption = new System.Windows.Forms.Label();
            this.txtFinalRemarks = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPassed = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Final Hiring Decision";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(37, 54);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(296, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Confirm the final outcome of this application";
            // 
            // lblAccessNotice
            // 
            this.lblAccessNotice.AutoSize = true;
            this.lblAccessNotice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblAccessNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblAccessNotice.Location = new System.Drawing.Point(37, 78);
            this.lblAccessNotice.Name = "lblAccessNotice";
            this.lblAccessNotice.Size = new System.Drawing.Size(243, 20);
            this.lblAccessNotice.TabIndex = 2;
            this.lblAccessNotice.Text = "Access: Admin and HR Manager only";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNameCaption);
            this.groupBox1.Controls.Add(this.lblApplicantName);
            this.groupBox1.Controls.Add(this.lblJobTitleCaption);
            this.groupBox1.Controls.Add(this.lblJobApplied);
            this.groupBox1.Controls.Add(this.lblScoreCaption);
            this.groupBox1.Controls.Add(this.lblInterviewScore);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(35, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applicant Summary";
            // 
            // lblNameCaption
            // 
            this.lblNameCaption.AutoSize = true;
            this.lblNameCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblNameCaption.Location = new System.Drawing.Point(20, 35);
            this.lblNameCaption.Name = "lblNameCaption";
            this.lblNameCaption.Size = new System.Drawing.Size(60, 23);
            this.lblNameCaption.TabIndex = 0;
            this.lblNameCaption.Text = "Name:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicantName.Location = new System.Drawing.Point(20, 58);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(102, 23);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "(Loading...)";
            // 
            // lblJobTitleCaption
            // 
            this.lblJobTitleCaption.AutoSize = true;
            this.lblJobTitleCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJobTitleCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblJobTitleCaption.Location = new System.Drawing.Point(20, 85);
            this.lblJobTitleCaption.Name = "lblJobTitleCaption";
            this.lblJobTitleCaption.Size = new System.Drawing.Size(103, 23);
            this.lblJobTitleCaption.TabIndex = 2;
            this.lblJobTitleCaption.Text = "Job Applied:";
            // 
            // lblJobApplied
            // 
            this.lblJobApplied.AutoSize = true;
            this.lblJobApplied.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJobApplied.Location = new System.Drawing.Point(20, 108);
            this.lblJobApplied.Name = "lblJobApplied";
            this.lblJobApplied.Size = new System.Drawing.Size(102, 23);
            this.lblJobApplied.TabIndex = 3;
            this.lblJobApplied.Text = "(Loading...)";
            // 
            // lblScoreCaption
            // 
            this.lblScoreCaption.AutoSize = true;
            this.lblScoreCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblScoreCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblScoreCaption.Location = new System.Drawing.Point(20, 135);
            this.lblScoreCaption.Name = "lblScoreCaption";
            this.lblScoreCaption.Size = new System.Drawing.Size(130, 23);
            this.lblScoreCaption.TabIndex = 4;
            this.lblScoreCaption.Text = "Interview Score:";
            // 
            // lblInterviewScore
            // 
            this.lblInterviewScore.AutoSize = true;
            this.lblInterviewScore.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblInterviewScore.Location = new System.Drawing.Point(20, 158);
            this.lblInterviewScore.Name = "lblInterviewScore";
            this.lblInterviewScore.Size = new System.Drawing.Size(102, 23);
            this.lblInterviewScore.TabIndex = 5;
            this.lblInterviewScore.Text = "(Loading...)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatus);
            this.groupBox2.Controls.Add(this.lblDecision);
            this.groupBox2.Controls.Add(this.btnHire);
            this.groupBox2.Controls.Add(this.btnReject);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(355, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decision";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(20, 55);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status: Pending";
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDecision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblDecision.Location = new System.Drawing.Point(20, 30);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(195, 23);
            this.lblDecision.TabIndex = 0;
            this.lblDecision.Text = "Final Decision: Pending";
            // 
            // btnHire
            // 
            this.btnHire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(122)))), ((int)(((byte)(60)))));
            this.btnHire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHire.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHire.ForeColor = System.Drawing.Color.White;
            this.btnHire.Location = new System.Drawing.Point(20, 90);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(260, 35);
            this.btnHire.TabIndex = 2;
            this.btnHire.Text = "Accept Applicant";
            this.btnHire.UseVisualStyleBackColor = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReject.ForeColor = System.Drawing.Color.White;
            this.btnReject.Location = new System.Drawing.Point(20, 132);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(260, 35);
            this.btnReject.TabIndex = 3;
            this.btnReject.Text = "Reject Applicant";
            this.btnReject.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRemarksCaption);
            this.groupBox3.Controls.Add(this.txtFinalRemarks);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(675, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 180);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Remarks";
            // 
            // lblRemarksCaption
            // 
            this.lblRemarksCaption.AutoSize = true;
            this.lblRemarksCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRemarksCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRemarksCaption.Location = new System.Drawing.Point(20, 30);
            this.lblRemarksCaption.Name = "lblRemarksCaption";
            this.lblRemarksCaption.Size = new System.Drawing.Size(78, 23);
            this.lblRemarksCaption.TabIndex = 0;
            this.lblRemarksCaption.Text = "Remarks:";
            // 
            // txtFinalRemarks
            // 
            this.txtFinalRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinalRemarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFinalRemarks.Location = new System.Drawing.Point(20, 55);
            this.txtFinalRemarks.Multiline = true;
            this.txtFinalRemarks.Name = "txtFinalRemarks";
            this.txtFinalRemarks.Size = new System.Drawing.Size(260, 110);
            this.txtFinalRemarks.TabIndex = 1;
            this.txtFinalRemarks.TextChanged += new System.EventHandler(this.txtFinalRemarks_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(355, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Decision";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgvPassed
            // 
            this.dgvPassed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassed.Location = new System.Drawing.Point(1031, 78);
            this.dgvPassed.Name = "dgvPassed";
            this.dgvPassed.RowHeadersWidth = 51;
            this.dgvPassed.RowTemplate.Height = 24;
            this.dgvPassed.Size = new System.Drawing.Size(430, 231);
            this.dgvPassed.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(717, 377);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(300, 40);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // frmHiringDecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvPassed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblAccessNotice);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSave);
            this.Name = "frmHiringDecision";
            this.Text = "Final Hiring Decision";
            this.Load += new System.EventHandler(this.frmHiringDecision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvPassed;
        private System.Windows.Forms.Button btnBack;
    }
}