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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblOverallStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBoxChecklist = new System.Windows.Forms.GroupBox();
            this.lblResumeLabel = new System.Windows.Forms.Label();
            this.lblResumeStatus = new System.Windows.Forms.Label();
            this.btnUploadResume = new System.Windows.Forms.Button();
            this.btnRemoveResume = new System.Windows.Forms.Button();
            this.lblIDLabel = new System.Windows.Forms.Label();
            this.lblIDStatus = new System.Windows.Forms.Label();
            this.btnUploadID = new System.Windows.Forms.Button();
            this.btnRemoveID = new System.Windows.Forms.Button();
            this.lblTranscriptLabel = new System.Windows.Forms.Label();
            this.lblTranscriptStatus = new System.Windows.Forms.Label();
            this.btnUploadTranscript = new System.Windows.Forms.Button();
            this.btnRemoveTranscript = new System.Windows.Forms.Button();
            this.lblCertLabel = new System.Windows.Forms.Label();
            this.lblCertStatus = new System.Windows.Forms.Label();
            this.btnUploadCerts = new System.Windows.Forms.Button();
            this.btnRemoveCerts = new System.Windows.Forms.Button();
            this.groupBoxRemarks = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxChecklist.SuspendLayout();
            this.groupBoxRemarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(471, 44);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Documents";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(473, 86);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(530, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Upload the requirements needed to process your application";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.Location = new System.Drawing.Point(473, 134);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(172, 28);
            this.lblOverallStatus.TabIndex = 2;
            this.lblOverallStatus.Text = "Overall Status: --";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBack.Location = new System.Drawing.Point(1672, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 36);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "← Back to Profile";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBoxChecklist
            // 
            this.groupBoxChecklist.Controls.Add(this.lblResumeLabel);
            this.groupBoxChecklist.Controls.Add(this.lblResumeStatus);
            this.groupBoxChecklist.Controls.Add(this.btnUploadResume);
            this.groupBoxChecklist.Controls.Add(this.btnRemoveResume);
            this.groupBoxChecklist.Controls.Add(this.lblIDLabel);
            this.groupBoxChecklist.Controls.Add(this.lblIDStatus);
            this.groupBoxChecklist.Controls.Add(this.btnUploadID);
            this.groupBoxChecklist.Controls.Add(this.btnRemoveID);
            this.groupBoxChecklist.Controls.Add(this.lblTranscriptLabel);
            this.groupBoxChecklist.Controls.Add(this.lblTranscriptStatus);
            this.groupBoxChecklist.Controls.Add(this.btnUploadTranscript);
            this.groupBoxChecklist.Controls.Add(this.btnRemoveTranscript);
            this.groupBoxChecklist.Controls.Add(this.lblCertLabel);
            this.groupBoxChecklist.Controls.Add(this.lblCertStatus);
            this.groupBoxChecklist.Controls.Add(this.btnUploadCerts);
            this.groupBoxChecklist.Controls.Add(this.btnRemoveCerts);
            this.groupBoxChecklist.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBoxChecklist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBoxChecklist.Location = new System.Drawing.Point(471, 179);
            this.groupBoxChecklist.Name = "groupBoxChecklist";
            this.groupBoxChecklist.Size = new System.Drawing.Size(700, 440);
            this.groupBoxChecklist.TabIndex = 4;
            this.groupBoxChecklist.TabStop = false;
            this.groupBoxChecklist.Text = "Requirements Checklist";
            // 
            // lblResumeLabel
            // 
            this.lblResumeLabel.AutoSize = true;
            this.lblResumeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblResumeLabel.Location = new System.Drawing.Point(20, 55);
            this.lblResumeLabel.Name = "lblResumeLabel";
            this.lblResumeLabel.Size = new System.Drawing.Size(86, 20);
            this.lblResumeLabel.TabIndex = 0;
            this.lblResumeLabel.Text = "Resume:";
            // 
            // lblResumeStatus
            // 
            this.lblResumeStatus.AutoSize = true;
            this.lblResumeStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumeStatus.Location = new System.Drawing.Point(210, 55);
            this.lblResumeStatus.Name = "lblResumeStatus";
            this.lblResumeStatus.Size = new System.Drawing.Size(81, 20);
            this.lblResumeStatus.TabIndex = 1;
            this.lblResumeStatus.Text = "Missing";
            // 
            // btnUploadResume
            // 
            this.btnUploadResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadResume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadResume.ForeColor = System.Drawing.Color.White;
            this.btnUploadResume.Location = new System.Drawing.Point(370, 48);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(140, 34);
            this.btnUploadResume.TabIndex = 2;
            this.btnUploadResume.Text = "Upload";
            this.btnUploadResume.UseVisualStyleBackColor = false;
            this.btnUploadResume.Click += new System.EventHandler(this.btnUploadResume_Click);
            // 
            // btnRemoveResume
            // 
            this.btnRemoveResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveResume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveResume.ForeColor = System.Drawing.Color.White;
            this.btnRemoveResume.Location = new System.Drawing.Point(525, 48);
            this.btnRemoveResume.Name = "btnRemoveResume";
            this.btnRemoveResume.Size = new System.Drawing.Size(140, 34);
            this.btnRemoveResume.TabIndex = 3;
            this.btnRemoveResume.Text = "Remove";
            this.btnRemoveResume.UseVisualStyleBackColor = false;
            this.btnRemoveResume.Click += new System.EventHandler(this.btnRemoveResume_Click);
            // 
            // lblIDLabel
            // 
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblIDLabel.Location = new System.Drawing.Point(20, 145);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new System.Drawing.Size(86, 20);
            this.lblIDLabel.TabIndex = 4;
            this.lblIDLabel.Text = "Valid ID:";
            // 
            // lblIDStatus
            // 
            this.lblIDStatus.AutoSize = true;
            this.lblIDStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblIDStatus.Location = new System.Drawing.Point(210, 145);
            this.lblIDStatus.Name = "lblIDStatus";
            this.lblIDStatus.Size = new System.Drawing.Size(81, 20);
            this.lblIDStatus.TabIndex = 5;
            this.lblIDStatus.Text = "Missing";
            // 
            // btnUploadID
            // 
            this.btnUploadID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadID.ForeColor = System.Drawing.Color.White;
            this.btnUploadID.Location = new System.Drawing.Point(370, 138);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(140, 34);
            this.btnUploadID.TabIndex = 6;
            this.btnUploadID.Text = "Upload";
            this.btnUploadID.UseVisualStyleBackColor = false;
            this.btnUploadID.Click += new System.EventHandler(this.btnUploadID_Click);
            // 
            // btnRemoveID
            // 
            this.btnRemoveID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveID.ForeColor = System.Drawing.Color.White;
            this.btnRemoveID.Location = new System.Drawing.Point(525, 138);
            this.btnRemoveID.Name = "btnRemoveID";
            this.btnRemoveID.Size = new System.Drawing.Size(140, 34);
            this.btnRemoveID.TabIndex = 7;
            this.btnRemoveID.Text = "Remove";
            this.btnRemoveID.UseVisualStyleBackColor = false;
            this.btnRemoveID.Click += new System.EventHandler(this.btnRemoveID_Click);
            // 
            // lblTranscriptLabel
            // 
            this.lblTranscriptLabel.AutoSize = true;
            this.lblTranscriptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTranscriptLabel.Location = new System.Drawing.Point(20, 235);
            this.lblTranscriptLabel.Name = "lblTranscriptLabel";
            this.lblTranscriptLabel.Size = new System.Drawing.Size(197, 20);
            this.lblTranscriptLabel.TabIndex = 8;
            this.lblTranscriptLabel.Text = "Transcript of Records:";
            // 
            // lblTranscriptStatus
            // 
            this.lblTranscriptStatus.AutoSize = true;
            this.lblTranscriptStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTranscriptStatus.Location = new System.Drawing.Point(210, 235);
            this.lblTranscriptStatus.Name = "lblTranscriptStatus";
            this.lblTranscriptStatus.Size = new System.Drawing.Size(81, 20);
            this.lblTranscriptStatus.TabIndex = 9;
            this.lblTranscriptStatus.Text = "Missing";
            // 
            // btnUploadTranscript
            // 
            this.btnUploadTranscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadTranscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadTranscript.ForeColor = System.Drawing.Color.White;
            this.btnUploadTranscript.Location = new System.Drawing.Point(370, 228);
            this.btnUploadTranscript.Name = "btnUploadTranscript";
            this.btnUploadTranscript.Size = new System.Drawing.Size(140, 34);
            this.btnUploadTranscript.TabIndex = 10;
            this.btnUploadTranscript.Text = "Upload";
            this.btnUploadTranscript.UseVisualStyleBackColor = false;
            this.btnUploadTranscript.Click += new System.EventHandler(this.btnUploadTranscript_Click);
            // 
            // btnRemoveTranscript
            // 
            this.btnRemoveTranscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTranscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveTranscript.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTranscript.Location = new System.Drawing.Point(525, 228);
            this.btnRemoveTranscript.Name = "btnRemoveTranscript";
            this.btnRemoveTranscript.Size = new System.Drawing.Size(140, 34);
            this.btnRemoveTranscript.TabIndex = 11;
            this.btnRemoveTranscript.Text = "Remove";
            this.btnRemoveTranscript.UseVisualStyleBackColor = false;
            this.btnRemoveTranscript.Click += new System.EventHandler(this.btnRemoveTranscript_Click);
            // 
            // lblCertLabel
            // 
            this.lblCertLabel.AutoSize = true;
            this.lblCertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCertLabel.Location = new System.Drawing.Point(20, 325);
            this.lblCertLabel.Name = "lblCertLabel";
            this.lblCertLabel.Size = new System.Drawing.Size(114, 20);
            this.lblCertLabel.TabIndex = 12;
            this.lblCertLabel.Text = "Certificates:";
            // 
            // lblCertStatus
            // 
            this.lblCertStatus.AutoSize = true;
            this.lblCertStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblCertStatus.Location = new System.Drawing.Point(210, 325);
            this.lblCertStatus.Name = "lblCertStatus";
            this.lblCertStatus.Size = new System.Drawing.Size(81, 20);
            this.lblCertStatus.TabIndex = 13;
            this.lblCertStatus.Text = "Missing";
            // 
            // btnUploadCerts
            // 
            this.btnUploadCerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadCerts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadCerts.ForeColor = System.Drawing.Color.White;
            this.btnUploadCerts.Location = new System.Drawing.Point(370, 318);
            this.btnUploadCerts.Name = "btnUploadCerts";
            this.btnUploadCerts.Size = new System.Drawing.Size(140, 34);
            this.btnUploadCerts.TabIndex = 14;
            this.btnUploadCerts.Text = "Upload";
            this.btnUploadCerts.UseVisualStyleBackColor = false;
            this.btnUploadCerts.Click += new System.EventHandler(this.btnUploadCerts_Click);
            // 
            // btnRemoveCerts
            // 
            this.btnRemoveCerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCerts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCerts.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCerts.Location = new System.Drawing.Point(525, 318);
            this.btnRemoveCerts.Name = "btnRemoveCerts";
            this.btnRemoveCerts.Size = new System.Drawing.Size(140, 34);
            this.btnRemoveCerts.TabIndex = 15;
            this.btnRemoveCerts.Text = "Remove";
            this.btnRemoveCerts.UseVisualStyleBackColor = false;
            this.btnRemoveCerts.Click += new System.EventHandler(this.btnRemoveCerts_Click);
            // 
            // groupBoxRemarks
            // 
            this.groupBoxRemarks.Controls.Add(this.txtRemarks);
            this.groupBoxRemarks.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBoxRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBoxRemarks.Location = new System.Drawing.Point(1229, 190);
            this.groupBoxRemarks.Name = "groupBoxRemarks";
            this.groupBoxRemarks.Size = new System.Drawing.Size(431, 235);
            this.groupBoxRemarks.TabIndex = 5;
            this.groupBoxRemarks.TabStop = false;
            this.groupBoxRemarks.Text = "HR Remarks / Screening Feedback";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(19, 37);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(391, 170);
            this.txtRemarks.TabIndex = 0;
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
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblOverallStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxChecklist);
            this.Controls.Add(this.groupBoxRemarks);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMyDocuments";
            this.Text = "My Documents";
            this.Load += new System.EventHandler(this.frmMyDocuments_Load_1);
            this.groupBoxChecklist.ResumeLayout(false);
            this.groupBoxChecklist.PerformLayout();
            this.groupBoxRemarks.ResumeLayout(false);
            this.groupBoxRemarks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblOverallStatus;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.GroupBox groupBoxChecklist;
        private System.Windows.Forms.Label lblResumeLabel;
        private System.Windows.Forms.Label lblResumeStatus;
        private System.Windows.Forms.Button btnUploadResume;
        private System.Windows.Forms.Button btnRemoveResume;

        private System.Windows.Forms.Label lblIDLabel;
        private System.Windows.Forms.Label lblIDStatus;
        private System.Windows.Forms.Button btnUploadID;
        private System.Windows.Forms.Button btnRemoveID;

        private System.Windows.Forms.Label lblTranscriptLabel;
        private System.Windows.Forms.Label lblTranscriptStatus;
        private System.Windows.Forms.Button btnUploadTranscript;
        private System.Windows.Forms.Button btnRemoveTranscript;

        private System.Windows.Forms.Label lblCertLabel;
        private System.Windows.Forms.Label lblCertStatus;
        private System.Windows.Forms.Button btnUploadCerts;
        private System.Windows.Forms.Button btnRemoveCerts;

        private System.Windows.Forms.GroupBox groupBoxRemarks;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}