using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmJobVacancy : Form
    {
        private List<JobVacancy> vacancies = new List<JobVacancy>();

        public frmJobVacancy()
        {
            InitializeComponent();
            LoadVacancies();
        }

        private void LoadVacancies()
        {
            lstVacancies.Items.Clear();
            foreach (var v in vacancies)
            {
                lstVacancies.Items.Add($"{v.Title} - Status: {v.Status}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = Prompt("Enter job title:");
            if (!string.IsNullOrEmpty(title))
            {
                vacancies.Add(new JobVacancy { Title = title, Status = "Open" });
                LoadVacancies();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedIndex >= 0)
            {
                string newTitle = Prompt("Enter new job title:");
                if (!string.IsNullOrEmpty(newTitle))
                {
                    vacancies[lstVacancies.SelectedIndex].Title = newTitle;
                    LoadVacancies();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedIndex >= 0)
            {
                vacancies[lstVacancies.SelectedIndex].Status = "Closed";
                LoadVacancies();
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedIndex >= 0)
            {
                vacancies[lstVacancies.SelectedIndex].Status = "Open";
                LoadVacancies();
            }
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedIndex >= 0)
            {
                string qualifications = Prompt("Enter qualifications:");
                vacancies[lstVacancies.SelectedIndex].Qualifications = qualifications;
                MessageBox.Show("Qualifications updated.");
            }
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            if (lstVacancies.SelectedIndex >= 0)
            {
                string documents = Prompt("Enter required documents:");
                vacancies[lstVacancies.SelectedIndex].RequiredDocuments = documents;
                MessageBox.Show("Required documents updated.");
            }
        }

        // Simple input prompt
        private string Prompt(string message)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(message, "Input", "");
        }
    }

    public class JobVacancy
    {
        public string Title { get; set; }
        public string Status { get; set; } = "Open";
        public string Qualifications { get; set; }
        public string RequiredDocuments { get; set; }
    }
}
