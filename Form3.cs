using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void ClearFields()
        {
            txtProductName.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            txtDescription.Clear();
            txtReorderLevel.Clear();

            cmbCategory.SelectedIndex = -1;

            txtProductName.Focus();
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection conn =
                    DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT * FROM [Products]";

                    using (OleDbDataAdapter adapter =
                        new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvProducts.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load products: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
        string.IsNullOrWhiteSpace(txtUnitPrice.Text) ||
        string.IsNullOrWhiteSpace(txtQuantity.Text) ||
        string.IsNullOrWhiteSpace(txtReorderLevel.Text) ||
        cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            if (!decimal.TryParse(txtUnitPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !int.TryParse(txtReorderLevel.Text, out int reorderLevel))
            {
                MessageBox.Show("Please enter valid price and quantity values.");
                return;
            }

            if (price < 0 || quantity < 0 || reorderLevel < 0)
            {
                MessageBox.Show("Values cannot be negative.");
                return;
            }

            try
            {
                using (OleDbConnection conn =
                    DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        @"INSERT INTO [Products] " +
                        "([ProductName], [UnitPrice], [Quantity], " +
                        "[Description], [ReorderLevel], [Category]) " +
                        "VALUES (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand cmd =
                        new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@ProductName", txtProductName.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@UnitPrice", price);

                        cmd.Parameters.AddWithValue(
                            "@Quantity", quantity);

                        cmd.Parameters.AddWithValue(
                            "@Description", txtDescription.Text.Trim());

                        cmd.Parameters.AddWithValue(
                            "@ReorderLevel", reorderLevel);

                        cmd.Parameters.AddWithValue(
                            "@Category", cmbCategory.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product successfully added!");

                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtUnitPrice.Text = row.Cells["UnitPrice"].Value?.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                txtReorderLevel.Text = row.Cells["ReorderLevel"].Value?.ToString();
                cmbCategory.Text = row.Cells["Category"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
       dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                !decimal.TryParse(txtUnitPrice.Text, out decimal price) ||
                !int.TryParse(txtQuantity.Text, out int quantity) ||
                !int.TryParse(txtReorderLevel.Text, out int reorderLevel) ||
                cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter valid product information.");
                return;
            }

            if (price < 0 || quantity < 0 || reorderLevel < 0)
            {
                MessageBox.Show("Values cannot be negative.");
                return;
            }

            int productID = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ID"].Value);

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"UPDATE [Products]
                SET [ProductName] = ?, [UnitPrice] = ?,
                [Quantity] = ?, [Description] = ?,
                [ReorderLevel] = ?, [Category] = ?
                WHERE [ProductID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                        cmd.Parameters.AddWithValue("@UnitPrice", price);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@ReorderLevel", reorderLevel);
                        cmd.Parameters.AddWithValue("@Category", cmbCategory.Text);
                        cmd.Parameters.AddWithValue("@ProductID", productID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product updated successfully!");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null ||
        dgvProducts.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int productID = Convert.ToInt32(
                dgvProducts.CurrentRow.Cells["ID"].Value);

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
                return;

            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "DELETE FROM [Products] WHERE [ProductID] = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Product deleted successfully!");
                LoadProducts();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete Error: " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT * FROM [Products] " +
                        "WHERE [ProductName] LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@ProductName", "*" + txtSearch.Text.Trim() + "*");

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvProducts.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }
    }
}
