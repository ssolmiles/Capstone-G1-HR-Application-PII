using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmPositions : Form
    {

        private bool HasReference(SqlConnection conn, string query, int id)
        {
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
        public frmPositions() { InitializeComponent(); }

        private void frmPositions_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadData();
        }

        private void LoadDepartments()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(
                        "SELECT department_id, name FROM departments ORDER BY name",
                        conn);
                    var dr = cmd.ExecuteReader();
                    cboDepartment.Items.Clear();
                    cboDepartment.Items.Add(
                        new { Text = "-- Select Department --", Value = 0 });
                    while (dr.Read())
                        cboDepartment.Items.Add(new
                        {
                            Text = dr["name"].ToString(),
                            Value = (int)dr["department_id"]
                        });
                    cboDepartment.DisplayMember = "Text";
                    cboDepartment.ValueMember = "Value";
                    cboDepartment.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error loading departments: " + ex.Message); }
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT p.position_id AS ID,
                        p.title AS Name,
                        ISNULL(d.name, 'No Department') AS Department
                        FROM positions p
                        LEFT JOIN departments d
                            ON p.department_id = d.department_id
                        ORDER BY p.title";
                    var adapter = new SqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvList.DataSource = table;
                    dgvList.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    dgvList.ReadOnly = true;
                    dgvList.SelectionMode =
                        DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error loading data: " + ex.Message); }
        }

        private int GetSelectedDeptId()
        {
            if (cboDepartment.SelectedIndex <= 0) return 0;
            dynamic item = cboDepartment.SelectedItem;
            return item.Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            { MessageBox.Show("Please enter a position title."); return; }
            int deptId = GetSelectedDeptId();
            if (deptId == 0)
            { MessageBox.Show("Please select a department."); return; }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(
                        @"INSERT INTO positions (title, department_id)
                          VALUES (@name, @deptId)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@deptId", deptId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Position added!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error adding: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            { MessageBox.Show("Select a row first."); return; }
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            { MessageBox.Show("Please enter a new title."); return; }
            int id = Convert.ToInt32(
                dgvList.SelectedRows[0].Cells["ID"].Value);
            int deptId = GetSelectedDeptId();
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string sql = deptId > 0
                        ? "UPDATE positions SET title=@name, department_id=@d WHERE position_id=@id"
                        : "UPDATE positions SET title=@name WHERE position_id=@id";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        if (deptId > 0)
                            cmd.Parameters.AddWithValue("@d", deptId);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Updated!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            { MessageBox.Show("Error updating: " + ex.Message); }
        }

        

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnBack_Click(object sender, EventArgs e) => this.Close();

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                txtName.Text = dgvList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }

        private void ClearFields()
        {
            txtName.Text = "";
            cboDepartment.SelectedIndex = 0;
            dgvList.ClearSelection();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}