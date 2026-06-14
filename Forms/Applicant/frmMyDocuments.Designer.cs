namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmMyDocuments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblResumeLabel = new System.Windows.Forms.Label();
            this.lblIDLabel = new System.Windows.Forms.Label();
            this.lblTranscriptLabel = new System.Windows.Forms.Label();
            this.lblCertLabel = new System.Windows.Forms.Label();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.lblResumeStatus = new System.Windows.Forms.Label();
            this.lblIDStatus = new System.Windows.Forms.Label();
            this.lblTranscriptStatus = new System.Windows.Forms.Label();
            this.lblCertStatus = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnUploadResume = new System.Windows.Forms.Button();
            this.btnUploadID = new System.Windows.Forms.Button();
            this.btnUploadTranscipt = new System.Windows.Forms.Button();
            this.btnUploadCerts = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblResumeLabel
            // 
            this.lblResumeLabel.AutoSize = true;
            this.lblResumeLabel.Location = new System.Drawing.Point(42, 89);
            this.lblResumeLabel.Name = "lblResumeLabel";
            this.lblResumeLabel.Size = new System.Drawing.Size(61, 16);
            this.lblResumeLabel.TabIndex = 1;
            this.lblResumeLabel.Text = "Resume:";
            // 
            // lblIDLabel
            // 
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.Location = new System.Drawing.Point(42, 155);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new System.Drawing.Size(57, 16);
            this.lblIDLabel.TabIndex = 4;
            this.lblIDLabel.Text = "Valid ID:";
            // 
            // lblTranscriptLabel
            // 
            this.lblTranscriptLabel.AutoSize = true;
            this.lblTranscriptLabel.Location = new System.Drawing.Point(42, 228);
            this.lblTranscriptLabel.Name = "lblTranscriptLabel";
            this.lblTranscriptLabel.Size = new System.Drawing.Size(139, 16);
            this.lblTranscriptLabel.TabIndex = 7;
            this.lblTranscriptLabel.Text = "Transcript of Records:";
            // 
            // lblCertLabel
            // 
            this.lblCertLabel.AutoSize = true;
            this.lblCertLabel.Location = new System.Drawing.Point(42, 286);
            this.lblCertLabel.Name = "lblCertLabel";
            this.lblCertLabel.Size = new System.Drawing.Size(76, 16);
            this.lblCertLabel.TabIndex = 10;
            this.lblCertLabel.Text = "Certificates:";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.Location = new System.Drawing.Point(42, 40);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(160, 25);
            this.lblOverallStatus.TabIndex = 0;
            this.lblOverallStatus.Text = "Overall Status: --";
            // 
            // lblResumeStatus
            // 
            this.lblResumeStatus.AutoSize = true;
            this.lblResumeStatus.Location = new System.Drawing.Point(372, 75);
            this.lblResumeStatus.Name = "lblResumeStatus";
            this.lblResumeStatus.Size = new System.Drawing.Size(53, 16);
            this.lblResumeStatus.TabIndex = 2;
            this.lblResumeStatus.Text = "Missing";
            // 
            // lblIDStatus
            // 
            this.lblIDStatus.AutoSize = true;
            this.lblIDStatus.Location = new System.Drawing.Point(372, 141);
            this.lblIDStatus.Name = "lblIDStatus";
            this.lblIDStatus.Size = new System.Drawing.Size(53, 16);
            this.lblIDStatus.TabIndex = 5;
            this.lblIDStatus.Text = "Missing";
            this.lblIDStatus.Click += new System.EventHandler(this.lblIDStatus_Click);
            // 
            // lblTranscriptStatus
            // 
            this.lblTranscriptStatus.AutoSize = true;
            this.lblTranscriptStatus.Location = new System.Drawing.Point(372, 214);
            this.lblTranscriptStatus.Name = "lblTranscriptStatus";
            this.lblTranscriptStatus.Size = new System.Drawing.Size(53, 16);
            this.lblTranscriptStatus.TabIndex = 8;
            this.lblTranscriptStatus.Text = "Missing";
            // 
            // lblCertStatus
            // 
            this.lblCertStatus.AutoSize = true;
            this.lblCertStatus.Location = new System.Drawing.Point(372, 272);
            this.lblCertStatus.Name = "lblCertStatus";
            this.lblCertStatus.Size = new System.Drawing.Size(53, 16);
            this.lblCertStatus.TabIndex = 11;
            this.lblCertStatus.Text = "Missing";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(499, 70);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.Size = new System.Drawing.Size(964, 557);
            this.txtRemarks.TabIndex = 13;
            // 
            // btnUploadResume
            // 
            this.btnUploadResume.Location = new System.Drawing.Point(275, 70);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(80, 28);
            this.btnUploadResume.TabIndex = 3;
            this.btnUploadResume.Text = "Upload";
            this.btnUploadResume.UseVisualStyleBackColor = true;
            this.btnUploadResume.Click += new System.EventHandler(this.btnUploadResume_Click);
            // 
            // btnUploadID
            // 
            this.btnUploadID.Location = new System.Drawing.Point(275, 136);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(80, 28);
            this.btnUploadID.TabIndex = 6;
            this.btnUploadID.Text = "Upload";
            this.btnUploadID.UseVisualStyleBackColor = true;
            this.btnUploadID.Click += new System.EventHandler(this.btnUploadID_Click);
            // 
            // btnUploadTranscipt
            // 
            this.btnUploadTranscipt.Location = new System.Drawing.Point(275, 209);
            this.btnUploadTranscipt.Name = "btnUploadTranscipt";
            this.btnUploadTranscipt.Size = new System.Drawing.Size(80, 28);
            this.btnUploadTranscipt.TabIndex = 9;
            this.btnUploadTranscipt.Text = "Upload";
            this.btnUploadTranscipt.UseVisualStyleBackColor = true;
            this.btnUploadTranscipt.Click += new System.EventHandler(this.btnUploadTranscipt_Click);
            // 
            // btnUploadCerts
            // 
            this.btnUploadCerts.Location = new System.Drawing.Point(275, 267);
            this.btnUploadCerts.Name = "btnUploadCerts";
            this.btnUploadCerts.Size = new System.Drawing.Size(80, 28);
            this.btnUploadCerts.TabIndex = 12;
            this.btnUploadCerts.Text = "Upload";
            this.btnUploadCerts.UseVisualStyleBackColor = true;
            this.btnUploadCerts.Click += new System.EventHandler(this.btnUploadCerts_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1602, 50);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*" +
    ".docx|Images (*.jpg;*.png)|*.jpg;*.png";
            this.openFileDialog1.Title = "Select Document to Upload";
            // 
            // frmMyDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblOverallStatus);
            this.Controls.Add(this.lblResumeLabel);
            this.Controls.Add(this.lblResumeStatus);
            this.Controls.Add(this.btnUploadResume);
            this.Controls.Add(this.lblIDLabel);
            this.Controls.Add(this.lblIDStatus);
            this.Controls.Add(this.btnUploadID);
            this.Controls.Add(this.lblTranscriptLabel);
            this.Controls.Add(this.lblTranscriptStatus);
            this.Controls.Add(this.btnUploadTranscipt);
            this.Controls.Add(this.lblCertLabel);
            this.Controls.Add(this.lblCertStatus);
            this.Controls.Add(this.btnUploadCerts);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMyDocuments";
            this.Text = "My Documents";
            this.Load += new System.EventHandler(this.frmMyDocuments_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblResumeLabel;
        private System.Windows.Forms.Label lblIDLabel;
        private System.Windows.Forms.Label lblTranscriptLabel;
        private System.Windows.Forms.Label lblCertLabel;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.Label lblResumeStatus;
        private System.Windows.Forms.Label lblIDStatus;
        private System.Windows.Forms.Label lblTranscriptStatus;
        private System.Windows.Forms.Label lblCertStatus;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnUploadResume;
        private System.Windows.Forms.Button btnUploadID;
        private System.Windows.Forms.Button btnUploadTranscipt;
        private System.Windows.Forms.Button btnUploadCerts;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
