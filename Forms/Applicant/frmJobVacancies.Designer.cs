namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmJobVacancies
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listViewJobs = new System.Windows.Forms.ListView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(11, 112);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Job Vacancies";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(13, 146);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(444, 16);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Browse open positions and review requirements before you apply";
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBack.Location = new System.Drawing.Point(1079, 140);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 29);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "← Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtSearch.Location = new System.Drawing.Point(11, 190);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(256, 25);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(274, 189);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listViewJobs
            // 
            this.listViewJobs.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.listViewJobs.FullRowSelect = true;
            this.listViewJobs.GridLines = true;
            this.listViewJobs.HideSelection = false;
            this.listViewJobs.Location = new System.Drawing.Point(12, 221);
            this.listViewJobs.Margin = new System.Windows.Forms.Padding(2);
            this.listViewJobs.Name = "listViewJobs";
            this.listViewJobs.Size = new System.Drawing.Size(1321, 312);
            this.listViewJobs.TabIndex = 2;
            this.listViewJobs.UseCompatibleStateImageBehavior = false;
            this.listViewJobs.View = System.Windows.Forms.View.Details;
            this.listViewJobs.SelectedIndexChanged += new System.EventHandler(this.listViewJobs_SelectedIndexChanged);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnViewDetails.Location = new System.Drawing.Point(15, 569);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(152, 32);
            this.btnViewDetails.TabIndex = 3;
            this.btnViewDetails.Text = "View Full Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(172, 569);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 32);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // cboDepartment
            // 
            this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartment.Font = new System.Drawing.Font("Verdana", 10F);
            this.cboDepartment.Location = new System.Drawing.Point(364, 190);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(166, 24);
            this.cboDepartment.TabIndex = 2;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.OldLace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Chelsea Market", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 31);
            this.textBox1.TabIndex = 17;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(1086, 13);
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
            this.panel1.Location = new System.Drawing.Point(2, 40);
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
            // frmJobVacancies
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
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.listViewJobs);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.cboDepartment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "frmJobVacancies";
            this.Text = "Job Vacancies";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmJobVacancies_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listViewJobs;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnApply;
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