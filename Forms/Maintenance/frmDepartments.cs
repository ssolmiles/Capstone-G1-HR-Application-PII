using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmDepartments : Form
    {
        public frmDepartments()
        {
            InitializeComponent();
        }

        private void frmDepartments_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT department_id AS ID, name AS Name FROM departments";
                    var adapter = new SqlDataAdapter(query, conn);
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
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Please enter a department name."); return; }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("INSERT INTO departments (name) VALUES (@name)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Department added!");
                    ClearFields(); LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error adding: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0) { MessageBox.Show("Select a row first."); return; }
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("Please enter a new name."); return; }
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("UPDATE departments SET name = @name WHERE department_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Updated!"); ClearFields(); LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error updating: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0) { MessageBox.Show("Select a row first."); return; }
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
            string name = dgvList.SelectedRows[0].Cells["Name"].Value.ToString();
            if (MessageBox.Show($"Delete '{name}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("DELETE FROM departments WHERE department_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Deleted!"); ClearFields(); LoadData();
                }
            }
            catch (Exception ex) { MessageBox.Show("Error deleting: " + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                txtName.Text = dgvList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
        }

        private void ClearFields() { txtName.Text = ""; dgvList.ClearSelection(); }
    }
}