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
            cmbregular.SelectedIndex = 1;
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {


            if (cmbregular.Items.Count == 0)
            {
                cmbregular.Items.Add("Yes");
                cmbregular.Items.Add("No");
            }
            cmbregular.SelectedIndex = 1;
           
        }

        private void button1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Name = txtName.Text.Trim(),
                    Contact = txtContact.Text.Trim(),
                    CNIC = cnictxt.Text.Trim(),
                    Address = txtaddress.Text.Trim(),
                    LoyaltyPoints = int.TryParse(txtpoints.Text.Trim(), out int pts) ? pts : 0,
                    IsRegular = cmbregular.SelectedItem != null && cmbregular.SelectedItem.ToString().ToLower() == "yes"
                };

                string validationMessage = AddCustomerBL.ValidateCustomer(customer);
                if (!string.IsNullOrEmpty(validationMessage))
                {
                    MessageBox.Show(validationMessage, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
       
        private void ClearForm()
        {
            txtName.Clear();
            txtContact.Clear();
            cnictxt.Clear();
            txtaddress.Clear();
            txtpoints.Clear();
            cmbregular.SelectedIndex = 1;
        }
    }
}
