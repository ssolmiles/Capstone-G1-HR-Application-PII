namespace HRApplicantSystem.Forms.Maintenance
{
    partial class frmMaintenance
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
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnEmploymentTypes = new System.Windows.Forms.Button();
            this.btnRequirementTypes = new System.Windows.Forms.Button();
            this.btnInterviewTypes = new System.Windows.Forms.Button();
            this.btnAssessmentTypes = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(472, 42);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Maintenance";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(474, 75);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(239, 15);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Manage lookup data used across the system";
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDepartments.ForeColor = System.Drawing.Color.White;
            this.btnDepartments.Location = new System.Drawing.Point(567, 139);
            this.btnDepartments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(217, 32);
            this.btnDepartments.TabIndex = 2;
            this.btnDepartments.Text = "Departments";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnPositions
            // 
            this.btnPositions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnPositions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPositions.ForeColor = System.Drawing.Color.White;
            this.btnPositions.Location = new System.Drawing.Point(567, 180);
            this.btnPositions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(217, 32);
            this.btnPositions.TabIndex = 3;
            this.btnPositions.Text = "Positions";
            this.btnPositions.UseVisualStyleBackColor = false;
            this.btnPositions.Click += new System.EventHandler(this.btnPositions_Click);
            // 
            // btnEmploymentTypes
            // 
            this.btnEmploymentTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnEmploymentTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploymentTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmploymentTypes.ForeColor = System.Drawing.Color.White;
            this.btnEmploymentTypes.Location = new System.Drawing.Point(567, 220);
            this.btnEmploymentTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmploymentTypes.Name = "btnEmploymentTypes";
            this.btnEmploymentTypes.Size = new System.Drawing.Size(217, 32);
            this.btnEmploymentTypes.TabIndex = 4;
            this.btnEmploymentTypes.Text = "Employment Types";
            this.btnEmploymentTypes.UseVisualStyleBackColor = false;
            this.btnEmploymentTypes.Click += new System.EventHandler(this.btnEmploymentTypes_Click);
            // 
            // btnRequirementTypes
            // 
            this.btnRequirementTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnRequirementTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequirementTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequirementTypes.ForeColor = System.Drawing.Color.White;
            this.btnRequirementTypes.Location = new System.Drawing.Point(567, 261);
            this.btnRequirementTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRequirementTypes.Name = "btnRequirementTypes";
            this.btnRequirementTypes.Size = new System.Drawing.Size(217, 32);
            this.btnRequirementTypes.TabIndex = 5;
            this.btnRequirementTypes.Text = "Requirement Types";
            this.btnRequirementTypes.UseVisualStyleBackColor = false;
            this.btnRequirementTypes.Click += new System.EventHandler(this.btnRequirementTypes_Click);
            // 
            // btnInterviewTypes
            // 
            this.btnInterviewTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnInterviewTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterviewTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInterviewTypes.ForeColor = System.Drawing.Color.White;
            this.btnInterviewTypes.Location = new System.Drawing.Point(567, 301);
            this.btnInterviewTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInterviewTypes.Name = "btnInterviewTypes";
            this.btnInterviewTypes.Size = new System.Drawing.Size(217, 32);
            this.btnInterviewTypes.TabIndex = 6;
            this.btnInterviewTypes.Text = "Interview Types";
            this.btnInterviewTypes.UseVisualStyleBackColor = false;
            this.btnInterviewTypes.Click += new System.EventHandler(this.btnInterviewTypes_Click);
            // 
            // btnAssessmentTypes
            // 
            this.btnAssessmentTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnAssessmentTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssessmentTypes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAssessmentTypes.ForeColor = System.Drawing.Color.White;
            this.btnAssessmentTypes.Location = new System.Drawing.Point(567, 342);
            this.btnAssessmentTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAssessmentTypes.Name = "btnAssessmentTypes";
            this.btnAssessmentTypes.Size = new System.Drawing.Size(217, 32);
            this.btnAssessmentTypes.TabIndex = 7;
            this.btnAssessmentTypes.Text = "Assessment Types";
            this.btnAssessmentTypes.UseVisualStyleBackColor = false;
            this.btnAssessmentTypes.Click += new System.EventHandler(this.btnAssessmentTypes_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUserManagement.ForeColor = System.Drawing.Color.White;
            this.btnUserManagement.Location = new System.Drawing.Point(567, 383);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(217, 32);
            this.btnUserManagement.TabIndex = 8;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnBack.Location = new System.Drawing.Point(567, 431);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(217, 32);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.btnDepartments);
            this.Controls.Add(this.btnPositions);
            this.Controls.Add(this.btnEmploymentTypes);
            this.Controls.Add(this.btnRequirementTypes);
            this.Controls.Add(this.btnInterviewTypes);
            this.Controls.Add(this.btnAssessmentTypes);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimizeBox = false;
            this.Name = "frmMaintenance";
            this.Text = "System Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnEmploymentTypes;
        private System.Windows.Forms.Button btnRequirementTypes;
        private System.Windows.Forms.Button btnInterviewTypes;
        private System.Windows.Forms.Button btnAssessmentTypes;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnBack;
    }
}