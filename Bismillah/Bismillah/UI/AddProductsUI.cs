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
    public partial class AddProductsUI : Form
    {
        public AddProductsUI()
        {
            InitializeComponent();
            LoadComboBoxes();
            btnBack.LinkClicked += (s, e) => this.Close();

        }



        private void LoadComboBoxes()
        {
            comboCategory.DataSource = AddProductDL.GetCategories();
            comboCategory.DisplayMember = "value";
            comboCategory.ValueMember = "lookup_id";

            comboSupplier.DataSource = AddProductDL.GetSuppliers();
            comboSupplier.DisplayMember = "name";
            comboSupplier.ValueMember = "supplier_id";
        }

        private void AddProductsUI_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = txtName.Text.Trim(),
                CategoryId = Convert.ToInt32(comboCategory.SelectedValue),
                SupplierId = Convert.ToInt32(comboSupplier.SelectedValue),
                Size = txtsize.Text.Trim(),
                QuantityInStock = int.TryParse(txtquantity.Text.Trim(), out int qty) ? qty : -1,
                UnitPrice = decimal.TryParse(txtpurchase.Text.Trim(), out decimal up) ? up : -1,
                LastUpdated = dateTimePicker1.Value
            };

            string validationMsg = AddProductBL.ValidateProduct(product);
            if (!string.IsNullOrEmpty(validationMsg))
            {
                MessageBox.Show(validationMsg, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = AddProductDL.AddProduct(product);
            if (success)
            {
                MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtsize.Clear();
            txtquantity.Clear();
            txtpurchase.Clear();
            comboCategory.SelectedIndex = 0;
            comboSupplier.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_Click(object sender, EventArgs e)
        {
            ProductManagement p = new ProductManagement();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }
    }
}
