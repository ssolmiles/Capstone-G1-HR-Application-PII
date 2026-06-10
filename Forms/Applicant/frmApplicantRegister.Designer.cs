namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicantRegister
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
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFN
            // 
            this.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFN.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtFN.Location = new System.Drawing.Point(206, 42);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(265, 30);
            this.txtFN.TabIndex = 37;
            // 
            // txtMI
            // 
            this.txtMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMI.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtMI.Location = new System.Drawing.Point(206, 96);
            this.txtMI.Margin = new System.Windows.Forms.Padding(4);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(265, 30);
            this.txtMI.TabIndex = 38;
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtLN.Location = new System.Drawing.Point(206, 134);
            this.txtLN.Margin = new System.Windows.Forms.Padding(4);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(265, 30);
            this.txtLN.TabIndex = 39;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Font = new System.Drawing.Font("Verdana", 11F);
            this.dtpBirthday.Location = new System.Drawing.Point(206, 179);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(265, 30);
            this.dtpBirthday.TabIndex = 40;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtEmail.Location = new System.Drawing.Point(176, 46);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 30);
            this.txtEmail.TabIndex = 41;
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Verdana", 11F);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(176, 156);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(57, 30);
            this.cboCountry.TabIndex = 42;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtPhone.Location = new System.Drawing.Point(264, 151);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 36);
            this.txtPhone.TabIndex = 43;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Verdana", 11F);
            this.chkAgree.Location = new System.Drawing.Point(680, 338);
            this.chkAgree.Margin = new System.Windows.Forms.Padding(4);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(225, 27);
            this.chkAgree.TabIndex = 44;
            this.chkAgree.Text = "Do you understand?";
            this.chkAgree.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 11F);
            this.btnRegister.Location = new System.Drawing.Point(709, 398);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(153, 45);
            this.btnRegister.TabIndex = 45;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblFN.Location = new System.Drawing.Point(36, 42);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(122, 23);
            this.lblFN.TabIndex = 46;
            this.lblFN.Text = "First Name:";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblMI.Location = new System.Drawing.Point(21, 96);
            this.lblMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(143, 23);
            this.lblMI.TabIndex = 47;
            this.lblMI.Text = "Middle Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblLN.Location = new System.Drawing.Point(45, 133);
            this.lblLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(119, 23);
            this.lblLN.TabIndex = 48;
            this.lblLN.Text = "Last Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblDOB.Location = new System.Drawing.Point(23, 179);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(142, 23);
            this.lblDOB.TabIndex = 49;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblEmail.Location = new System.Drawing.Point(86, 53);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 23);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11F);
            this.label2.Location = new System.Drawing.Point(-9, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contact Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 11F);
            this.lblPassword.Location = new System.Drawing.Point(49, 101);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 23);
            this.lblPassword.TabIndex = 52;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 11F);
            this.txtPassword.Location = new System.Drawing.Point(176, 99);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 30);
            this.txtPassword.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 55;
            this.label1.Text = "Get Started!";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 18F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 44);
            this.textBox1.TabIndex = 54;
            this.textBox1.Text = "Create an Account";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLN);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.txtMI);
            this.groupBox1.Controls.Add(this.lblFN);
            this.groupBox1.Controls.Add(this.lblMI);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(39, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 247);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.cboCountry);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(39, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 225);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Details ";
            // 
            // frmApplicantRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 802);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkAgree);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApplicantRegister";
            this.Text = "frmApplicantRegister";
            this.Load += new System.EventHandler(this.frmApplicantRegister_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}