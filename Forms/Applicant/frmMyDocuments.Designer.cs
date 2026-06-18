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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMyApplication = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJobVacancies = new System.Windows.Forms.Button();
            this.groupBoxChecklist.SuspendLayout();
            this.groupBoxRemarks.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(269, 207);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(210, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Documents";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(271, 241);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(412, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Upload the requirements needed to process your application";
            // 
            // lblOverallStatus
            // 
            this.lblOverallStatus.AutoSize = true;
            this.lblOverallStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOverallStatus.Location = new System.Drawing.Point(271, 280);
            this.lblOverallStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOverallStatus.Name = "lblOverallStatus";
            this.lblOverallStatus.Size = new System.Drawing.Size(136, 21);
            this.lblOverallStatus.TabIndex = 2;
            this.lblOverallStatus.Text = "Overall Status: --";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBack.Location = new System.Drawing.Point(1207, 207);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 29);
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
            this.groupBoxChecklist.Location = new System.Drawing.Point(269, 316);
            this.groupBoxChecklist.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxChecklist.Name = "groupBoxChecklist";
            this.groupBoxChecklist.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxChecklist.Size = new System.Drawing.Size(525, 358);
            this.groupBoxChecklist.TabIndex = 4;
            this.groupBoxChecklist.TabStop = false;
            this.groupBoxChecklist.Text = "Requirements Checklist";
            // 
            // lblResumeLabel
            // 
            this.lblResumeLabel.AutoSize = true;
            this.lblResumeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblResumeLabel.Location = new System.Drawing.Point(15, 45);
            this.lblResumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumeLabel.Name = "lblResumeLabel";
            this.lblResumeLabel.Size = new System.Drawing.Size(70, 17);
            this.lblResumeLabel.TabIndex = 0;
            this.lblResumeLabel.Text = "Resume:";
            // 
            // lblResumeStatus
            // 
            this.lblResumeStatus.AutoSize = true;
            this.lblResumeStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblResumeStatus.Location = new System.Drawing.Point(158, 45);
            this.lblResumeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResumeStatus.Name = "lblResumeStatus";
            this.lblResumeStatus.Size = new System.Drawing.Size(65, 17);
            this.lblResumeStatus.TabIndex = 1;
            this.lblResumeStatus.Text = "Missing";
            // 
            // btnUploadResume
            // 
            this.btnUploadResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadResume.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadResume.ForeColor = System.Drawing.Color.White;
            this.btnUploadResume.Location = new System.Drawing.Point(278, 39);
            this.btnUploadResume.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadResume.Name = "btnUploadResume";
            this.btnUploadResume.Size = new System.Drawing.Size(105, 28);
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
            this.btnRemoveResume.Location = new System.Drawing.Point(394, 39);
            this.btnRemoveResume.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveResume.Name = "btnRemoveResume";
            this.btnRemoveResume.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveResume.TabIndex = 3;
            this.btnRemoveResume.Text = "Remove";
            this.btnRemoveResume.UseVisualStyleBackColor = false;
            this.btnRemoveResume.Click += new System.EventHandler(this.btnRemoveResume_Click);
            // 
            // lblIDLabel
            // 
            this.lblIDLabel.AutoSize = true;
            this.lblIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblIDLabel.Location = new System.Drawing.Point(15, 118);
            this.lblIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDLabel.Name = "lblIDLabel";
            this.lblIDLabel.Size = new System.Drawing.Size(67, 17);
            this.lblIDLabel.TabIndex = 4;
            this.lblIDLabel.Text = "Valid ID:";
            // 
            // lblIDStatus
            // 
            this.lblIDStatus.AutoSize = true;
            this.lblIDStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblIDStatus.Location = new System.Drawing.Point(158, 118);
            this.lblIDStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDStatus.Name = "lblIDStatus";
            this.lblIDStatus.Size = new System.Drawing.Size(65, 17);
            this.lblIDStatus.TabIndex = 5;
            this.lblIDStatus.Text = "Missing";
            // 
            // btnUploadID
            // 
            this.btnUploadID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadID.ForeColor = System.Drawing.Color.White;
            this.btnUploadID.Location = new System.Drawing.Point(278, 112);
            this.btnUploadID.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadID.Name = "btnUploadID";
            this.btnUploadID.Size = new System.Drawing.Size(105, 28);
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
            this.btnRemoveID.Location = new System.Drawing.Point(394, 112);
            this.btnRemoveID.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveID.Name = "btnRemoveID";
            this.btnRemoveID.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveID.TabIndex = 7;
            this.btnRemoveID.Text = "Remove";
            this.btnRemoveID.UseVisualStyleBackColor = false;
            this.btnRemoveID.Click += new System.EventHandler(this.btnRemoveID_Click);
            // 
            // lblTranscriptLabel
            // 
            this.lblTranscriptLabel.AutoSize = true;
            this.lblTranscriptLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblTranscriptLabel.Location = new System.Drawing.Point(15, 191);
            this.lblTranscriptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTranscriptLabel.Name = "lblTranscriptLabel";
            this.lblTranscriptLabel.Size = new System.Drawing.Size(165, 17);
            this.lblTranscriptLabel.TabIndex = 8;
            this.lblTranscriptLabel.Text = "Transcript of Records:";
            // 
            // lblTranscriptStatus
            // 
            this.lblTranscriptStatus.AutoSize = true;
            this.lblTranscriptStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblTranscriptStatus.Location = new System.Drawing.Point(158, 191);
            this.lblTranscriptStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTranscriptStatus.Name = "lblTranscriptStatus";
            this.lblTranscriptStatus.Size = new System.Drawing.Size(65, 17);
            this.lblTranscriptStatus.TabIndex = 9;
            this.lblTranscriptStatus.Text = "Missing";
            // 
            // btnUploadTranscript
            // 
            this.btnUploadTranscript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadTranscript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadTranscript.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadTranscript.ForeColor = System.Drawing.Color.White;
            this.btnUploadTranscript.Location = new System.Drawing.Point(278, 185);
            this.btnUploadTranscript.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadTranscript.Name = "btnUploadTranscript";
            this.btnUploadTranscript.Size = new System.Drawing.Size(105, 28);
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
            this.btnRemoveTranscript.Location = new System.Drawing.Point(394, 185);
            this.btnRemoveTranscript.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveTranscript.Name = "btnRemoveTranscript";
            this.btnRemoveTranscript.Size = new System.Drawing.Size(105, 28);
            this.btnRemoveTranscript.TabIndex = 11;
            this.btnRemoveTranscript.Text = "Remove";
            this.btnRemoveTranscript.UseVisualStyleBackColor = false;
            this.btnRemoveTranscript.Click += new System.EventHandler(this.btnRemoveTranscript_Click);
            // 
            // lblCertLabel
            // 
            this.lblCertLabel.AutoSize = true;
            this.lblCertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblCertLabel.Location = new System.Drawing.Point(15, 264);
            this.lblCertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCertLabel.Name = "lblCertLabel";
            this.lblCertLabel.Size = new System.Drawing.Size(92, 17);
            this.lblCertLabel.TabIndex = 12;
            this.lblCertLabel.Text = "Certificates:";
            // 
            // lblCertStatus
            // 
            this.lblCertStatus.AutoSize = true;
            this.lblCertStatus.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lblCertStatus.Location = new System.Drawing.Point(158, 264);
            this.lblCertStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCertStatus.Name = "lblCertStatus";
            this.lblCertStatus.Size = new System.Drawing.Size(65, 17);
            this.lblCertStatus.TabIndex = 13;
            this.lblCertStatus.Text = "Missing";
            // 
            // btnUploadCerts
            // 
            this.btnUploadCerts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUploadCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadCerts.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.btnUploadCerts.ForeColor = System.Drawing.Color.White;
            this.btnUploadCerts.Location = new System.Drawing.Point(278, 258);
            this.btnUploadCerts.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadCerts.Name = "btnUploadCerts";
            this.btnUploadCerts.Size = new System.Drawing.Size(105, 28);
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
            this.btnRemoveCerts.Location = new System.Drawing.Point(394, 258);
            this.btnRemoveCerts.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCerts.Name = "btnRemoveCerts";
            this.btnRemoveCerts.Size = new System.Drawing.Size(105, 28);
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
            this.groupBoxRemarks.Location = new System.Drawing.Point(838, 325);
            this.groupBoxRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRemarks.Name = "groupBoxRemarks";
            this.groupBoxRemarks.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRemarks.Size = new System.Drawing.Size(323, 191);
            this.groupBoxRemarks.TabIndex = 5;
            this.groupBoxRemarks.TabStop = false;
            this.groupBoxRemarks.Text = "HR Remarks / Screening Feedback";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Verdana", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(14, 30);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(294, 138);
            this.txtRemarks.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Word Documents (*.doc;*.docx)|*.doc;*" +
    ".docx|Images (*.jpg;*.png)|*.jpg;*.png";
            this.openFileDialog1.Title = "Select Document to Upload";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 17;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1086, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 23);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "Time and Date";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 57);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.btnViewStatus);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnMyApplication);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnJobVacancies);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 50);
            this.panel2.TabIndex = 14;
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Chelsea Market", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.White;
            this.btnChangePass.Location = new System.Drawing.Point(1129, 0);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(232, 51);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnViewStatus.FlatAppearance.BorderSize = 0;
            this.btnViewStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewStatus.Font = new System.Drawing.Font("Chelsea Market", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStatus.ForeColor = System.Drawing.Color.White;
            this.btnViewStatus.Location = new System.Drawing.Point(853, -1);
            this.btnViewStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(286, 50);
            this.btnViewStatus.TabIndex = 1;
            this.btnViewStatus.Text = "View Application Status";
            this.btnViewStatus.UseVisualStyleBackColor = false;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Chelsea Market", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(686, 1);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(179, 48);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnMyApplication
            // 
            this.btnMyApplication.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMyApplication.FlatAppearance.BorderSize = 0;
            this.btnMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplication.Font = new System.Drawing.Font("Chelsea Market", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyApplication.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMyApplication.Location = new System.Drawing.Point(484, 0);
            this.btnMyApplication.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyApplication.Name = "btnMyApplication";
            this.btnMyApplication.Size = new System.Drawing.Size(225, 49);
            this.btnMyApplication.TabIndex = 11;
            this.btnMyApplication.Text = "My Application";
            this.btnMyApplication.UseVisualStyleBackColor = false;
            this.btnMyApplication.Click += new System.EventHandler(this.btnMyApplication_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Dashboard";
            // 
            // btnJobVacancies
            // 
            this.btnJobVacancies.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnJobVacancies.FlatAppearance.BorderSize = 0;
            this.btnJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobVacancies.Font = new System.Drawing.Font("Chelsea Market", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVacancies.ForeColor = System.Drawing.Color.White;
            this.btnJobVacancies.Location = new System.Drawing.Point(285, -2);
            this.btnJobVacancies.Margin = new System.Windows.Forms.Padding(2);
            this.btnJobVacancies.Name = "btnJobVacancies";
            this.btnJobVacancies.Size = new System.Drawing.Size(216, 50);
            this.btnJobVacancies.TabIndex = 10;
            this.btnJobVacancies.Text = "Job Vacancies";
            this.btnJobVacancies.UseVisualStyleBackColor = false;
            this.btnJobVacancies.Click += new System.EventHandler(this.btnJobVacancies_Click);
            // 
            // frmMyDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblOverallStatus);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBoxChecklist);
            this.Controls.Add(this.groupBoxRemarks);
            this.MinimizeBox = false;
            this.Name = "frmMyDocuments";
            this.Text = "My Documents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMyDocuments_Load_1);
            this.groupBoxChecklist.ResumeLayout(false);
            this.groupBoxChecklist.PerformLayout();
            this.groupBoxRemarks.ResumeLayout(false);
            this.groupBoxRemarks.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMyApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJobVacancies;
    }
}