namespace HRApplicantSystem.Forms.HR
{
    partial class frmInterviewEvaluation
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.TextBox txtRecommendation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnPass = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(20, 20);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 22);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "score";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(20, 60);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(300, 80);
            this.txtRemarks.TabIndex = 1;
            this.txtRemarks.Text = "(Interviewer remarks and notes about the candidate\'s performance during the inter" +
    "view)";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(20, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(125, 16);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result: Not decided";
            // 
            // btnPass
            // 
            this.btnPass.Location = new System.Drawing.Point(20, 180);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(75, 23);
            this.btnPass.TabIndex = 3;
            this.btnPass.Text = "Pass";
            // 
            // btnFail
            // 
            this.btnFail.Location = new System.Drawing.Point(120, 180);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(75, 23);
            this.btnFail.TabIndex = 4;
            this.btnFail.Text = "Fail";
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.Location = new System.Drawing.Point(20, 220);
            this.txtRecommendation.Multiline = true;
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.Size = new System.Drawing.Size(300, 80);
            this.txtRecommendation.TabIndex = 5;
            this.txtRecommendation.Text = "Recommendation for next steps (e.g. second interview, reference check, etc.)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(120, 320);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next → Final Decision";
            // 
            // frmInterviewEvaluation
            // 
            this.ClientSize = new System.Drawing.Size(1332, 653);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPass);
            this.Controls.Add(this.btnFail);
            this.Controls.Add(this.txtRecommendation);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNext);
            this.Name = "frmInterviewEvaluation";
            this.Text = "Interview Evaluation";
            this.Load += new System.EventHandler(this.frmInterviewEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
