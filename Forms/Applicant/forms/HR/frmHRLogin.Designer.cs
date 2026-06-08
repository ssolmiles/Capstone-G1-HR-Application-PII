namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRLogin
    {
        private System.ComponentModel.IContainer components = null;

        // Declare controls
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblEmail
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(50, 50);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(150, 50);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);

            // lblPassword
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(50, 90);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(150, 90);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(50, 140);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(150, 140);
            

            // frmHRLogin
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Text = "HR Login & Registration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
