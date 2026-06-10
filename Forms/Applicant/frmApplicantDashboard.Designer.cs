using HRApplicantSystem.Helpers;
namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicantDashboard
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMissingDocs = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblUpdates = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewStatus = new System.Windows.Forms.Button();
            this.txtWelcome = new System.Windows.Forms.TextBox();
            this.lblUpcomingInterview = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 23);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblMissingDocs
            // 
            this.lblMissingDocs.AutoSize = true;
            this.lblMissingDocs.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblMissingDocs.Location = new System.Drawing.Point(23, 259);
            this.lblMissingDocs.Name = "lblMissingDocs";
            this.lblMissingDocs.Size = new System.Drawing.Size(196, 23);
            this.lblMissingDocs.TabIndex = 1;
            this.lblMissingDocs.Text = "Missing Documents";
            this.lblMissingDocs.Click += new System.EventHandler(this.lblMissingDocs_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblSchedule.Location = new System.Drawing.Point(456, 259);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(97, 23);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule";
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // lblUpdates
            // 
            this.lblUpdates.AutoSize = true;
            this.lblUpdates.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblUpdates.Location = new System.Drawing.Point(23, 414);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(87, 23);
            this.lblUpdates.TabIndex = 3;
            this.lblUpdates.Text = "Updates";
            this.lblUpdates.Click += new System.EventHandler(this.lblUpdates_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Location = new System.Drawing.Point(829, 64);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(136, 38);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Location = new System.Drawing.Point(829, 109);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(136, 38);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogout.Location = new System.Drawing.Point(793, 404);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 48);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Location = new System.Drawing.Point(829, 154);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(136, 39);
            this.btnViewStatus.TabIndex = 7;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = true;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // txtWelcome
            // 
            this.txtWelcome.BackColor = System.Drawing.SystemColors.Info;
            this.txtWelcome.Font = new System.Drawing.Font("Verdana", 30F);
            this.txtWelcome.Location = new System.Drawing.Point(11, 11);
            this.txtWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(586, 56);
            this.txtWelcome.TabIndex = 8;
            this.txtWelcome.Text = "Welcome Applicant [Name]!";
            // 
            // lblUpcomingInterview
            // 
            this.lblUpcomingInterview.AutoSize = true;
            this.lblUpcomingInterview.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblUpcomingInterview.Location = new System.Drawing.Point(456, 109);
            this.lblUpcomingInterview.Name = "lblUpcomingInterview";
            this.lblUpcomingInterview.Size = new System.Drawing.Size(203, 23);
            this.lblUpcomingInterview.TabIndex = 9;
            this.lblUpcomingInterview.Text = "Upcoming Interview";
            this.lblUpcomingInterview.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmApplicantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 476);
            this.Controls.Add(this.lblUpcomingInterview);
            this.Controls.Add(this.txtWelcome);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblUpdates);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblMissingDocs);
            this.Controls.Add(this.lblStatus);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmApplicantDashboard";
            this.Text = "frmApplicantDashboard";
            this.Load += new System.EventHandler(this.frmApplicantDashboard_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMissingDocs;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblUpdates;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewStatus;
        private System.Windows.Forms.TextBox txtWelcome;
        private System.Windows.Forms.Label lblUpcomingInterview;
    }
}