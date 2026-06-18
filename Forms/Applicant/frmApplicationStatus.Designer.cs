namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicationStatus
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.lblStep1Text = new System.Windows.Forms.Label();
            this.lblStep2Text = new System.Windows.Forms.Label();
            this.lblStep3Text = new System.Windows.Forms.Label();
            this.lblStep4Text = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpHistory = new System.Windows.Forms.GroupBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(186, 152);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Application Status";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(186, 184);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(154, 18);
            this.lblCurrentStatus.TabIndex = 1;
            this.lblCurrentStatus.Text = "Current Status: --";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(6, 24);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(114, 18);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Final Result: ";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRemarks.Location = new System.Drawing.Point(6, 20);
            this.lblRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(80, 14);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks: --";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSchedule.Location = new System.Drawing.Point(4, 28);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(187, 14);
            this.lblSchedule.TabIndex = 0;
            this.lblSchedule.Text = "Schedule: Not yet scheduled";
            // 
            // lblStep1
            // 
            this.lblStep1.BackColor = System.Drawing.Color.Gray;
            this.lblStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep1.Location = new System.Drawing.Point(190, 226);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(16, 17);
            this.lblStep1.TabIndex = 2;
            // 
            // lblStep2
            // 
            this.lblStep2.BackColor = System.Drawing.Color.Gray;
            this.lblStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep2.Location = new System.Drawing.Point(190, 258);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(16, 17);
            this.lblStep2.TabIndex = 4;
            // 
            // lblStep3
            // 
            this.lblStep3.BackColor = System.Drawing.Color.Gray;
            this.lblStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep3.Location = new System.Drawing.Point(190, 291);
            this.lblStep3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(16, 17);
            this.lblStep3.TabIndex = 6;
            // 
            // lblStep4
            // 
            this.lblStep4.BackColor = System.Drawing.Color.Gray;
            this.lblStep4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep4.Location = new System.Drawing.Point(190, 323);
            this.lblStep4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(16, 17);
            this.lblStep4.TabIndex = 8;
            // 
            // lblStep1Text
            // 
            this.lblStep1Text.AutoSize = true;
            this.lblStep1Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep1Text.Location = new System.Drawing.Point(211, 228);
            this.lblStep1Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep1Text.Name = "lblStep1Text";
            this.lblStep1Text.Size = new System.Drawing.Size(143, 14);
            this.lblStep1Text.TabIndex = 3;
            this.lblStep1Text.Text = "Application Submitted";
            // 
            // lblStep2Text
            // 
            this.lblStep2Text.AutoSize = true;
            this.lblStep2Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep2Text.Location = new System.Drawing.Point(211, 260);
            this.lblStep2Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep2Text.Name = "lblStep2Text";
            this.lblStep2Text.Size = new System.Drawing.Size(94, 14);
            this.lblStep2Text.TabIndex = 5;
            this.lblStep2Text.Text = "Under Review";
            // 
            // lblStep3Text
            // 
            this.lblStep3Text.AutoSize = true;
            this.lblStep3Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep3Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep3Text.Location = new System.Drawing.Point(211, 293);
            this.lblStep3Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep3Text.Name = "lblStep3Text";
            this.lblStep3Text.Size = new System.Drawing.Size(67, 14);
            this.lblStep3Text.TabIndex = 7;
            this.lblStep3Text.Text = "Interview";
            // 
            // lblStep4Text
            // 
            this.lblStep4Text.AutoSize = true;
            this.lblStep4Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep4Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep4Text.Location = new System.Drawing.Point(211, 325);
            this.lblStep4Text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStep4Text.Name = "lblStep4Text";
            this.lblStep4Text.Size = new System.Drawing.Size(92, 14);
            this.lblStep4Text.TabIndex = 9;
            this.lblStep4Text.Text = "Final Decision";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(604, 492);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(290, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HR Remarks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSchedule);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(360, 406);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(203, 161);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interview Schedule";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(360, 220);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(203, 161);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Result";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(6, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "My Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpHistory
            // 
            this.grpHistory.Controls.Add(this.dgvHistory);
            this.grpHistory.Font = new System.Drawing.Font("Verdana", 10F);
            this.grpHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.grpHistory.Location = new System.Drawing.Point(601, 201);
            this.grpHistory.Margin = new System.Windows.Forms.Padding(2);
            this.grpHistory.Name = "grpHistory";
            this.grpHistory.Padding = new System.Windows.Forms.Padding(2);
            this.grpHistory.Size = new System.Drawing.Size(600, 244);
            this.grpHistory.TabIndex = 10;
            this.grpHistory.TabStop = false;
            this.grpHistory.Text = "Application History";
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.ColumnHeadersHeight = 29;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(2, 19);
            this.dgvHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersVisible = false;
            this.dgvHistory.RowHeadersWidth = 51;
            this.dgvHistory.Size = new System.Drawing.Size(596, 223);
            this.dgvHistory.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(13, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 17;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1087, 9);
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
            this.panel1.Location = new System.Drawing.Point(3, 36);
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
            this.panel2.Controls.Add(this.button1);
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
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click_1);
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
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
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
            // frmApplicationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpHistory);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblStep1Text);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep2Text);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep3Text);
            this.Controls.Add(this.lblStep4);
            this.Controls.Add(this.lblStep4Text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.MinimizeBox = false;
            this.Name = "frmApplicationStatus";
            this.Text = "Application Status";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmApplicationStatus_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep4;
        private System.Windows.Forms.Label lblStep1Text;
        private System.Windows.Forms.Label lblStep2Text;
        private System.Windows.Forms.Label lblStep3Text;
        private System.Windows.Forms.Label lblStep4Text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grpHistory;
        private System.Windows.Forms.DataGridView dgvHistory;
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