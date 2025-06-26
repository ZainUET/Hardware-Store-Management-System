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
using System.Xml.Linq;

namespace Bismillah.UI
{
    public partial class CustomerUI : Form
    {
        public CustomerUI()
        {
            InitializeComponent();
            this.Load += CustomerUI_Load;
        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            LoadAllCustomers();

        }
        private void LoadAllCustomers()
        {
            DataTable dt = CustomerDL.GetAllCustomers();
            dgvcustomer.DataSource = dt;
            dgvcustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvcustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }


        private string Prompt(string title, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, "Edit Customer", defaultValue);
        }


        private void edit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvcustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(dgvcustomer.SelectedRows[0].Cells["customer_id"].Value);
            Customer customer = CustomerDL.GetCustomerById(customerId);

            string newName = Prompt("Name:", customer.Name);
            string newContact = Prompt("Contact:", customer.Contact);
            string newCNIC = Prompt("CNIC:", customer.CNIC);
            string newAddress = Prompt("Address:", customer.Address);

            customer.Name = newName;
            customer.Contact = newContact;
            customer.CNIC = newCNIC;
            customer.Address = newAddress;

            string validation = CustomerBL.ValidateForEdit(customer);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool updated = CustomerDL.UpdateCustomer(customer);
            if (updated)
            {
                MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllCustomers();
            }
            else
            {
                MessageBox.Show("Failed to update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvcustomer.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.",
                              "No Selection",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }

            int customerId = Convert.ToInt32(dgvcustomer.SelectedRows[0].Cells["customer_id"].Value);
            string customerName = dgvcustomer.SelectedRows[0].Cells["name"].Value.ToString();

            try
            {
                // Check dependencies first (optional - we'll check again in DeleteCustomer)
                var dependencies = CustomerDL.CheckCustomerDependencies(customerId);

                if (dependencies.Any())
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine($"Cannot delete customer '{customerName}' because they have:");
                    sb.AppendLine();

                    foreach (var dep in dependencies)
                    {
                        sb.AppendLine($"• {dep.RecordCount} record(s) in {dep.TableName}");
                    }

                    sb.AppendLine();
                    sb.AppendLine("Please resolve these dependencies first before deleting the customer.");

                    MessageBox.Show(sb.ToString(),
                                  "Cannot Delete Customer",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }

                // Confirm deletion
                var confirmResult = MessageBox.Show($"Are you sure you want to delete customer: {customerName}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    if (CustomerDL.DeleteCustomer(customerId))
                    {
                        MessageBox.Show($"Customer '{customerName}' deleted successfully.",
                                      "Success",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                        LoadAllCustomers(); // Refresh your data grid
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete customer '{customerName}'.",
                                      "Error",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Cannot Delete Customer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the customer: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerManagement addCustomer = new CustomerManagement();
            this.Hide();
            addCustomer.ShowDialog();
            this.Close();
        }
    }
}
