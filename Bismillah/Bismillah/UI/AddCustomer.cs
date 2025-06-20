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
using Bismillah.BL;
using Bismillah.DL;

namespace Bismillah.UI
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
            btnBack.LinkClicked += (s, e) => this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }



        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            cnictxt.Clear();
            txtaddress.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer
            {
                Name = txtName.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                CNIC = cnictxt.Text.Trim(),
                Address = txtaddress.Text.Trim()
            };

            string validationMessage = AddCustomerBL.ValidateCustomer(customer);
            if (!string.IsNullOrEmpty(validationMessage))
            {
                MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = AddCustomerDL.AddCustomer(customer);
                if (success)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            CustomerManagement adminDashboard = new CustomerManagement();
            this.Hide();
            adminDashboard.ShowDialog();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
