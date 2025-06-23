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
using System.Text.RegularExpressions;
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

            // Set up input validation
            ConfigureInputValidation();
        }

        private void ConfigureInputValidation()
        {
            // Only allow numbers and decimal point for price
            txtpurchase.KeyPress += NumericInput_KeyPress;

            // Only allow numbers for quantity
            txtquantity.KeyPress += WholeNumberInput_KeyPress;

            // Prevent entering numbers in name field
            txtName.KeyPress += NameInput_KeyPress;
        }

        private void NumericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow numbers, decimal point, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && ((TextBox)sender).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
        }

        private void WholeNumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only letters, spaces, and control characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                comboCategory.DataSource = AddProductDL.GetCategories();
                comboCategory.DisplayMember = "value";
                comboCategory.ValueMember = "lookup_id";

                comboSupplier.DataSource = AddProductDL.GetSuppliers();
                comboSupplier.DisplayMember = "name";
                comboSupplier.ValueMember = "supplier_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load dropdown data: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // Validate required fields are not empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtquantity.Text.Trim(), out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid quantity (positive whole number).", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtquantity.Focus();
                return;
            }

            if (!decimal.TryParse(txtpurchase.Text.Trim(), out decimal up) || up <= 0)
            {
                MessageBox.Show("Please enter a valid unit price (positive number).", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtpurchase.Focus();
                return;
            }

            Product product = new Product
            {
                Name = txtName.Text.Trim(),
                CategoryId = Convert.ToInt32(comboCategory.SelectedValue),
                SupplierId = Convert.ToInt32(comboSupplier.SelectedValue),
                Size = txtsize.Text.Trim(),
                QuantityInStock = qty,
                UnitPrice = up,
                LastUpdated = dateTimePicker1.Value
            };

            string validationMsg = AddProductBL.ValidateProduct(product);
            if (!string.IsNullOrEmpty(validationMsg))
            {
                MessageBox.Show(validationMsg, "Validation Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = AddProductDL.AddProduct(product);
                if (success)
                {
                    MessageBox.Show("Product added successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add product.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtsize.Clear();
            txtquantity.Clear();
            txtpurchase.Clear();
            if (comboCategory.Items.Count > 0) comboCategory.SelectedIndex = 0;
            if (comboSupplier.Items.Count > 0) comboSupplier.SelectedIndex = 0;
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