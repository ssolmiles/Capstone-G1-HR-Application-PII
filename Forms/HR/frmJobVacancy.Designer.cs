namespace HRApplicantSystem.Forms.HR
{
    partial class frmJobVacancy
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstVacancies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.Button btnDocuments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstVacancies = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Job Vacancy Management";
            // 
            // lstVacancies
            // 
            this.lstVacancies.ItemHeight = 16;
            this.lstVacancies.Location = new System.Drawing.Point(26, 70);
            this.lstVacancies.Name = "lstVacancies";
            this.lstVacancies.Size = new System.Drawing.Size(400, 196);
            this.lstVacancies.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(450, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Vacancy";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(450, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Vacancy";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close Vacancy";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(450, 180);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(75, 23);
            this.btnReopen.TabIndex = 5;
            this.btnReopen.Text = "Reopen Vacancy";
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnQualifications
            // 
            this.btnQualifications.Location = new System.Drawing.Point(450, 220);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(75, 23);
            this.btnQualifications.TabIndex = 6;
            this.btnQualifications.Text = "Define Qualifications";
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.Location = new System.Drawing.Point(450, 260);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnDocuments.TabIndex = 7;
            this.btnDocuments.Text = "Define Documents";
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // frmJobVacancy
            // 
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstVacancies);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnQualifications);
            this.Controls.Add(this.btnDocuments);
            this.Name = "frmJobVacancy";
            this.Text = "Job Vacancy Management";
            this.ResumeLayout(false);

        }
        #endregion
    }
}
