namespace HRApplicantSystem.Forms.Maintenance
{
    partial class frmJobVacancyManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboEmploymentType = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQualifications = new System.Windows.Forms.TextBox();
            this.txtSlots = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvVacancies = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReopen = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(43, 41);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(123, 21);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.Text = "cboDepartment";
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(43, 93);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(123, 21);
            this.cboPosition.TabIndex = 1;
            this.cboPosition.Text = "cboPosition";
            // 
            // cboEmploymentType
            // 
            this.cboEmploymentType.FormattingEnabled = true;
            this.cboEmploymentType.Location = new System.Drawing.Point(43, 146);
            this.cboEmploymentType.Name = "cboEmploymentType";
            this.cboEmploymentType.Size = new System.Drawing.Size(123, 21);
            this.cboEmploymentType.TabIndex = 2;
            this.cboEmploymentType.Text = "cboEmploymentType";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(43, 212);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 28);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Job Description";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtQualifications
            // 
            this.txtQualifications.Location = new System.Drawing.Point(43, 262);
            this.txtQualifications.Multiline = true;
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.Size = new System.Drawing.Size(192, 28);
            this.txtQualifications.TabIndex = 4;
            this.txtQualifications.Text = "Job Qualifications";
            this.txtQualifications.TextChanged += new System.EventHandler(this.txtQualifications_TextChanged);
            // 
            // txtSlots
            // 
            this.txtSlots.Location = new System.Drawing.Point(43, 318);
            this.txtSlots.Name = "txtSlots";
            this.txtSlots.Size = new System.Drawing.Size(192, 20);
            this.txtSlots.TabIndex = 5;
            this.txtSlots.Text = "Slots Available";
            this.txtSlots.TextChanged += new System.EventHandler(this.txtSlots_TextChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 14;
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(605, 41);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.RowHeadersWidth = 51;
            this.dgvVacancies.RowTemplate.Height = 24;
            this.dgvVacancies.Size = new System.Drawing.Size(1157, 554);
            this.dgvVacancies.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(414, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Vacancy";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(414, 93);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close Vacancy";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(414, 139);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(132, 28);
            this.btnReopen.TabIndex = 10;
            this.btnReopen.Text = "Reopen Vacancy";
            this.btnReopen.UseVisualStyleBackColor = true;
            this.btnReopen.Click += new System.EventHandler(this.btnReopen_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(436, 567);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(132, 28);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            
            this.checkedListBox1.Location = new System.Drawing.Point(344, 201);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(175, 109);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // frmJobVacancyManagement
            // 
            this.ClientSize = new System.Drawing.Size(1902, 845);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReopen);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvVacancies);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtSlots);
            this.Controls.Add(this.txtQualifications);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cboEmploymentType);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.cboDepartment);
            this.Name = "frmJobVacancyManagement";
            this.Text = "Job Vacancy Management";
            this.Load += new System.EventHandler(this.frmJobVacancyManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboEmploymentType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQualifications;
        private System.Windows.Forms.TextBox txtSlots;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvVacancies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReopen;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}