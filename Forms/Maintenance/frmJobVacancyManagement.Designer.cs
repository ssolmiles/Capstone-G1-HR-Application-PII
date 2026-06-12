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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancies)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(43, 41);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(123, 24);
            this.cboDepartment.TabIndex = 0;
            this.cboDepartment.Text = "cboDepartment";
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.cboDepartment_SelectedIndexChanged);
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(43, 93);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(123, 24);
            this.cboPosition.TabIndex = 1;
            this.cboPosition.Text = "cboPosition";
            // 
            // cboEmploymentType
            // 
            this.cboEmploymentType.FormattingEnabled = true;
            this.cboEmploymentType.Location = new System.Drawing.Point(43, 146);
            this.cboEmploymentType.Name = "cboEmploymentType";
            this.cboEmploymentType.Size = new System.Drawing.Size(123, 24);
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
            this.txtDescription.Text = "txtDescription";
            // 
            // txtQualifications
            // 
            this.txtQualifications.Location = new System.Drawing.Point(43, 262);
            this.txtQualifications.Multiline = true;
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.Size = new System.Drawing.Size(192, 28);
            this.txtQualifications.TabIndex = 4;
            this.txtQualifications.Text = "txtQualifications";
            // 
            // txtSlots
            // 
            this.txtSlots.Location = new System.Drawing.Point(43, 318);
            this.txtSlots.Name = "txtSlots";
            this.txtSlots.Size = new System.Drawing.Size(102, 22);
            this.txtSlots.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(43, 375);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(102, 22);
            this.txtSearch.TabIndex = 6;
            // 
            // dgvVacancies
            // 
            this.dgvVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancies.Location = new System.Drawing.Point(52, 445);
            this.dgvVacancies.Name = "dgvVacancies";
            this.dgvVacancies.RowHeadersWidth = 51;
            this.dgvVacancies.RowTemplate.Height = 24;
            this.dgvVacancies.Size = new System.Drawing.Size(242, 156);
            this.dgvVacancies.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(432, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "button1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(432, 130);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(132, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "button2";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnReopen
            // 
            this.btnReopen.Location = new System.Drawing.Point(432, 176);
            this.btnReopen.Name = "btnReopen";
            this.btnReopen.Size = new System.Drawing.Size(132, 28);
            this.btnReopen.TabIndex = 10;
            this.btnReopen.Text = "button3";
            this.btnReopen.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(432, 222);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "button4";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(432, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 28);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "button5";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmJobVacancyManagement
            // 
            this.ClientSize = new System.Drawing.Size(1066, 793);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}