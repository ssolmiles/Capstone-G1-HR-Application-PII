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
            this.btnSaveRemarks = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblResumeStatus
            // 
            this.lblResumeStatus.AutoSize = true;
            this.lblResumeStatus.Location = new System.Drawing.Point(43, 13);
            this.lblResumeStatus.Name = "lblResumeStatus";
            this.lblResumeStatus.Size = new System.Drawing.Size(79, 13);
            this.lblResumeStatus.TabIndex = 0;
            this.lblResumeStatus.Text = "Resume Status";
            // 
            // lblIDStatus
            // 
            this.lblIDStatus.AutoSize = true;
            this.lblIDStatus.Location = new System.Drawing.Point(43, 36);
            this.lblIDStatus.Name = "lblIDStatus";
            this.lblIDStatus.Size = new System.Drawing.Size(51, 13);
            this.lblIDStatus.TabIndex = 1;
            this.lblIDStatus.Text = "ID Status";
            // 
            // lblTranscriptStatus
            // 
            this.lblTranscriptStatus.AutoSize = true;
            this.lblTranscriptStatus.Location = new System.Drawing.Point(43, 59);
            this.lblTranscriptStatus.Name = "lblTranscriptStatus";
            this.lblTranscriptStatus.Size = new System.Drawing.Size(87, 13);
            this.lblTranscriptStatus.TabIndex = 2;
            this.lblTranscriptStatus.Text = "Transcript Status";
            // 
            // lblCertStatus
            // 
            this.lblCertStatus.AutoSize = true;
            this.lblCertStatus.Location = new System.Drawing.Point(43, 82);
            this.lblCertStatus.Name = "lblCertStatus";
            this.lblCertStatus.Size = new System.Drawing.Size(92, 13);
            this.lblCertStatus.TabIndex = 3;
            this.lblCertStatus.Text = "Certificates Status";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Location = new System.Drawing.Point(43, 109);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(73, 13);
            this.lblOverallStatus.TabIndex = 4;
            this.lblOverallStatus.Text = "Overall Status";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(104, 135);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 20);
            this.txtRemarks.TabIndex = 5;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(43, 138);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(55, 13);
            this.lblRemarks.TabIndex = 6;
            this.lblRemarks.Text = "Remarks: ";
            // 
            // btnUploadResume
            // 
            this.btnUploadResume.Location = new System.Drawing.Point(153, 8);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(117, 23);
            this.btnUploadResume.TabIndex = 7;
            this.btnUploadResume.Text = "Upload Resume";
            this.btnUploadResume.UseVisualStyleBackColor = true;
            this.btnUploadResume.Click += new System.EventHandler(this.btnUploadResume_Click);
            // 
            // btnUploadID
            // 
            this.btnUploadID.Location = new System.Drawing.Point(153, 36);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(117, 23);
            this.btnUploadID.TabIndex = 8;
            this.btnUploadID.Text = "Upload ID";
            this.btnUploadID.UseVisualStyleBackColor = true;
            this.btnUploadID.Click += new System.EventHandler(this.btnUploadID_Click);
            // 
            // btnUploadTranscipt
            // 
            this.btnUploadTranscipt.Location = new System.Drawing.Point(153, 65);
            this.btnUploadTranscipt.Name = "btnUploadTranscipt";
            this.btnUploadTranscipt.Size = new System.Drawing.Size(117, 23);
            this.btnUploadTranscipt.TabIndex = 9;
            this.btnUploadTranscipt.Text = "Upload Transcript";
            this.btnUploadTranscipt.UseVisualStyleBackColor = true;
            this.btnUploadTranscipt.Click += new System.EventHandler(this.btnUploadTranscipt_Click);
            // 
            // btnUploadCerts
            // 
            this.btnUploadCerts.Location = new System.Drawing.Point(153, 94);
            this.btnUploadCerts.Name = "btnUploadCerts";
            this.btnUploadCerts.Size = new System.Drawing.Size(117, 23);
            this.btnUploadCerts.TabIndex = 10;
            this.btnUploadCerts.Text = "Upload Certificates";
            this.btnUploadCerts.UseVisualStyleBackColor = true;
            this.btnUploadCerts.Click += new System.EventHandler(this.btnUploadCerts_Click);
            // 
            // btnSaveRemarks
            // 
            this.btnSaveRemarks.Location = new System.Drawing.Point(221, 133);
            this.btnSaveRemarks.Name = "btnSaveRemarks";
            this.btnSaveRemarks.Size = new System.Drawing.Size(75, 23);
            this.btnSaveRemarks.TabIndex = 11;
            this.btnSaveRemarks.Text = "SAVE";
            this.btnSaveRemarks.UseVisualStyleBackColor = true;
            this.btnSaveRemarks.Click += new System.EventHandler(this.btnSaveRemarks_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(153, 190);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMyDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSaveRemarks);
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
            this.Name = "frmMyDocuments";
            this.Text = "frmMyDocuments";
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
        private System.Windows.Forms.Button btnSaveRemarks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}