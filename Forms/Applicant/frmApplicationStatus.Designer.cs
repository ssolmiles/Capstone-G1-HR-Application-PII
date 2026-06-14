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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(322, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Application Status";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblCurrentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.lblCurrentStatus.Location = new System.Drawing.Point(20, 55);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(202, 23);
            this.lblCurrentStatus.TabIndex = 1;
            this.lblCurrentStatus.Text = "Current Status: --";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(8, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(154, 23);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Final Result: ";
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblRemarks.Location = new System.Drawing.Point(8, 25);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(100, 18);
            this.lblRemarks.TabIndex = 0;
            this.lblRemarks.Text = "Remarks: --";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblSchedule.Location = new System.Drawing.Point(6, 34);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(220, 18);
            this.lblSchedule.TabIndex = 0;
            this.lblSchedule.Text = "Schedule: Not yet scheduled";
            // 
            // lblStep1
            // 
            this.lblStep1.BackColor = System.Drawing.Color.Gray;
            this.lblStep1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep1.Location = new System.Drawing.Point(26, 130);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(20, 20);
            this.lblStep1.TabIndex = 2;
            // 
            // lblStep2
            // 
            this.lblStep2.BackColor = System.Drawing.Color.Gray;
            this.lblStep2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep2.Location = new System.Drawing.Point(26, 170);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(20, 20);
            this.lblStep2.TabIndex = 4;
            // 
            // lblStep3
            // 
            this.lblStep3.BackColor = System.Drawing.Color.Gray;
            this.lblStep3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep3.Location = new System.Drawing.Point(26, 210);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(20, 20);
            this.lblStep3.TabIndex = 6;
            // 
            // lblStep4
            // 
            this.lblStep4.BackColor = System.Drawing.Color.Gray;
            this.lblStep4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStep4.Location = new System.Drawing.Point(26, 250);
            this.lblStep4.Name = "lblStep4";
            this.lblStep4.Size = new System.Drawing.Size(20, 20);
            this.lblStep4.TabIndex = 8;
            // 
            // lblStep1Text
            // 
            this.lblStep1Text.AutoSize = true;
            this.lblStep1Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep1Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep1Text.Location = new System.Drawing.Point(54, 132);
            this.lblStep1Text.Name = "lblStep1Text";
            this.lblStep1Text.Size = new System.Drawing.Size(168, 18);
            this.lblStep1Text.TabIndex = 3;
            this.lblStep1Text.Text = "Application Submitted";
            // 
            // lblStep2Text
            // 
            this.lblStep2Text.AutoSize = true;
            this.lblStep2Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep2Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep2Text.Location = new System.Drawing.Point(54, 172);
            this.lblStep2Text.Name = "lblStep2Text";
            this.lblStep2Text.Size = new System.Drawing.Size(110, 18);
            this.lblStep2Text.TabIndex = 5;
            this.lblStep2Text.Text = "Under Review";
            // 
            // lblStep3Text
            // 
            this.lblStep3Text.AutoSize = true;
            this.lblStep3Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep3Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep3Text.Location = new System.Drawing.Point(54, 212);
            this.lblStep3Text.Name = "lblStep3Text";
            this.lblStep3Text.Size = new System.Drawing.Size(77, 18);
            this.lblStep3Text.TabIndex = 7;
            this.lblStep3Text.Text = "Interview";
            // 
            // lblStep4Text
            // 
            this.lblStep4Text.AutoSize = true;
            this.lblStep4Text.Font = new System.Drawing.Font("Verdana", 9F);
            this.lblStep4Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblStep4Text.Location = new System.Drawing.Point(54, 252);
            this.lblStep4Text.Name = "lblStep4Text";
            this.lblStep4Text.Size = new System.Drawing.Size(107, 18);
            this.lblStep4Text.TabIndex = 9;
            this.lblStep4Text.Text = "Final Decision";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(499, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 297);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HR Remarks";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSchedule);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(44, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 198);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interview Schedule";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(471, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 198);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Final Result";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(1535, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back to Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmApplicationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.lblTitle);
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
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApplicationStatus";
            this.Text = "Application Status";
            this.Load += new System.EventHandler(this.frmApplicationStatus_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
    }
}