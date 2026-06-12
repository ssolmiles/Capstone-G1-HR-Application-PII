namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmMyDocuments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResumeStatus = new System.Windows.Forms.Label();
            this.lblIDStatus = new System.Windows.Forms.Label();
            this.lblTranscriptStatus = new System.Windows.Forms.Label();
            this.lblCertStatus = new System.Windows.Forms.Label();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnUploadResume = new System.Windows.Forms.Button();
            this.btnUploadID = new System.Windows.Forms.Button();
            this.btnUploadTranscipt = new System.Windows.Forms.Button();
            this.btnUploadCerts = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblRowResume = new System.Windows.Forms.Label();
            this.lblRowID = new System.Windows.Forms.Label();
            this.lblRowTranscript = new System.Windows.Forms.Label();
            this.lblRowCert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResumeStatus
            // 
            this.lblResumeStatus.AutoSize = true;
            this.lblResumeStatus.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblResumeStatus.Location = new System.Drawing.Point(446, 88);
            this.lblResumeStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResumeStatus.Name = "lblResumeStatus";
            this.lblResumeStatus.Size = new System.Drawing.Size(192, 29);
            this.lblResumeStatus.TabIndex = 0;
            this.lblResumeStatus.Text = "Resume Status";
            // 
            // lblIDStatus
            // 
            this.lblIDStatus.AutoSize = true;
            this.lblIDStatus.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDStatus.Location = new System.Drawing.Point(505, 144);
            this.lblIDStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDStatus.Name = "lblIDStatus";
            this.lblIDStatus.Size = new System.Drawing.Size(133, 28);
            this.lblIDStatus.TabIndex = 1;
            this.lblIDStatus.Text = "ID Status";
            this.lblIDStatus.Click += new System.EventHandler(this.lblIDStatus_Click);
            // 
            // lblTranscriptStatus
            // 
            this.lblTranscriptStatus.AutoSize = true;
            this.lblTranscriptStatus.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblTranscriptStatus.Location = new System.Drawing.Point(423, 204);
            this.lblTranscriptStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTranscriptStatus.Name = "lblTranscriptStatus";
            this.lblTranscriptStatus.Size = new System.Drawing.Size(215, 29);
            this.lblTranscriptStatus.TabIndex = 2;
            this.lblTranscriptStatus.Text = "Transcript Status";
            // 
            // lblCertStatus
            // 
            this.lblCertStatus.AutoSize = true;
            this.lblCertStatus.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblCertStatus.Location = new System.Drawing.Point(408, 248);
            this.lblCertStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCertStatus.Name = "lblCertStatus";
            this.lblCertStatus.Size = new System.Drawing.Size(230, 29);
            this.lblCertStatus.TabIndex = 3;
            this.lblCertStatus.Text = "Certificates Status";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.Location = new System.Drawing.Point(25, 380);
            this.lblOverallStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(203, 29);
            this.lblOverallStatus.TabIndex = 4;
            this.lblOverallStatus.Text = "Overall Status";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.SystemColors.Control;
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtRemarks.Location = new System.Drawing.Point(25, 460);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(984, 50);
            this.txtRemarks.TabIndex = 5;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.lblRemarks.Location = new System.Drawing.Point(25, 430);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(150, 25);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "HR Remarks";
            // 
            // btnUploadResume
            // 
            this.btnUploadResume.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnUploadResume.Location = new System.Drawing.Point(673, 76);
            this.btnUploadResume.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(154, 41);
            this.btnUploadResume.TabIndex = 7;
            this.btnUploadResume.Text = "Upload Resume";
            this.btnUploadResume.UseVisualStyleBackColor = true;
            this.btnUploadResume.Click += new System.EventHandler(this.btnUploadResume_Click);
            // 
            // btnUploadID
            // 
            this.btnUploadID.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnUploadID.Location = new System.Drawing.Point(671, 136);
            this.btnUploadID.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(154, 43);
            this.btnUploadID.TabIndex = 8;
            this.btnUploadID.Text = "Upload ID";
            this.btnUploadID.UseVisualStyleBackColor = true;
            this.btnUploadID.Click += new System.EventHandler(this.btnUploadID_Click);
            // 
            // btnUploadTranscipt
            // 
            this.btnUploadTranscipt.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnUploadTranscipt.Location = new System.Drawing.Point(671, 199);
            this.btnUploadTranscipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadTranscipt.Name = "btnUploadTranscipt";
            this.btnUploadTranscipt.Size = new System.Drawing.Size(156, 39);
            this.btnUploadTranscipt.TabIndex = 9;
            this.btnUploadTranscipt.Text = "Upload Transcript";
            this.btnUploadTranscipt.UseVisualStyleBackColor = true;
            this.btnUploadTranscipt.Click += new System.EventHandler(this.btnUploadTranscipt_Click);
            // 
            // btnUploadCerts
            // 
            this.btnUploadCerts.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnUploadCerts.Location = new System.Drawing.Point(671, 260);
            this.btnUploadCerts.Margin = new System.Windows.Forms.Padding(4);
            this.btnUploadCerts.Name = "btnUploadCerts";
            this.btnUploadCerts.Size = new System.Drawing.Size(156, 37);
            this.btnUploadCerts.TabIndex = 10;
            this.btnUploadCerts.Text = "Upload Certificates";
            this.btnUploadCerts.UseVisualStyleBackColor = true;
            this.btnUploadCerts.Click += new System.EventHandler(this.btnUploadCerts_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBack.Location = new System.Drawing.Point(25, 540);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(110, 35);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblFormTitle.Location = new System.Drawing.Point(20, 15);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(263, 36);
            this.lblFormTitle.TabIndex = 20;
            this.lblFormTitle.Text = "My Documents";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(23, 55);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(386, 23);
            this.lblSubtitle.TabIndex = 21;
            this.lblSubtitle.Text = "Upload your required documents below";
            // 
            // lblRowResume
            // 
            this.lblRowResume.AutoSize = true;
            this.lblRowResume.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblRowResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRowResume.Location = new System.Drawing.Point(25, 150);
            this.lblRowResume.Name = "lblRowResume";
            this.lblRowResume.Size = new System.Drawing.Size(86, 20);
            this.lblRowResume.TabIndex = 22;
            this.lblRowResume.Text = "Resume:";
            // 
            // lblRowID
            // 
            this.lblRowID.AutoSize = true;
            this.lblRowID.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblRowID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRowID.Location = new System.Drawing.Point(25, 199);
            this.lblRowID.Name = "lblRowID";
            this.lblRowID.Size = new System.Drawing.Size(150, 20);
            this.lblRowID.TabIndex = 23;
            this.lblRowID.Text = "Government ID:";
            // 
            // lblRowTranscript
            // 
            this.lblRowTranscript.AutoSize = true;
            this.lblRowTranscript.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblRowTranscript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRowTranscript.Location = new System.Drawing.Point(25, 248);
            this.lblRowTranscript.Name = "lblRowTranscript";
            this.lblRowTranscript.Size = new System.Drawing.Size(197, 20);
            this.lblRowTranscript.TabIndex = 24;
            this.lblRowTranscript.Text = "Transcript of Records:";
            // 
            // lblRowCert
            // 
            this.lblRowCert.AutoSize = true;
            this.lblRowCert.Font = new System.Drawing.Font("Verdana", 10F);
            this.lblRowCert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRowCert.Location = new System.Drawing.Point(25, 297);
            this.lblRowCert.Name = "lblRowCert";
            this.lblRowCert.Size = new System.Drawing.Size(188, 20);
            this.lblRowCert.TabIndex = 25;
            this.lblRowCert.Text = "Training Certificates:";
            // 
            // frmMyDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 620);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUploadCerts);
            this.Controls.Add(this.btnUploadTranscipt);
            this.Controls.Add(this.btnUploadID);
            this.Controls.Add(this.btnUploadResume);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblOverallStatus);
            this.Controls.Add(this.lblCertStatus);
            this.Controls.Add(this.lblTranscriptStatus);
            this.Controls.Add(this.lblIDStatus);
            this.Controls.Add(this.lblResumeStatus);
            this.Controls.Add(this.lblRowCert);
            this.Controls.Add(this.lblRowTranscript);
            this.Controls.Add(this.lblRowID);
            this.Controls.Add(this.lblRowResume);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblFormTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMyDocuments";
            this.Text = "frmMyDocuments";
            this.Load += new System.EventHandler(this.frmMyDocuments_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumeStatus;
        private System.Windows.Forms.Label lblIDStatus;
        private System.Windows.Forms.Label lblTranscriptStatus;
        private System.Windows.Forms.Label lblCertStatus;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnUploadResume;
        private System.Windows.Forms.Button btnUploadID;
        private System.Windows.Forms.Button btnUploadTranscipt;
        private System.Windows.Forms.Button btnUploadCerts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblRowResume;
        private System.Windows.Forms.Label lblRowID;
        private System.Windows.Forms.Label lblRowTranscript;
        private System.Windows.Forms.Label lblRowCert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}