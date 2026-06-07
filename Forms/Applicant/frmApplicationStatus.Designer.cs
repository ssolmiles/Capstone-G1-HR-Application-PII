namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicationStatus
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
            this.lblStep1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.lblStep4 = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep1.Location = new System.Drawing.Point(37, 38);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(148, 15);
            this.lblStep1.TabIndex = 0;
            this.lblStep1.Text = "Step 1: Application Submitted";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep2.Location = new System.Drawing.Point(37, 58);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(114, 15);
            this.lblStep2.TabIndex = 1;
            this.lblStep2.Text = "Step 2: Under Review";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep3.Location = new System.Drawing.Point(37, 78);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(89, 15);
            this.lblStep3.TabIndex = 2;
            this.lblStep3.Text = "Step 3: Interview";
            // 
            // lblStep4
            // 
            this.lblStep4.AutoSize = true;
            this.lblStep4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep4.Location = new System.Drawing.Point(37, 98);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(112, 15);
            this.lblStep4.TabIndex = 3;
            this.lblStep4.Text = "Step 4: Final Decision";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentStatus.Location = new System.Drawing.Point(37, 118);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(76, 15);
            this.lblCurrentStatus.TabIndex = 4;
            this.lblCurrentStatus.Text = "Current Status";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRemarks.Location = new System.Drawing.Point(37, 138);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(51, 15);
            this.lblRemarks.TabIndex = 5;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSchedule.Location = new System.Drawing.Point(37, 158);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(54, 15);
            this.lblSchedule.TabIndex = 6;
            this.lblSchedule.Text = "Schedule";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(37, 177);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 15);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // frmApplicationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.lblStep4);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.lblStep1);
            this.Name = "frmApplicationStatus";
            this.Text = "frmApplicationStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.Label lblStep4;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblResult;
    }
}