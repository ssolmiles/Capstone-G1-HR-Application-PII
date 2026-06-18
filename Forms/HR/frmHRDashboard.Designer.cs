using HRApplicantSystem.Helpers;

namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

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
            this.button7 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(489, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(458, 58);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Verdana", 14F);
            this.monthCalendar1.Location = new System.Drawing.Point(1197, 35);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 

            // button7
            this.button7.Font = new System.Drawing.Font("Verdana", 14F);
            this.button7.Location = new System.Drawing.Point(917, 450);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(203, 41);
            this.button7.TabIndex = 13;
            this.button7.Text = "Screening";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnScreening_Click);
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14F);
            this.groupBox1.Location = new System.Drawing.Point(496, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 434);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(22, 334);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(280, 30);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Rejected";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(22, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(280, 30);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Accepted";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 30);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Interview Schedule";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 30);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Total Applicants:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 14F);
            this.button1.Location = new System.Drawing.Point(917, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Applicants";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 14F);
            this.button2.Location = new System.Drawing.Point(917, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Review";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInterviews_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 14F);
            this.button3.Location = new System.Drawing.Point(917, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 41);
            this.button3.TabIndex = 9;
            this.button3.Text = "Interview";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVacancyManagement_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 14F);
            this.button4.Location = new System.Drawing.Point(1258, 760);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 38);
            this.button4.TabIndex = 10;
            this.button4.Text = "Log Out";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 14F);
            this.button5.Location = new System.Drawing.Point(917, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(203, 41);
            this.button5.TabIndex = 11;
            this.button5.Text = "Reports";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 14F);
            this.button6.Location = new System.Drawing.Point(917, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(203, 41);
            this.button6.TabIndex = 12;
            this.button6.Text = "Maintenance";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // frmHRDashboard
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblTitle);
            this.MinimizeBox = false;
            this.Name = "frmHRDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HR Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHRDashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}