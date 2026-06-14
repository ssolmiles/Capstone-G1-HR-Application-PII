using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmJobVacancyManagement : Form
    {
        public frmJobVacancyManagement()
        {
            InitializeComponent();
        }

        private void frmJobVacancyManagement_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadPositions();
            LoadEmploymentTypes();
            LoadVacancies();
        }

        private void LoadDepartments()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT department_id, name FROM departments", conn);
                    var reader = cmd.ExecuteReader();
                    cboDepartment.Items.Clear();
                    cboDepartment.Items.Add(new { Text = "-- Select Department --", Value = 0 });
                    while (reader.Read())
                        cboDepartment.Items.Add(new { Text = reader["name"].ToString(), Value = (int)reader["department_id"] });
                    cboDepartment.DisplayMember = "Text";
                    cboDepartment.ValueMember = "Value";
                    cboDepartment.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading departments: " + ex.Message); }
        }

        private void LoadPositions()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT position_id, title FROM positions", conn);
                    var reader = cmd.ExecuteReader();
                    cboPosition.Items.Clear();
                    cboPosition.Items.Add(new { Text = "-- Select Position --", Value = 0 });
                    while (reader.Read())
                        cboPosition.Items.Add(new { Text = reader["title"].ToString(), Value = (int)reader["position_id"] });
                    cboPosition.DisplayMember = "Text";
                    cboPosition.ValueMember = "Value";
                    cboPosition.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading positions: " + ex.Message); }
        }

        private void LoadEmploymentTypes()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT type_id, label FROM employment_types", conn);
                    var reader = cmd.ExecuteReader();
                    cboEmploymentType.Items.Clear();
                    cboEmploymentType.Items.Add(new { Text = "-- Select Type --", Value = 0 });
                    while (reader.Read())
                        cboEmploymentType.Items.Add(new { Text = reader["label"].ToString(), Value = (int)reader["type_id"] });
                    cboEmploymentType.DisplayMember = "Text";
                    cboEmploymentType.ValueMember = "Value";
                    cboEmploymentType.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading types: " + ex.Message); }
        }

        private void LoadVacancies(string filter = "")
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = @"SELECT v.vacancy_id, p.title AS position,
                        d.name AS department, et.label AS type,
                        v.slots, v.status
                        FROM job_vacancies v
                        INNER JOIN positions p ON v.position_id = p.position_id
                        INNER JOIN departments d ON v.department_id = d.department_id
                        INNER JOIN employment_types et ON v.employment_type_id = et.type_id";
                    if (!string.IsNullOrEmpty(filter))
                        sql += " WHERE p.title LIKE @f OR d.name LIKE @f";
                    var adapter = new SqlDataAdapter(sql, conn);
                    if (!string.IsNullOrEmpty(filter))
                        adapter.SelectCommand.Parameters.AddWithValue("@f", "%" + filter + "%");
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvVacancies.DataSource = table;
                    dgvVacancies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvVacancies.ReadOnly = true;
                    dgvVacancies.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error loading vacancies: " + ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboDepartment.SelectedIndex <= 0 || cboPosition.SelectedIndex <= 0 || cboEmploymentType.SelectedIndex <= 0)
            { MessageBox.Show("Please select Department, Position, and Employment Type."); return; }
            if (string.IsNullOrWhiteSpace(txtDescription.Text) || string.IsNullOrWhiteSpace(txtQualifications.Text))
            { MessageBox.Show("Please fill in Description and Qualifications."); return; }
            try
            {
                dynamic dept = cboDepartment.SelectedItem;
                dynamic pos = cboPosition.SelectedItem;
                dynamic emp = cboEmploymentType.SelectedItem;
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO job_vacancies
                        (position_id, department_id, employment_type_id,
                         description, qualifications, slots, status, posted_by, posted_at)
                        VALUES (@pos, @dept, @emp, @desc, @qual, @slots, 'open', @postedBy, GETDATE())", conn);
                    cmd.Parameters.AddWithValue("@pos", pos.Value);
                    cmd.Parameters.AddWithValue("@dept", dept.Value);
                    cmd.Parameters.AddWithValue("@emp", emp.Value);
                    cmd.Parameters.AddWithValue("@desc", txtDescription.Text.Trim());
                    cmd.Parameters.AddWithValue("@qual", txtQualifications.Text.Trim());
                    cmd.Parameters.AddWithValue("@slots", string.IsNullOrEmpty(txtSlots.Text) ? 1 : int.Parse(txtSlots.Text));
                    cmd.Parameters.AddWithValue("@postedBy", SessionManager.CurrentUser?.UserID ?? 1);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Vacancy added!"); ClearFields(); LoadVacancies();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) { MessageBox.Show("Select a vacancy first."); return; }
            int id = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);
            if (MessageBox.Show("Close this vacancy? Applicants will no longer see it.", "Confirm", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("UPDATE job_vacancies SET status='closed' WHERE vacancy_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vacancy closed."); LoadVacancies();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            if (dgvVacancies.SelectedRows.Count == 0) { MessageBox.Show("Select a vacancy first."); return; }
            int id = Convert.ToInt32(dgvVacancies.SelectedRows[0].Cells["vacancy_id"].Value);
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("UPDATE job_vacancies SET status='open' WHERE vacancy_id=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Vacancy reopened!"); LoadVacancies();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadVacancies(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void ClearFields()
        {
            cboDepartment.SelectedIndex = 0;
            cboPosition.SelectedIndex = 0;
            cboEmploymentType.SelectedIndex = 0;
            txtDescription.Clear();
            txtQualifications.Clear();
            txtSlots.Clear();
            txtSearch.Clear();
            dgvVacancies.ClearSelection();
        }

        private void cboDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // "-- Select Department --" chosen (or nothing selected yet): show all positions.
            if (cboDepartment.SelectedIndex <= 0)
            {
                LoadPositions();
                return;
            }

            dynamic dept = cboDepartment.SelectedItem;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT position_id, title FROM positions WHERE department_id = @d", conn);
                    cmd.Parameters.AddWithValue("@d", dept.Value);
                    var reader = cmd.ExecuteReader();
                    cboPosition.Items.Clear();
                    cboPosition.Items.Add(new { Text = "-- Select Position --", Value = 0 });
                    while (reader.Read())
                        cboPosition.Items.Add(new { Text = reader["title"].ToString(), Value = (int)reader["position_id"] });
                    cboPosition.DisplayMember = "Text";
                    cboPosition.ValueMember = "Value";
                    cboPosition.SelectedIndex = 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new HRApplicantSystem.Forms.HR.frmHRDashboard().Show();
            this.Close();
        }
    }
}