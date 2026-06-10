using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.Maintenance
{
    public partial class frmAssessmentTypes : Form
    {
        public frmAssessmentTypes()
        {
            InitializeComponent();
        }

        private void frmAssessmentTypes_Load(object sender, EventArgs e)
        {
            ApplyUniversalUITheme();
            LoadData();
        }

        private void ApplyUniversalUITheme()
        {
            try
            {
                this.Font = new Font("Verdana", 10);

                if (this.Controls.ContainsKey("lblTitle"))
                {
                    this.Controls["lblTitle"].Font = new Font("Verdana", 17, FontStyle.Bold);
                    this.Controls["lblTitle"].ForeColor = ColorTranslator.FromHtml("#1F3864");
                }

                if (this.Controls.ContainsKey("lblSubtitle"))
                {
                    this.Controls["lblSubtitle"].Font = new Font("Verdana", 11, FontStyle.Italic);
                    this.Controls["lblSubtitle"].ForeColor = ColorTranslator.FromHtml("#888888");
                }

                if (this.Controls.ContainsKey("txtName"))
                {
                    ((TextBox)this.Controls["txtName"]).BorderStyle = BorderStyle.FixedSingle;
                }

                if (this.Controls.ContainsKey("btnAdd"))
                {
                    this.Controls["btnAdd"].BackColor = ColorTranslator.FromHtml("#1F5C99");
                    this.Controls["btnAdd"].ForeColor = Color.White;
                    this.Controls["btnAdd"].Font = new Font("Verdana", 10, FontStyle.Bold);
                }

                if (this.Controls.ContainsKey("btnUpdate"))
                {
                    this.Controls["btnUpdate"].BackColor = ColorTranslator.FromHtml("#1F5C99");
                    this.Controls["btnUpdate"].ForeColor = Color.White;
                    this.Controls["btnUpdate"].Font = new Font("Verdana", 10, FontStyle.Bold);
                }

                if (this.Controls.ContainsKey("btnDelete"))
                {
                    this.Controls["btnDelete"].BackColor = ColorTranslator.FromHtml("#C0392B");
                    this.Controls["btnDelete"].ForeColor = Color.White;
                    this.Controls["btnDelete"].Font = new Font("Verdana", 10, FontStyle.Bold);
                }

                if (this.Controls.ContainsKey("btnClear"))
                {
                    var btn = (Button)this.Controls["btnClear"];
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.ForeColor = ColorTranslator.FromHtml("#555555");
                }
            }
            catch { }
        }

        private void LoadData()
        {
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT assessment_type_id AS ID, name AS Name FROM assessment_types";
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
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter an assessment type.");
                return;
            }
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO assessment_types (name) VALUES (@name)";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assessment type added!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.");
                return;
            }
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a new name.");
                return;
            }
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE assessment_types SET name = @name WHERE assessment_type_id = @id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row first.");
                return;
            }
            int id = Convert.ToInt32(dgvList.SelectedRows[0].Cells["ID"].Value);
            string name = dgvList.SelectedRows[0].Cells["Name"].Value.ToString();
            var confirm = MessageBox.Show(
                $"Delete '{name}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm != DialogResult.Yes) return;
            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM assessment_types WHERE assessment_type_id = @id";
                    var cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted!");
                    ClearFields();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtName.Text = dgvList.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtName.Text = "";
            dgvList.ClearSelection();
        }
    }
}