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


        }
        private void LoadProducts()
        {
            dgvProducts.DataSource = ProductDL.GetAllProducts();
        }


        private void ProductUI_Load(object sender, EventArgs e)
        {

        }

        private string Prompt(string field, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(field, "Edit Product", defaultValue);
        }
        private void edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

            // Prompt fields (edit only editable fields)
            string name = Prompt("Product Name", p.Name);
            string size = Prompt("Size", p.Size);
            string quantity = Prompt("Quantity In Stock", p.QuantityInStock.ToString());
            string unitPrice = Prompt("Unit Price", p.UnitPrice.ToString());

            p.Name = name;
            p.Size = size;
            p.QuantityInStock = int.TryParse(quantity, out int q) ? q : 0;
            p.UnitPrice = decimal.TryParse(unitPrice, out decimal up) ? up : 0;

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

        private void delete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProductManagement productManagement = new ProductManagement();
            this.Hide();
            productManagement.ShowDialog();
            this.Close();
        }
    }
}

