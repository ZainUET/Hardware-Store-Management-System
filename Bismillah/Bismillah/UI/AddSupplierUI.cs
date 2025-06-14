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
        }

        private void AddSupplierUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Supplier supplier = new Supplier
            {
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                CNIC = cnictxt.Text.Trim(),
                Address = txtaddress.Text.Trim(),
                Company = txtcomapny.Text.Trim()
            };

            string validationMessage = AddSupplierBL.ValidateSupplier(supplier);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = AddSupplierDL.AddSupplier(supplier);
                if (success)
                {
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            cnictxt.Clear();
            txtaddress.Clear();
            txtcomapny.Clear();

        }
    }
}
