using MySql.Data.MySqlClient;
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
            LoadDropdowns();
            LoadData();

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("open");
            cmbStatus.Items.Add("closed");
            cmbStatus.SelectedIndex = 0;
        }

        private void LoadDropdowns()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    var adapterP = new MySqlDataAdapter("SELECT position_id, title FROM positions", conn);
                    var tableP = new DataTable();
                    adapterP.Fill(tableP);
                    cmbPosition.DataSource = tableP;
                    cmbPosition.DisplayMember = "title";
                    cmbPosition.ValueMember = "position_id";

                    var adapterD = new MySqlDataAdapter("SELECT department_id, name FROM departments", conn);
                    var tableD = new DataTable();
                    adapterD.Fill(tableD);
                    cmbDepartment.DataSource = tableD;
                    cmbDepartment.DisplayMember = "name";
                    cmbDepartment.ValueMember = "department_id";

                    var adapterE = new MySqlDataAdapter("SELECT type_id, label FROM employment_types", conn);
                    var tableE = new DataTable();
                    adapterE.Fill(tableE);
                    cmbEmploymentType.DataSource = tableE;
                    cmbEmploymentType.DisplayMember = "label";
                    cmbEmploymentType.ValueMember = "type_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dropdowns: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            v.vacancy_id        AS ID,
                            p.title             AS Position,
                            d.name              AS Department,
                            e.label             AS EmploymentType,
                            v.slots             AS Slots,
                            v.status            AS Status
                        FROM job_vacancies v
                        JOIN positions p ON v.position_id = p.position_id
                        JOIN departments d ON v.department_id = d.department_id
                        JOIN employment_types e ON v.employment_type_id = e.type_id";

                    var adapter = new MySqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    dgvList.DataSource = table;
                    dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvList.ReadOnly = true;
                    dgvList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vacancies: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPosition.SelectedValue == null || cmbDepartment.SelectedValue == null || cmbEmploymentType.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int positionId = Convert.ToInt32(cmbPosition.SelectedValue);
            int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            int employmentType = Convert.ToInt32(cmbEmploymentType.SelectedValue);
            int slots = Convert.ToInt32(nudSlots.Value);
            string status = cmbStatus.SelectedItem.ToString();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO job_vacancies (position_id, department_id, employment_type_id, slots, status)
                        VALUES (@posId, @deptId, @empTypeId, @slots, @status)";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@posId", positionId);
                    cmd.Parameters.AddWithValue("@deptId", departmentId);
                    cmd.Parameters.AddWithValue("@empTypeId", employmentType);
                    cmd.Parameters.AddWithValue("@slots", slots);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vacancy added successfully!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vacancy: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
            int positionId = Convert.ToInt32(cmbPosition.SelectedValue);
            int departmentId = Convert.ToInt32(cmbDepartment.SelectedValue);
            int employmentType = Convert.ToInt32(cmbEmploymentType.SelectedValue);
            int slots = Convert.ToInt32(nudSlots.Value);
            string status = cmbStatus.SelectedItem.ToString();

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = @"
                        UPDATE job_vacancies SET
                            position_id = @posId,
                            department_id = @deptId,
                            employment_type_id = @empTypeId,
                            slots = @slots,
                            status = @status
                        WHERE vacancy_id = @id";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@posId", positionId);
                    cmd.Parameters.AddWithValue("@deptId", departmentId);
                    cmd.Parameters.AddWithValue("@empTypeId", employmentType);
                    cmd.Parameters.AddWithValue("@slots", slots);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vacancy updated successfully!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }

        private void btnCloseVacancy_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a vacancy to close.");
                return;
            }

            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);

            var confirm = MessageBox.Show(
                "Close this vacancy? Applicants won't see it anymore.",
                "Confirm Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();

                    string query = "UPDATE job_vacancies SET status = 'closed' WHERE vacancy_id = @id";

                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Vacancy closed.");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error closing vacancy: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvList.Rows[e.RowIndex];

            cmbPosition.Text = row.Cells["Position"].Value.ToString();
            cmbDepartment.Text = row.Cells["Department"].Value.ToString();
            cmbEmploymentType.Text = row.Cells["EmploymentType"].Value.ToString();
            nudSlots.Value = Convert.ToDecimal(row.Cells["Slots"].Value);
            cmbStatus.Text = row.Cells["Status"].Value.ToString();
        }

        private void ClearFields()
        {
            if (cmbPosition.Items.Count > 0) cmbPosition.SelectedIndex = 0;
            if (cmbDepartment.Items.Count > 0) cmbDepartment.SelectedIndex = 0;
            if (cmbEmploymentType.Items.Count > 0) cmbEmploymentType.SelectedIndex = 0;
            nudSlots.Value = 1;
            cmbStatus.SelectedIndex = 0;
            dgvList.ClearSelection();
        }
    }
}
