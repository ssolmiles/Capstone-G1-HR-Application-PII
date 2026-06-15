namespace HRApplicantSystem.Forms.HR
{
    partial class frmInterviewEvaluation
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.GroupBox groupBox1; // Applicant Details
        private System.Windows.Forms.Label lblApplicantNameCaption;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblJobAppliedCaption;
        private System.Windows.Forms.Label lblJobApplied;

        private System.Windows.Forms.GroupBox groupBox2; // Evaluation
        private System.Windows.Forms.Label label1; // Score caption
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label label2; // Remarks caption
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label label3; // Recommendation caption
        private System.Windows.Forms.TextBox txtRecommendation;

        private System.Windows.Forms.GroupBox groupBox3; // Result
        private System.Windows.Forms.Label lblResult;

        private System.Windows.Forms.Button button1; // Pass
        private System.Windows.Forms.Button button2; // Fail
        private System.Windows.Forms.Button btnBack; // Save Evaluation
        private System.Windows.Forms.Button button4; // Proceed to Hiring Decision

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblApplicantNameCaption = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblJobAppliedCaption = new System.Windows.Forms.Label();
            this.lblJobApplied = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecommendation = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvInterviewed = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(40, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Interview Evaluation";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblSubtitle.Location = new System.Drawing.Point(42, 54);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(346, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Score the interview and record your recommendation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblApplicantNameCaption);
            this.groupBox1.Controls.Add(this.lblApplicantName);
            this.groupBox1.Controls.Add(this.lblJobAppliedCaption);
            this.groupBox1.Controls.Add(this.lblJobApplied);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(40, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applicant Details";
            // 
            // lblApplicantNameCaption
            // 
            this.lblApplicantNameCaption.AutoSize = true;
            this.lblApplicantNameCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblApplicantNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblApplicantNameCaption.Location = new System.Drawing.Point(15, 30);
            this.lblApplicantNameCaption.Name = "lblApplicantNameCaption";
            this.lblApplicantNameCaption.Size = new System.Drawing.Size(60, 23);
            this.lblApplicantNameCaption.TabIndex = 0;
            this.lblApplicantNameCaption.Text = "Name:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblApplicantName.Location = new System.Drawing.Point(95, 30);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(102, 23);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "(Loading...)";
            // 
            // lblJobAppliedCaption
            // 
            this.lblJobAppliedCaption.AutoSize = true;
            this.lblJobAppliedCaption.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJobAppliedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.lblJobAppliedCaption.Location = new System.Drawing.Point(15, 65);
            this.lblJobAppliedCaption.Name = "lblJobAppliedCaption";
            this.lblJobAppliedCaption.Size = new System.Drawing.Size(129, 23);
            this.lblJobAppliedCaption.TabIndex = 2;
            this.lblJobAppliedCaption.Text = "Job Applied for:";
            // 
            // lblJobApplied
            // 
            this.lblJobApplied.AutoSize = true;
            this.lblJobApplied.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblJobApplied.Location = new System.Drawing.Point(15, 88);
            this.lblJobApplied.Name = "lblJobApplied";
            this.lblJobApplied.Size = new System.Drawing.Size(102, 23);
            this.lblJobApplied.TabIndex = 3;
            this.lblJobApplied.Text = "(Loading...)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtScore);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRemarks);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtRecommendation);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox2.Location = new System.Drawing.Point(322, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 320);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score (0 - 100):";
            // 
            // txtScore
            // 
            this.txtScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtScore.Location = new System.Drawing.Point(150, 32);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 30);
            this.txtScore.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remarks:";
            // 
            // txtRemarks
            // 
            this.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRemarks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRemarks.Location = new System.Drawing.Point(20, 105);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(380, 75);
            this.txtRemarks.TabIndex = 3;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label3.Location = new System.Drawing.Point(20, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Recommendation:";
            // 
            // txtRecommendation
            // 
            this.txtRecommendation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecommendation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRecommendation.Location = new System.Drawing.Point(20, 220);
            this.txtRecommendation.Multiline = true;
            this.txtRecommendation.Name = "txtRecommendation";
            this.txtRecommendation.Size = new System.Drawing.Size(380, 75);
            this.txtRecommendation.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblResult);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.groupBox3.Location = new System.Drawing.Point(40, 220);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(122)))), ((int)(((byte)(0)))));
            this.lblResult.Location = new System.Drawing.Point(20, 40);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(150, 25);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result: Pending";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(122)))), ((int)(((byte)(60)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pass";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnPass_Click);

            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(175, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 40);
            this.button2.TabIndex = 6;
            this.button2.Click += new System.EventHandler(this.btnFail_Click);

            this.button2.Text = "Fail";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(40, 395);
            this.btnBack.Name = "btnBack";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            this.btnBack.Size = new System.Drawing.Size(260, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back [or Save?]";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(92)))), ((int)(((byte)(153)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Click += new System.EventHandler(this.btnNext_Click);

            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(386, 416);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(250, 40);
            this.button4.TabIndex = 8;
            this.button4.Text = "Proceed to Hiring Decision";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dgvInterviewed
            // 
            this.dgvInterviewed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterviewed.Location = new System.Drawing.Point(760, 65);
            this.dgvInterviewed.Name = "dgvInterviewed";
            this.dgvInterviewed.RowHeadersWidth = 51;
            this.dgvInterviewed.RowTemplate.Height = 24;
            this.dgvInterviewed.Size = new System.Drawing.Size(1010, 358);
            this.dgvInterviewed.TabIndex = 9;
            // 
            // frmInterviewEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.dgvInterviewed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button4);
            this.Name = "frmInterviewEvaluation";
            this.Text = "Interview Evaluation";
            this.Load += new System.EventHandler(this.frmInterviewEvaluation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvInterviewed;
    }
}