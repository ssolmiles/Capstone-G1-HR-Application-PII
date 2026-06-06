namespace HRApplicantSystem.Forms.HR
{
    partial class frmHiringDecision
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblDecision;
        private System.Windows.Forms.Button btnHire;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.TextBox txtFinalRemarks;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblDecision = new System.Windows.Forms.Label();
            this.btnHire = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.txtFinalRemarks = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDecision
            // 
            this.lblDecision.AutoSize = true;
            this.lblDecision.Location = new System.Drawing.Point(20, 20);
            this.lblDecision.Name = "lblDecision";
            this.lblDecision.Size = new System.Drawing.Size(148, 16);
            this.lblDecision.TabIndex = 0;
            this.lblDecision.Text = "Final Decision: Pending";
            // 
            // btnHire
            // 
            this.btnHire.Location = new System.Drawing.Point(23, 191);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(75, 23);
            this.btnHire.TabIndex = 1;
            this.btnHire.Text = "Hire";
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(104, 191);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            // 
            // txtFinalRemarks
            // 
            this.txtFinalRemarks.Location = new System.Drawing.Point(23, 67);
            this.txtFinalRemarks.Multiline = true;
            this.txtFinalRemarks.Name = "txtFinalRemarks";
            this.txtFinalRemarks.Size = new System.Drawing.Size(300, 100);
            this.txtFinalRemarks.TabIndex = 3;
            this.txtFinalRemarks.Text = "Enter final remarks here...";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(272, 198);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 16);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: Pending";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(297, 233);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            // 
            // frmHiringDecision
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblDecision);
            this.Controls.Add(this.btnHire);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.txtFinalRemarks);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Name = "frmHiringDecision";
            this.Text = "Final Hiring Decision";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
