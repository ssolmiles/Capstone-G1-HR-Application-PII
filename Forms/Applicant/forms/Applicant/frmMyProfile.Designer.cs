namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmMyProfile
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
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtWorkExp = new System.Windows.Forms.TextBox();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEducationBg = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblWorkExperience = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(225, 53);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthday.TabIndex = 1;
            // 
            // txtWorkExp
            // 
            this.txtWorkExp.Location = new System.Drawing.Point(225, 235);
            this.txtWorkExp.Name = "txtWorkExp";
            this.txtWorkExp.Size = new System.Drawing.Size(100, 20);
            this.txtWorkExp.TabIndex = 2;
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(225, 209);
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.Size = new System.Drawing.Size(100, 20);
            this.txtSkills.TabIndex = 3;
            // 
            // txtEducation
            // 
            this.txtEducation.Location = new System.Drawing.Point(225, 183);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(100, 20);
            this.txtEducation.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(225, 157);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(225, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(225, 105);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(100, 20);
            this.txtCountry.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(225, 79);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(225, 268);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(225, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(225, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(168, 59);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 13);
            this.lblBirthday.TabIndex = 13;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(149, 82);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(67, 13);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Full Address:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(170, 108);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(46, 13);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(135, 134);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(181, 160);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // lblEducationBg
            // 
            this.lblEducationBg.AutoSize = true;
            this.lblEducationBg.Location = new System.Drawing.Point(97, 186);
            this.lblEducationBg.Name = "lblEducationBg";
            this.lblEducationBg.Size = new System.Drawing.Size(119, 13);
            this.lblEducationBg.TabIndex = 18;
            this.lblEducationBg.Text = "Education Background:";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(128, 212);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(88, 13);
            this.lblSkills.TabIndex = 19;
            this.lblSkills.Text = "Skills / Expertise:";
            // 
            // lblWorkExperience
            // 
            this.lblWorkExperience.AutoSize = true;
            this.lblWorkExperience.Location = new System.Drawing.Point(124, 238);
            this.lblWorkExperience.Name = "lblWorkExperience";
            this.lblWorkExperience.Size = new System.Drawing.Size(92, 13);
            this.lblWorkExperience.TabIndex = 20;
            this.lblWorkExperience.Text = "Work Experience:";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(225, 23);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(166, 20);
            this.txtFN.TabIndex = 21;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(648, 23);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 22;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(475, 23);
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(100, 20);
            this.txtMI.TabIndex = 23;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(156, 30);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(60, 13);
            this.lblFN.TabIndex = 24;
            this.lblFN.Text = "First Name:";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(581, 30);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(61, 13);
            this.lblLN.TabIndex = 25;
            this.lblLN.Text = "Last Name:";
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = true;
            this.lblMI.Location = new System.Drawing.Point(397, 30);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(72, 13);
            this.lblMI.TabIndex = 26;
            this.lblMI.Text = "Middle Name:";
            // 
            // frmMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.txtLN);
            this.Controls.Add(this.txtFN);
            this.Controls.Add(this.lblWorkExperience);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblEducationBg);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.txtWorkExp);
            this.Controls.Add(this.dtpBirthday);
            this.Name = "frmMyProfile";
            this.Text = "frmMyProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtWorkExp;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEducationBg;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblWorkExperience;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblMI;
    }
}