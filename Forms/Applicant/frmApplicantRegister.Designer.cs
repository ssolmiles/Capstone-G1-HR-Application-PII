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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonalInformation = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Get Started";
            // 
            // lblPersonalInformation
            // 
            this.lblPersonalInformation.AutoSize = true;
            this.lblPersonalInformation.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblPersonalInformation.Location = new System.Drawing.Point(14, 79);
            this.lblPersonalInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonalInformation.Name = "lblPersonalInformation";
            this.lblPersonalInformation.Size = new System.Drawing.Size(261, 29);
            this.lblPersonalInformation.TabIndex = 36;
            this.lblPersonalInformation.Text = "Personal Information";
            // 
            // txtFN
            // 
            this.txtFN.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtFN.Location = new System.Drawing.Point(198, 133);
            this.txtFN.Margin = new System.Windows.Forms.Padding(4);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(265, 36);
            this.txtFN.TabIndex = 37;
            // 
            // txtMI
            // 
            this.txtMI.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtMI.Location = new System.Drawing.Point(198, 187);
            this.txtMI.Margin = new System.Windows.Forms.Padding(4);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(265, 36);
            this.txtMI.TabIndex = 38;
            // 
            // txtLN
            // 
            this.txtLN.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtLN.Location = new System.Drawing.Point(750, 158);
            this.txtLN.Margin = new System.Windows.Forms.Padding(4);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(265, 36);
            this.txtLN.TabIndex = 39;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CalendarFont = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Font = new System.Drawing.Font("Verdana", 14F);
            this.dtpBirthday.Location = new System.Drawing.Point(198, 266);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(305, 36);
            this.dtpBirthday.TabIndex = 40;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtEmail.Location = new System.Drawing.Point(198, 414);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 36);
            this.txtEmail.TabIndex = 41;
            // 
            // cboCountry
            // 
            this.cboCountry.Font = new System.Drawing.Font("Verdana", 14F);
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(803, 263);
            this.cboCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(57, 36);
            this.cboCountry.TabIndex = 42;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtPhone.Location = new System.Drawing.Point(882, 263);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 36);
            this.txtPhone.TabIndex = 43;
            // 
            // chkAgree
            // 
            this.chkAgree.AutoSize = true;
            this.chkAgree.Font = new System.Drawing.Font("Verdana", 14F);
            this.chkAgree.Location = new System.Drawing.Point(581, 414);
            this.chkAgree.Margin = new System.Windows.Forms.Padding(4);
            this.chkAgree.Name = "chkAgree";
            this.chkAgree.Size = new System.Drawing.Size(277, 33);
            this.chkAgree.TabIndex = 44;
            this.chkAgree.Text = "Do you understand?";
            this.chkAgree.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Verdana", 14F);
            this.btnRegister.Location = new System.Drawing.Point(642, 486);
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
            this.lblFN.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblFN.Location = new System.Drawing.Point(15, 133);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(153, 29);
            this.lblFN.TabIndex = 46;
            this.lblFN.Text = "First Name:";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblMI.Location = new System.Drawing.Point(13, 187);
            this.lblMI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(177, 29);
            this.lblMI.TabIndex = 47;
            this.lblMI.Text = "Middle Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblLN.Location = new System.Drawing.Point(576, 161);
            this.lblLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(150, 29);
            this.lblLN.TabIndex = 48;
            this.lblLN.Text = "Last Name:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblDOB.Location = new System.Drawing.Point(15, 270);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(175, 29);
            this.lblDOB.TabIndex = 49;
            this.lblDOB.Text = "Date of Birth:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblEmail.Location = new System.Drawing.Point(102, 421);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(88, 29);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F);
            this.label2.Location = new System.Drawing.Point(576, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 51;
            this.label2.Text = "Contact Number:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Verdana", 14F);
            this.lblPassword.Location = new System.Drawing.Point(53, 474);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(137, 29);
            this.lblPassword.TabIndex = 52;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 14F);
            this.txtPassword.Location = new System.Drawing.Point(198, 467);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 36);
            this.txtPassword.TabIndex = 53;
            // 
            // frmApplicantRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 601);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chkAgree);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblPersonalInformation);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmApplicantRegister";
            this.Text = "frmApplicantRegister";
            this.Load += new System.EventHandler(this.frmApplicantRegister_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonalInformation;
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
    }
}