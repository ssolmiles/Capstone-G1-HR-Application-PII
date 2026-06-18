namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmApplicantRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.chkAgree = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPasswordHint = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFN
            // 
            this.txtFN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFN.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFN.Location = new System.Drawing.Point(158, 43);
            this.txtFN.Margin = new System.Windows.Forms.Padding(2);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(234, 27);
            this.txtFN.TabIndex = 1;
            // 
            // txtMI
            // 
            this.txtMI.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMI.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.ForeColor = System.Drawing.SystemColors.Window;
            this.txtMI.Location = new System.Drawing.Point(158, 78);
            this.txtMI.Margin = new System.Windows.Forms.Padding(2);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(234, 27);
            this.txtMI.TabIndex = 2;
            // 
            // txtLN
            // 
            this.txtLN.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtLN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLN.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLN.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLN.Location = new System.Drawing.Point(158, 116);
            this.txtLN.Margin = new System.Windows.Forms.Padding(2);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(234, 27);
            this.txtLN.TabIndex = 3;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "MMMM dd, yyyy";
            this.dtpBirthday.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(158, 203);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 27);
            this.dtpBirthday.TabIndex = 4;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(132, 35);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(247, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(132, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(247, 27);
            this.txtPassword.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(226, 317);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(166, 27);
            this.txtPhone.TabIndex = 6;
            // 
            // cboCountry
            // 
            this.cboCountry.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCountry.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCountry.Location = new System.Drawing.Point(158, 317);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(2);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(64, 29);
            this.cboCountry.TabIndex = 7;
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAgree.ForeColor = System.Drawing.SystemColors.WindowText;
            this.chkAgree.Location = new System.Drawing.Point(20, 450);
            this.chkAgree.Margin = new System.Windows.Forms.Padding(2);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(481, 25);
            this.chkAgree.TabIndex = 8;
            this.chkAgree.Text = "I understand that my information will be used for hiring purposes.";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Chelsea Market", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(1016, 261);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(190, 37);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFN.Location = new System.Drawing.Point(31, 43);
            this.lblFN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(89, 21);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "First Name:";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMI.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMI.Location = new System.Drawing.Point(16, 84);
            this.lblMI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(104, 21);
            this.lblMI.TabIndex = 2;
            this.lblMI.Text = "Middle Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLN.Location = new System.Drawing.Point(35, 122);
            this.lblLN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(85, 21);
            this.lblLN.TabIndex = 3;
            this.lblLN.Text = "Last Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDOB.Location = new System.Drawing.Point(20, 209);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(100, 21);
            this.lblDOB.TabIndex = 4;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblEmail.Location = new System.Drawing.Point(16, 37);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 21);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // lblPasswordHint
            // 
            this.lblPasswordHint.AutoSize = true;
            this.lblPasswordHint.Font = new System.Drawing.Font("Playfair Display", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordHint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPasswordHint.Location = new System.Drawing.Point(142, 100);
            this.lblPasswordHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordHint.Name = "lblPasswordHint";
            this.lblPasswordHint.Size = new System.Drawing.Size(237, 17);
            this.lblPasswordHint.TabIndex = 11;
            this.lblPasswordHint.Text = "*Use a strong password (min. 8 characters)";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassword.Location = new System.Drawing.Point(16, 73);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(80, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPhone.Location = new System.Drawing.Point(36, 320);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(84, 21);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone No.:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCountry.Location = new System.Drawing.Point(71, 350);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(49, 21);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Code:";
            this.lblCountry.Click += new System.EventHandler(this.lblCountry_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSubtitle.Location = new System.Drawing.Point(28, 52);
            this.lblSubtitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(323, 23);
            this.lblSubtitle.TabIndex = 60;
            this.lblSubtitle.Text = "Fill in your basic information to get started";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGender.Location = new System.Drawing.Point(54, 250);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 21);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender:";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGender.Font = new System.Drawing.Font("Playfair Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.Location = new System.Drawing.Point(158, 247);
            this.cboGender.Margin = new System.Windows.Forms.Padding(2);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(200, 29);
            this.cboGender.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.lblFN);
            this.groupBox1.Controls.Add(this.txtFN);
            this.groupBox1.Controls.Add(this.lblMI);
            this.groupBox1.Controls.Add(this.txtMI);
            this.groupBox1.Controls.Add(this.lblLN);
            this.groupBox1.Controls.Add(this.txtLN);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.lblDOB);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.cboCountry);
            this.groupBox1.Controls.Add(this.chkAgree);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(11, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(520, 498);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.lblPassword);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.lblPasswordHint);
            this.groupBox2.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox2.Location = new System.Drawing.Point(848, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(509, 150);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Details";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Chelsea Market", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTitle.Location = new System.Drawing.Point(11, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(296, 34);
            this.lblTitle.TabIndex = 59;
            this.lblTitle.Text = "Create an Account";
            // 
            // frmApplicantRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImage = global::HRApplicantSystem.Properties.Resources.key;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1368, 741);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.MinimizeBox = false;
            this.Name = "frmApplicantRegister";
            this.Text = "Applicant Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.CheckBox chkAgree;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPasswordHint;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}