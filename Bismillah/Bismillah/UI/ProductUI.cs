using Bismillah.BL;
using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class ProductUI : Form
    {
        public ProductUI()
        {
            InitializeComponent();
            LoadProducts();
            btnback.LinkClicked += (s, e) => this.Close();
           
        }
        private void LoadProducts()
        {
            dgvProducts.DataSource = ProductDL.GetAllProducts();
        }


        private void ProductUI_Load(object sender, EventArgs e)
        {

        }

        private void btnedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to edit.");
                return;
            }

            int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["product_id"].Value);
            Product p = ProductDL.GetProductById(id);
            if (p == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            // Prompt fields
            string name = Prompt("Product Name", p.Name);
            string size = Prompt("Size", p.Size);
            string quantity = Prompt("Quantity", p.Quantity.ToString());
            string purchase = Prompt("Purchase Price", p.PurchasePrice.ToString());
            string sale = Prompt("Selling Price", p.SellingPrice.ToString());

            p.Name = name;
            p.Size = size;
            p.Quantity = int.TryParse(quantity, out int q) ? q : 0;
            p.PurchasePrice = decimal.TryParse(purchase, out decimal pp) ? pp : 0;
            p.SellingPrice = decimal.TryParse(sale, out decimal sp) ? sp : 0;

            string msg = ProductBL.ValidateProduct(p);
            if (!string.IsNullOrEmpty(msg))
            {
                MessageBox.Show(msg, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ProductDL.UpdateProduct(p))
            {
                MessageBox.Show("Product updated successfully.");
                LoadProducts();
            }
            else
            {
                MessageBox.Show("Failed to update product.");
            }
        }

        private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            int id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["product_id"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (ProductDL.DeleteProduct(id))
                {
                    MessageBox.Show("Product deleted.");
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Failed to delete product.");
                }
            }
        }
        public void dataview()
        {
            DataTable dataTable = new DataTable();
            string query1 = $"Select * from products";
            dataTable = DatabaseHelper.Instance.GetDataTable(query1);
            dgvProducts.DataSource = dataTable;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducts.Refresh();
        }
        private string Prompt(string field, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(field, "Edit Product", defaultValue);
        }
    }
}

