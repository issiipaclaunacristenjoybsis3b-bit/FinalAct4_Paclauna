using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAct_Paclauna
{
    public partial class Dashboard : Form
    {
        private int selectedProductID = 0;

        public Dashboard()
        {
            InitializeComponent();

            addbtn.Click += addbtn_Click;
            updatebtn.Click += updatebtn_Click;
            deletebtn.Click += deletebtn_Click;
            clearbtn.Click += clearbtn_Click;
            refreshbtn.Click += refreshbtn_Click;

            categorycmb.DropDownStyle = ComboBoxStyle.DropDownList;
            productlist.CellClick += productlist_CellClick;

            LoadProducts();
            LoadDashboardStats();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT COUNT(*) AS TotalProducts, SUM(IIF(Quantity > ReorderLevel, 1, 0)) AS InStock, SUM(IIF(Quantity > 0 AND Quantity <= ReorderLevel, 1, 0 )) AS LowStock, SUM(IIF(Quantity = 0, 1, 0 )) AS OutofStock FROM Products";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbltotal.Text = reader["TotalProducts"] != DBNull.Value ? reader["TotalProducts"].ToString() : "0";
                            lblstock.Text = reader["InStock"] != DBNull.Value ? reader["InStock"].ToString() : "0";
                            lbllow.Text = reader["LowStock"] != DBNull.Value ? reader["LowStock"].ToString() : "0";
                            lblout.Text = reader["OutofStock"] != DBNull.Value ? reader["OutofStock"].ToString() : "0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Statistic error: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = @"SELECT * FROM Products ORDER BY ProductID DESC";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        productlist.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load products: " + ex.Message);
            }
        }

        private bool ValidateProduct()
        {
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Please enter a product name");
                txtname.Focus();
                return false;
            }
            if (categorycmb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product Category");
                categorycmb.Focus();
                return false;
            }

            decimal price;
            if (!decimal.TryParse(txtprice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid product price");
                txtprice.Focus();
                return false;
            }

            int quantity;
            if (!int.TryParse(txtquantity.Text, out quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity");
                txtquantity.Focus();
                return false;
            }

            int reorder;
            if (!int.TryParse(txtreorder.Text, out reorder) || reorder < 0)
            {
                MessageBox.Show("Please enter a valid Reorder Level");
                txtreorder.Focus();
                return false;
            }
            return true;
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = @"INSERT INTO Products (ProductName, Category, Description, UnitPrice, Quantity, ReorderLevel, CreatedAt) VALUES (?,?,?,?,?,?, Now())";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtname.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = categorycmb.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = descriptiontxt.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtprice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtquantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtreorder.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadProducts();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding product: " + ex.Message);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Please select a product row to update");
                return;
            }
            if (!ValidateProduct())
                return;

            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = @"UPDATE Products SET ProductName=?, Category=?, Description=?, UnitPrice=?, Quantity=?, ReorderLevel=? WHERE ProductID=?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = txtname.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = categorycmb.Text;
                        cmd.Parameters.Add("?", OleDbType.LongVarWChar).Value = descriptiontxt.Text.Trim();
                        cmd.Parameters.Add("?", OleDbType.Currency).Value = decimal.Parse(txtprice.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtquantity.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = int.Parse(txtreorder.Text);
                        cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearField();
                LoadDashboardStats();
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (selectedProductID == 0)
            {
                MessageBox.Show("Please select a product row to delete");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (OleDbConnection con = Database.GetConnection())
                    {
                        con.Open();
                        string query = @"DELETE FROM Products WHERE ProductID = ?";

                        using (OleDbCommand cmd = new OleDbCommand(query, con))
                        {
                            cmd.Parameters.Add("?", OleDbType.Integer).Value = selectedProductID;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Product deleted successfully");
                    ClearField();
                    LoadProducts();
                    LoadDashboardStats();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting product: " + ex.Message);
                }
            }
        }

        private void productlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = productlist.Rows[e.RowIndex];
                selectedProductID = Convert.ToInt32(row.Cells["ProductID"].Value);
                txtname.Text = row.Cells["ProductName"].Value?.ToString() ?? "";
                categorycmb.Text = row.Cells["Category"].Value?.ToString() ?? "";
                descriptiontxt.Text = row.Cells["Description"].Value?.ToString() ?? "";
                txtprice.Text = row.Cells["UnitPrice"].Value?.ToString() ?? "";
                txtquantity.Text = row.Cells["Quantity"].Value?.ToString() ?? "";
                txtreorder.Text = row.Cells["ReorderLevel"].Value?.ToString() ?? "";
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtname.Clear();
            categorycmb.SelectedIndex = -1;
            descriptiontxt.Clear();
            txtprice.Clear();
            txtquantity.Clear();
            txtreorder.Clear();
            txtcreated.Clear();
            selectedProductID = 0;
            productlist.ClearSelection();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            LoadProducts();
            LoadDashboardStats();
            ClearField();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection con = Database.GetConnection())
                {
                    con.Open();
                    string query = "SELECT * FROM Products WHERE ProductName LIKE ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.Add("?", OleDbType.VarWChar).Value = "%" + searchbox.Text + "%";

                        using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            productlist.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SignIn_Form signIn = new SignIn_Form();
                signIn.Show();
                this.Hide();
            }
        }
    }
}