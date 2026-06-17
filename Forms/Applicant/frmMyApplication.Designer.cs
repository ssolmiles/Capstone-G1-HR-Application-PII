// =============================================================
//  frmMyApplication.Designer.cs
//
//  CHANGES FROM ORIGINAL
//  ─────────────────────
//  1. btnDelete.Click wired to btnDelete_Click (was missing).
//  2. btnEdit   text changed to "Edit Position".
//  3. Added btnWithdraw (new button, replaces "Edit/Withdraw"
//     dual purpose — each action now has its own button).
//  4. Added cboVacancy (ComboBox) and lblPickJob (Label) for
//     the Edit-position feature; hidden by default.
// =============================================================

namespace HRApplicantSystem.Forms.Applicant
{
    partial class frmMyApplication
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
            this.listViewApps = new System.Windows.Forms.ListView();
            this.btnSaveDraft = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUploadDocs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPickJob = new System.Windows.Forms.Label();
            this.cboVacancy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();

            // ── listViewApps ──────────────────────────────────
            this.listViewApps.HideSelection = false;
            this.listViewApps.Location = new System.Drawing.Point(20, 100);
            this.listViewApps.Margin = new System.Windows.Forms.Padding(4);
            this.listViewApps.Name = "listViewApps";
            this.listViewApps.Size = new System.Drawing.Size(860, 380);
            this.listViewApps.TabIndex = 0;
            this.listViewApps.UseCompatibleStateImageBehavior = false;
            this.listViewApps.SelectedIndexChanged +=
                new System.EventHandler(this.listViewApps_SelectedIndexChanged);

            // ── lblPickJob ────────────────────────────────────
            // Shown only when the applicant clicks Edit Position.
            this.lblPickJob.AutoSize = true;
            this.lblPickJob.Font = new System.Drawing.Font("Verdana", 9F,
                                          System.Drawing.FontStyle.Italic);
            this.lblPickJob.ForeColor = System.Drawing.Color.FromArgb(31, 92, 153);
            this.lblPickJob.Location = new System.Drawing.Point(20, 492);
            this.lblPickJob.Name = "lblPickJob";
            this.lblPickJob.TabIndex = 20;
            this.lblPickJob.Text = "Choose a new position, then click Save Draft:";
            this.lblPickJob.Visible = false;

            // ── cboVacancy ────────────────────────────────────
            // Shown only when the applicant clicks Edit Position.
            this.cboVacancy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVacancy.Font = new System.Drawing.Font("Verdana", 10F);
            this.cboVacancy.Location = new System.Drawing.Point(20, 518);
            this.cboVacancy.Name = "cboVacancy";
            this.cboVacancy.Size = new System.Drawing.Size(860, 28);
            this.cboVacancy.TabIndex = 21;
            this.cboVacancy.Visible = false;
            this.cboVacancy.SelectedIndexChanged +=
                new System.EventHandler(this.cboVacancy_SelectedIndexChanged);

            // ── btnSaveDraft ──────────────────────────────────
            // Persists the vacancy chosen in cboVacancy without submitting.
            this.btnSaveDraft.BackColor = System.Drawing.Color.FromArgb(31, 92, 153);
            this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDraft.Font = new System.Drawing.Font("Verdana", 10F,
                                            System.Drawing.FontStyle.Bold);
            this.btnSaveDraft.ForeColor = System.Drawing.Color.White;
            this.btnSaveDraft.Location = new System.Drawing.Point(900, 100);
            this.btnSaveDraft.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveDraft.Name = "btnSaveDraft";
            this.btnSaveDraft.Size = new System.Drawing.Size(190, 44);
            this.btnSaveDraft.TabIndex = 1;
            this.btnSaveDraft.Text = "Save Draft";
            this.btnSaveDraft.UseVisualStyleBackColor = false;
            this.btnSaveDraft.Click +=
                new System.EventHandler(this.btnSaveDraft_Click);

            // ── btnSubmit ─────────────────────────────────────
            // Promotes 'draft' → 'submitted'.
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 10F,
                                         System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(900, 156);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(190, 44);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click +=
                new System.EventHandler(this.btnSubmit_Click);

            // ── btnEdit ───────────────────────────────────────
            // DRAFT only: reveals cboVacancy to change the position.
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10F,
                                       System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(900, 212);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 44);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Position";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click +=
                new System.EventHandler(this.btnEdit_Click);


            // ── btnUploadDocs ─────────────────────────────────
            this.btnUploadDocs.BackColor = System.Drawing.Color.FromArgb(22, 160, 133);
            this.btnUploadDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadDocs.Font = new System.Drawing.Font("Verdana", 10F,
                                           System.Drawing.FontStyle.Bold);
            this.btnUploadDocs.ForeColor = System.Drawing.Color.White;
            this.btnUploadDocs.Location = new System.Drawing.Point(900, 380);
            this.btnUploadDocs.Name = "btnUploadDocs";
            this.btnUploadDocs.Size = new System.Drawing.Size(190, 44);
            this.btnUploadDocs.TabIndex = 7;
            this.btnUploadDocs.Text = "Upload Documents";
            this.btnUploadDocs.UseVisualStyleBackColor = false;
            this.btnUploadDocs.Click += new System.EventHandler(this.btnUploadDocs_Click);

            // ── btnWithdraw ───────────────────────────────────
            // SUBMITTED only: removes the application before HR reviews it.
            this.btnWithdraw.BackColor = System.Drawing.Color.FromArgb(142, 68, 173);
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Font = new System.Drawing.Font("Verdana", 10F,
                                           System.Drawing.FontStyle.Bold);
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(900, 268);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(190, 44);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click +=
                new System.EventHandler(this.btnWithdraw_Click);

            // ── btnDelete ─────────────────────────────────────
            // DRAFT only: permanently removes a draft application.
            // FIX: Click event was missing in the original file.
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10F,
                                         System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(900, 324);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(190, 44);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            // ── btnBack ───────────────────────────────────────
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F,
                                       System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(85, 85, 85);
            this.btnBack.Location = new System.Drawing.Point(900, 500);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(190, 44);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click +=
                new System.EventHandler(this.btnBack_Click);

            // ── label2 ────────────────────────────────────────
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.TabIndex = 12;
            this.label2.Text =
                "Select an application to manage it. " +
                "Drafts are created when you apply on the Job Vacancies page.";

            // ── lblTitle ──────────────────────────────────────
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F,
                                        System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 56, 100);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "My Application";

            // ── frmMyApplication ──────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 620);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewApps);
            this.Controls.Add(this.lblPickJob);
            this.Controls.Add(this.cboVacancy);
            this.Controls.Add(this.btnSaveDraft);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUploadDocs);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1140, 620);
            this.Name = "frmMyApplication";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "My Application";
            this.Load += new System.EventHandler(this.frmMyApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listViewApps;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPickJob;
        private System.Windows.Forms.ComboBox cboVacancy;
        private System.Windows.Forms.Button btnUploadDocs;
    }
}