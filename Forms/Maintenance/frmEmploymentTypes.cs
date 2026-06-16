using HRApplicantSystem.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmEmploymentTypes : Form
    {
        public frmEmploymentTypes()
        {
            InitializeComponent();
        }

        private void frmEmploymentTypes_Load(object sender, EventArgs e)
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

                    string query = "SELECT type_id AS ID, label AS Name FROM employment_types ORDER BY label";

                    var adapter = new SqlDataAdapter(query, conn);
                    var table = new DataTable();
                    adapter.Fill(table);

                    dgvList.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Enter a label.");
                return;
            }

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                    "INSERT INTO employment_types (label) VALUES (@name)", conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
            }

            txtName.Clear();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0) return;

            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);

            using (var conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                using (var cmd = new SqlCommand(
                    "UPDATE employment_types SET label=@name WHERE type_id=@id", conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }

            txtName.Clear();
            LoadData();
        }

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            dgvList.ClearSelection();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}