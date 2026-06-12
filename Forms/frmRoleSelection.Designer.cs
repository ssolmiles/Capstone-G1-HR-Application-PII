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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlApplicant = new System.Windows.Forms.Panel();
            this.lblApplicantIcon = new System.Windows.Forms.Label();
            this.lblApplicantHead = new System.Windows.Forms.Label();
            this.lblApplicantSub = new System.Windows.Forms.Label();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.pnlHR = new System.Windows.Forms.Panel();
            this.lblHRIcon = new System.Windows.Forms.Label();
            this.lblHRHead = new System.Windows.Forms.Label();
            this.lblHRSub = new System.Windows.Forms.Label();
            this.btnHR = new System.Windows.Forms.Button();
            this.lblFooter = new System.Windows.Forms.Label();

            this.pnlApplicant.SuspendLayout();
            this.pnlHR.SuspendLayout();
            this.SuspendLayout();

            // ── Form ────────────────────────────────────────────
            this.ClientSize = new System.Drawing.Size(860, 540);
            this.Name = "frmRoleSelection";
            this.Text = "HR Applicant System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ── lblTitle ─────────────────────────────────────────
            this.lblTitle.Text = "HR Applicant Portal";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(245, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;

            // ── lblSubtitle ───────────────────────────────────────
            this.lblSubtitle.Text = "Please select how you want to continue";
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(277, 90);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 1;

            // ── pnlApplicant ──────────────────────────────────────
            this.pnlApplicant.Size = new System.Drawing.Size(310, 300);
            this.pnlApplicant.Location = new System.Drawing.Point(80, 155);
            this.pnlApplicant.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.pnlApplicant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlApplicant.Name = "pnlApplicant";
            this.pnlApplicant.TabIndex = 2;

            // ── lblApplicantIcon ──────────────────────────────────
            this.lblApplicantIcon.Text = "👤";
            this.lblApplicantIcon.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.lblApplicantIcon.AutoSize = false;
            this.lblApplicantIcon.Size = new System.Drawing.Size(310, 80);
            this.lblApplicantIcon.Location = new System.Drawing.Point(0, 25);
            this.lblApplicantIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApplicantIcon.Name = "lblApplicantIcon";
            this.lblApplicantIcon.TabIndex = 0;

            // ── lblApplicantHead ──────────────────────────────────
            this.lblApplicantHead.Text = "I am an Applicant";
            this.lblApplicantHead.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblApplicantHead.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.lblApplicantHead.AutoSize = false;
            this.lblApplicantHead.Size = new System.Drawing.Size(310, 30);
            this.lblApplicantHead.Location = new System.Drawing.Point(0, 115);
            this.lblApplicantHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApplicantHead.Name = "lblApplicantHead";
            this.lblApplicantHead.TabIndex = 1;

            // ── lblApplicantSub ───────────────────────────────────
            this.lblApplicantSub.Text = "Browse jobs, apply, and\ntrack your application status";
            this.lblApplicantSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblApplicantSub.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lblApplicantSub.AutoSize = false;
            this.lblApplicantSub.Size = new System.Drawing.Size(270, 50);
            this.lblApplicantSub.Location = new System.Drawing.Point(20, 150);
            this.lblApplicantSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblApplicantSub.Name = "lblApplicantSub";
            this.lblApplicantSub.TabIndex = 2;

            // ── btnApplicant ──────────────────────────────────────
            this.btnApplicant.Text = "Continue as Applicant";
            this.btnApplicant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnApplicant.BackColor = System.Drawing.Color.FromArgb(31, 92, 153);
            this.btnApplicant.ForeColor = System.Drawing.Color.White;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.FlatAppearance.BorderSize = 0;
            this.btnApplicant.Size = new System.Drawing.Size(250, 42);
            this.btnApplicant.Location = new System.Drawing.Point(30, 228);
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.TabIndex = 3;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);

            // ── pnlHR ─────────────────────────────────────────────
            this.pnlHR.Size = new System.Drawing.Size(310, 300);
            this.pnlHR.Location = new System.Drawing.Point(470, 155);
            this.pnlHR.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.pnlHR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHR.Name = "pnlHR";
            this.pnlHR.TabIndex = 3;

            // ── lblHRIcon ─────────────────────────────────────────
            this.lblHRIcon.Text = "🏢";
            this.lblHRIcon.Font = new System.Drawing.Font("Segoe UI", 40F);
            this.lblHRIcon.AutoSize = false;
            this.lblHRIcon.Size = new System.Drawing.Size(310, 80);
            this.lblHRIcon.Location = new System.Drawing.Point(0, 25);
            this.lblHRIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHRIcon.Name = "lblHRIcon";
            this.lblHRIcon.TabIndex = 0;

            // ── lblHRHead ─────────────────────────────────────────
            this.lblHRHead.Text = "I am an HR Staff";
            this.lblHRHead.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHRHead.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.lblHRHead.AutoSize = false;
            this.lblHRHead.Size = new System.Drawing.Size(310, 30);
            this.lblHRHead.Location = new System.Drawing.Point(0, 115);
            this.lblHRHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHRHead.Name = "lblHRHead";
            this.lblHRHead.TabIndex = 1;

            // ── lblHRSub ──────────────────────────────────────────
            this.lblHRSub.Text = "Manage applicants, interviews,\nand hiring decisions";
            this.lblHRSub.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblHRSub.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lblHRSub.AutoSize = false;
            this.lblHRSub.Size = new System.Drawing.Size(270, 50);
            this.lblHRSub.Location = new System.Drawing.Point(20, 150);
            this.lblHRSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHRSub.Name = "lblHRSub";
            this.lblHRSub.TabIndex = 2;

            // ── btnHR ─────────────────────────────────────────────
            this.btnHR.Text = "Continue as HR Staff";
            this.btnHR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHR.BackColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.btnHR.ForeColor = System.Drawing.Color.White;
            this.btnHR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHR.FlatAppearance.BorderSize = 0;
            this.btnHR.Size = new System.Drawing.Size(250, 42);
            this.btnHR.Location = new System.Drawing.Point(30, 228);
            this.btnHR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHR.Name = "btnHR";
            this.btnHR.TabIndex = 3;
            this.btnHR.Click += new System.EventHandler(this.btnHR_Click);

            // ── lblFooter ─────────────────────────────────────────
            this.lblFooter.Text = "© 2025 HR Applicant System";
            this.lblFooter.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(180, 180, 180);
            this.lblFooter.AutoSize = true;
            this.lblFooter.Location = new System.Drawing.Point(355, 490);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.TabIndex = 4;

            // ── Add controls to panels ────────────────────────────
            this.pnlApplicant.Controls.Add(this.lblApplicantIcon);
            this.pnlApplicant.Controls.Add(this.lblApplicantHead);
            this.pnlApplicant.Controls.Add(this.lblApplicantSub);
            this.pnlApplicant.Controls.Add(this.btnApplicant);

            this.pnlHR.Controls.Add(this.lblHRIcon);
            this.pnlHR.Controls.Add(this.lblHRHead);
            this.pnlHR.Controls.Add(this.lblHRSub);
            this.pnlHR.Controls.Add(this.btnHR);

            // ── Add controls to Form ──────────────────────────────
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.pnlApplicant);
            this.Controls.Add(this.pnlHR);
            this.Controls.Add(this.lblFooter);

            this.pnlApplicant.ResumeLayout(false);
            this.pnlHR.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Control declarations
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlApplicant;
        private System.Windows.Forms.Label lblApplicantIcon;
        private System.Windows.Forms.Label lblApplicantHead;
        private System.Windows.Forms.Label lblApplicantSub;
        private System.Windows.Forms.Button btnApplicant;
        private System.Windows.Forms.Panel pnlHR;
        private System.Windows.Forms.Label lblHRIcon;
        private System.Windows.Forms.Label lblHRHead;
        private System.Windows.Forms.Label lblHRSub;
        private System.Windows.Forms.Button btnHR;
        private System.Windows.Forms.Label lblFooter;
    }
}