namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicantDashboard
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
            this.components = new System.ComponentModel.Container();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.btnJobVacancies = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMissingDocs = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblUpdates = new System.Windows.Forms.Label();
            this.btnMyApplication = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1168, 635);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 36);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Sienna;
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(21, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(230, 233);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Status";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(8, 24);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 18);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status: --";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox2.Controls.Add(this.lblMissingDocs);
            this.groupBox2.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(277, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(230, 233);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Documents";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMissingDocs
            // 
            this.lblMissingDocs.AutoSize = true;
            this.lblMissingDocs.BackColor = System.Drawing.Color.Transparent;
            this.lblMissingDocs.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissingDocs.ForeColor = System.Drawing.SystemColors.Window;
            this.lblMissingDocs.Location = new System.Drawing.Point(8, 24);
            this.lblMissingDocs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMissingDocs.Name = "lblMissingDocs";
            this.lblMissingDocs.Size = new System.Drawing.Size(177, 18);
            this.lblMissingDocs.TabIndex = 0;
            this.lblMissingDocs.Text = "Missing Document Count: --";
            this.lblMissingDocs.Click += new System.EventHandler(this.lblMissingDocs_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblSchedule);
            this.groupBox3.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(879, 123);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(461, 194);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interview Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upcoming Interview: 0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.BackColor = System.Drawing.Color.Transparent;
            this.lblSchedule.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSchedule.Location = new System.Drawing.Point(8, 49);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(106, 18);
            this.lblSchedule.TabIndex = 1;
            this.lblSchedule.Text = "No schedule yet.";
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.ForestGreen;
            this.groupBox4.Controls.Add(this.lblUpdates);
            this.groupBox4.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(879, 342);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(461, 211);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recent Updates";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblUpdates
            // 
            this.lblUpdates.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdates.Font = new System.Drawing.Font("Playfair Display", 9.749998F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdates.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUpdates.Location = new System.Drawing.Point(8, 18);
            this.lblUpdates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(436, 163);
            this.lblUpdates.TabIndex = 0;
            this.lblUpdates.Text = "RECENT UPDATES:";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Sienna;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1365, 57);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnChangePass);
            this.panel2.Controls.Add(this.btnViewStatus);
            this.panel2.Controls.Add(this.btnProfile);
            this.panel2.Controls.Add(this.btnMyApplication);
            this.panel2.Controls.Add(this.btnJobVacancies);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1359, 50);
            this.panel2.TabIndex = 14;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1086, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 23);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "Time and Date";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(2, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "My Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmApplicantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::HRApplicantSystem.Properties.Resources.key;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogout);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "frmApplicantDashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmApplicantDashboard_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.Button btnJobVacancies;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMissingDocs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblUpdates;
        private System.Windows.Forms.Button btnMyApplication;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}