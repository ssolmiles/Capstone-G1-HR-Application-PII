namespace HRApplicantSystem.Forms
{
    partial class frmRoleSelection
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblApplicantHead = new System.Windows.Forms.Label();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.btnHR = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubtitle.Font = new System.Drawing.Font("Chelsea Market", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSubtitle.Location = new System.Drawing.Point(311, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(777, 44);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Please select how you want to continue";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // lblApplicantHead
            // 
            this.lblApplicantHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblApplicantHead.Font = new System.Drawing.Font("Chelsea Market", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantHead.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblApplicantHead.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblApplicantHead.Location = new System.Drawing.Point(155, 542);
            this.lblApplicantHead.Name = "lblApplicantHead";
            this.lblApplicantHead.Size = new System.Drawing.Size(310, 30);
            this.lblApplicantHead.TabIndex = 1;
            this.lblApplicantHead.Text = "APPLICANT";
            this.lblApplicantHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApplicant
            // 
            this.btnApplicant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplicant.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnApplicant.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicant.BackgroundImage = global::HRApplicantSystem.Properties.Resources.face;
            this.btnApplicant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.FlatAppearance.BorderSize = 0;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplicant.ForeColor = System.Drawing.Color.Transparent;
            this.btnApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicant.Location = new System.Drawing.Point(176, 325);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(270, 214);
            this.btnApplicant.TabIndex = 3;
            this.btnApplicant.UseVisualStyleBackColor = false;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // btnHR
            // 
            this.btnHR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHR.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHR.BackColor = System.Drawing.Color.Transparent;
            this.btnHR.BackgroundImage = global::HRApplicantSystem.Properties.Resources.eyes;
            this.btnHR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHR.FlatAppearance.BorderSize = 0;
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHR.ForeColor = System.Drawing.Color.Transparent;
            this.btnHR.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHR.Location = new System.Drawing.Point(940, 316);
            this.btnHR.Name = "btnHR";
            this.btnHR.Size = new System.Drawing.Size(267, 223);
            this.btnHR.TabIndex = 3;
            this.btnHR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHR.UseVisualStyleBackColor = false;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);
            // 
            // lblFooter
            // 
            this.lblFooter.AutoSize = true;
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblFooter.Location = new System.Drawing.Point(933, 740);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(159, 15);
            this.lblFooter.TabIndex = 4;
            this.lblFooter.Text = "© 2025 HR Applicant System";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Chelsea Market", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(921, 542);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "HR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmRoleSelection
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::HRApplicantSystem.Properties.Resources.key;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplicantHead);
            this.Controls.Add(this.btnHR);
            this.Controls.Add(this.btnApplicant);
            this.Controls.Add(this.lblFooter);
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "frmRoleSelection";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Applicant System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRoleSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblApplicantHead;
        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.Label label1;
    }
}