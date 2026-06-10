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
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPositions = new System.Windows.Forms.Button();
            this.btnEmploymentTypes = new System.Windows.Forms.Button();
            this.btnRequirementTypes = new System.Windows.Forms.Button();
            this.btnInterviewTypes = new System.Windows.Forms.Button();
            this.btnAssessmentTypes = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepartments
            // 
            this.btnDepartments.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnDepartments.Location = new System.Drawing.Point(80, 149);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(208, 47);
            this.btnDepartments.TabIndex = 0;
            this.btnDepartments.Text = "btnDepartments";
            this.btnDepartments.UseVisualStyleBackColor = true;
            this.btnDepartments.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPositions
            // 
            this.btnPositions.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnPositions.Location = new System.Drawing.Point(80, 202);
            this.btnPositions.Name = "btnPositions";
            this.btnPositions.Size = new System.Drawing.Size(208, 47);
            this.btnPositions.TabIndex = 1;
            this.btnPositions.Text = "btnPositions";
            this.btnPositions.UseVisualStyleBackColor = true;
            // 
            // btnEmploymentTypes
            // 
            this.btnEmploymentTypes.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnEmploymentTypes.Location = new System.Drawing.Point(80, 256);
            this.btnEmploymentTypes.Name = "btnEmploymentTypes";
            this.btnEmploymentTypes.Size = new System.Drawing.Size(208, 47);
            this.btnEmploymentTypes.TabIndex = 2;
            this.btnEmploymentTypes.Text = "btnEmploymentTypes";
            this.btnEmploymentTypes.UseVisualStyleBackColor = true;
            // 
            // btnRequirementTypes
            // 
            this.btnRequirementTypes.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnRequirementTypes.Location = new System.Drawing.Point(80, 309);
            this.btnRequirementTypes.Name = "btnRequirementTypes";
            this.btnRequirementTypes.Size = new System.Drawing.Size(208, 47);
            this.btnRequirementTypes.TabIndex = 3;
            this.btnRequirementTypes.Text = "btnRequirementTypes";
            this.btnRequirementTypes.UseVisualStyleBackColor = true;
            // 
            // btnInterviewTypes
            // 
            this.btnInterviewTypes.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnInterviewTypes.Location = new System.Drawing.Point(80, 371);
            this.btnInterviewTypes.Name = "btnInterviewTypes";
            this.btnInterviewTypes.Size = new System.Drawing.Size(208, 47);
            this.btnInterviewTypes.TabIndex = 4;
            this.btnInterviewTypes.Text = "btnInterviewTypes";
            this.btnInterviewTypes.UseVisualStyleBackColor = true;
            this.btnInterviewTypes.Click += new System.EventHandler(this.btnInterviewTypes_Click_1);
            // 
            // btnAssessmentTypes
            // 
            this.btnAssessmentTypes.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnAssessmentTypes.Location = new System.Drawing.Point(80, 427);
            this.btnAssessmentTypes.Name = "btnAssessmentTypes";
            this.btnAssessmentTypes.Size = new System.Drawing.Size(208, 47);
            this.btnAssessmentTypes.TabIndex = 5;
            this.btnAssessmentTypes.Text = "btnAssessmentTypes";
            this.btnAssessmentTypes.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnBack.Location = new System.Drawing.Point(80, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(208, 47);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "btnBack";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // frmMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 683);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAssessmentTypes);
            this.Controls.Add(this.btnInterviewTypes);
            this.Controls.Add(this.btnRequirementTypes);
            this.Controls.Add(this.btnEmploymentTypes);
            this.Controls.Add(this.btnPositions);
            this.Controls.Add(this.btnDepartments);
            this.Name = "frmMaintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.frmMaintenance_Load);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnPositions;
        private System.Windows.Forms.Button btnEmploymentTypes;
        private System.Windows.Forms.Button btnRequirementTypes;
        private System.Windows.Forms.Button btnInterviewTypes;
        private System.Windows.Forms.Button btnAssessmentTypes;
        private System.Windows.Forms.Button btnBack;
    }
}
