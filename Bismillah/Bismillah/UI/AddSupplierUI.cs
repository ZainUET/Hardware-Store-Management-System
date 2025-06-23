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
    public partial class AddSupplierUI : Form
    {
        public AddSupplierUI()
        {
            InitializeComponent();
            btnBack.LinkClicked += (s, e) => this.Close();

            // Set up input restrictions
            SetupInputValidation();
        }

        private void SetupInputValidation()
        {
            // CNIC TextBox - only numbers, max 13 digits
            cnictxt.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limit to 13 characters
                if (cnictxt.Text.Length >= 13 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            // Contact TextBox - only numbers, max 11 digits
            txtContact.KeyPress += (s, e) =>
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                // Limit to 11 characters
                if (txtContact.Text.Length >= 11 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            };
        }

        private void AddSupplierUI_Load(object sender, EventArgs e)
        {
            // Optional: Add input masks
            // cnictxt.Mask = "0000000000000"; // 13 digits
            // txtContact.Mask = "00000000000"; // 11 digits
        }

        private void button1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Supplier supplier = new Supplier
            {
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                CNIC = cnictxt.Text.Trim(),
                Company = txtcomapny.Text.Trim()
            };

            // Validate CNIC (must be exactly 13 digits)
            if (supplier.CNIC.Length != 13)
            {
                MessageBox.Show("CNIC must be exactly 13 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cnictxt.Focus();
                return;
            }

            // Validate Contact (must be exactly 11 digits)
            if (supplier.Contact.Length != 11)
            {
                MessageBox.Show("Contact number must be exactly 11 digits.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContact.Focus();
                return;
            }

            string validationMessage = AddSupplierBL.ValidateSupplier(supplier);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = AddSupplierDL.AddSupplier(supplier);
                if (success)
                {
                    MessageBox.Show("Supplier added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            cnictxt.Clear();
            txtcomapny.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierManagement supplierManagement = new SupplierManagement();
            this.Hide();
            supplierManagement.ShowDialog();
            this.Close();
        }
    }
}