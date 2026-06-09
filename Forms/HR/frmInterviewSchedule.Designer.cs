namespace HRApplicantSystem.Forms.HR
{
    partial class frmInterviewSchedule
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.ComboBox cmbMode;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;

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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.cmbMode = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(20, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDate.TabIndex = 0;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(20, 72);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(200, 22);
            this.dtpTime.TabIndex = 1;
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(20, 112);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.Size = new System.Drawing.Size(217, 22);
            this.txtInterviewer.TabIndex = 2;
            this.txtInterviewer.Text = "TO BE ASSIGNED";
            // 
            // cmbMode
            // 
            this.cmbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMode.Items.AddRange(new object[] {
            "Select Mode",
            "Online",
            "Onsite"});
            this.cmbMode.Location = new System.Drawing.Point(20, 140);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(153, 24);
            this.cmbMode.TabIndex = 3;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(20, 181);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(250, 22);
            this.txtLocation.TabIndex = 4;
            this.txtLocation.Text = "To be Announced";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 220);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 16);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: Pending";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(20, 260);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(110, 23);
            this.btnSchedule.TabIndex = 6;
            this.btnSchedule.Text = "Schedule";
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(136, 260);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(101, 23);
            this.btnComplete.TabIndex = 7;
            this.btnComplete.Text = "Mark Completed";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(116, 300);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel Interview";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(20, 300);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 23);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next → Evaluation";
            // 
            // frmInterviewSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtInterviewer);
            this.Controls.Add(this.cmbMode);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNext);
            this.Name = "frmInterviewSchedule";
            this.Text = "Interview Scheduling";
            this.Load += new System.EventHandler(this.frmInterviewSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
