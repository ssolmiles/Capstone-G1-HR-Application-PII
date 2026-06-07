namespace HRApplicantSystem.Forms.HR
{
    partial class frmReports
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.ListBox lstReports;
        private System.Windows.Forms.Button btnNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.lstReports = new System.Windows.Forms.ListBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "HR Reports";
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Location = new System.Drawing.Point(20, 60);
            // 
            // lstReports
            // 
            this.lstReports.Location = new System.Drawing.Point(20, 100);
            this.lstReports.Size = new System.Drawing.Size(300, 150);
            // 
            // btnNext
            // 
            this.btnNext.Text = "Next → Dashboard";
            this.btnNext.Location = new System.Drawing.Point(20, 270);
            // 
            // frmReports
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.lstReports);
            this.Controls.Add(this.btnNext);
            this.Text = "Reports";
            this.ResumeLayout(false);
        }
    }
}
