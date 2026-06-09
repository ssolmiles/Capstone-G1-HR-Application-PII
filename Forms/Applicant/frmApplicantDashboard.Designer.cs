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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(13, 139);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(93, 28);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblMissingDocs
            // 
            this.lblMissingDocs.AutoSize = true;
            this.lblMissingDocs.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblMissingDocs.Location = new System.Drawing.Point(13, 319);
            this.lblMissingDocs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMissingDocs.Name = "lblMissingDocs";
            this.lblMissingDocs.Size = new System.Drawing.Size(342, 29);
            this.lblMissingDocs.TabIndex = 1;
            this.lblMissingDocs.Text = "Missing Documents [count]";
            this.lblMissingDocs.Click += new System.EventHandler(this.lblMissingDocs_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblSchedule.Location = new System.Drawing.Point(608, 319);
            this.lblSchedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(121, 29);
            this.lblSchedule.TabIndex = 2;
            this.lblSchedule.Text = "Schedule";
            this.lblSchedule.Click += new System.EventHandler(this.lblSchedule_Click);
            // 
            // lblUpdates
            // 
            this.lblUpdates.AutoSize = true;
            this.lblUpdates.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblUpdates.Location = new System.Drawing.Point(13, 510);
            this.lblUpdates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(111, 29);
            this.lblUpdates.TabIndex = 3;
            this.lblUpdates.Text = "Updates";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Location = new System.Drawing.Point(1105, 79);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(181, 47);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Location = new System.Drawing.Point(1105, 134);
            this.btnChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(181, 47);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogout.Location = new System.Drawing.Point(1057, 510);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 59);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewStatus
            // 
            this.btnViewStatus.Location = new System.Drawing.Point(1105, 189);
            this.btnViewStatus.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewStatus.Name = "btnViewStatus";
            this.btnViewStatus.Size = new System.Drawing.Size(181, 48);
            this.btnViewStatus.TabIndex = 7;
            this.btnViewStatus.Text = "View Status";
            this.btnViewStatus.UseVisualStyleBackColor = true;
            this.btnViewStatus.Click += new System.EventHandler(this.btnViewStatus_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 18F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textBox1.Location = new System.Drawing.Point(18, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 44);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "Welcome Applicant [Name]!";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F);
            this.label1.Location = new System.Drawing.Point(608, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Upcoming Interview [count]";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label2.Location = new System.Drawing.Point(14, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(605, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "This is your Dashboard. Check your Dashboard for more info!";
            // 
            // frmApplicantDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 696);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnViewStatus);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblUpdates);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblMissingDocs);
            this.Controls.Add(this.lblStatus);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}