namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRViewDocuments
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
            this.dgvDocuments = new System.Windows.Forms.DataGridView();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblDocCount = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnRejectDoc = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDocuments
            // 
            this.dgvDocuments.AllowUserToAddRows = false;
            this.dgvDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocuments.Location = new System.Drawing.Point(13, 39);
            this.dgvDocuments.Name = "dgvDocuments";
            this.dgvDocuments.ReadOnly = true;
            this.dgvDocuments.RowHeadersVisible = false;
            this.dgvDocuments.RowHeadersWidth = 51;
            this.dgvDocuments.RowTemplate.Height = 24;
            this.dgvDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocuments.Size = new System.Drawing.Size(437, 261);
            this.dgvDocuments.TabIndex = 0;
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(496, 68);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(44, 16);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "label1";
            // 
            // lblDocCount
            // 
            this.lblDocCount.AutoSize = true;
            this.lblDocCount.Location = new System.Drawing.Point(496, 113);
            this.lblDocCount.Name = "lblDocCount";
            this.lblDocCount.Size = new System.Drawing.Size(44, 16);
            this.lblDocCount.TabIndex = 2;
            this.lblDocCount.Text = "label2";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(553, 182);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(184, 34);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "button1";
            this.btnOpen.UseVisualStyleBackColor = true;
            // 
            // btnRejectDoc
            // 
            this.btnRejectDoc.Location = new System.Drawing.Point(553, 238);
            this.btnRejectDoc.Name = "btnRejectDoc";
            this.btnRejectDoc.Size = new System.Drawing.Size(184, 34);
            this.btnRejectDoc.TabIndex = 4;
            this.btnRejectDoc.Text = "button2";
            this.btnRejectDoc.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(553, 290);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(184, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "button3";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(553, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(184, 34);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "button4";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmHRViewDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRejectDoc);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.lblDocCount);
            this.Controls.Add(this.lblApplicantName);
            this.Controls.Add(this.dgvDocuments);
            this.Name = "frmHRViewDocuments";
            this.Text = "frmHRViewDocuments";
            this.Load += new System.EventHandler(this.frmHRViewDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDocuments;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblDocCount;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnRejectDoc;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
    }
}