using Bismillah.BL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bismillah
{
    public partial class Returns : Form
    {
        private readonly ReturnsBL returnsBL;
        private DataTable returnItems;
        private AutoCompleteStringCollection productAutoComplete;

        public Returns()
        {
            InitializeComponent();
            returnsBL = new ReturnsBL();
            InitializeReturnItemsTable();
            LoadCustomers();
            productAutoComplete = new AutoCompleteStringCollection();
        }

        private void InitializeReturnItemsTable()
        {
            returnItems = new DataTable();
            returnItems.Columns.Add("product_id", typeof(int));
            returnItems.Columns.Add("product_name", typeof(string));
            returnItems.Columns.Add("unit_price", typeof(decimal));
            returnItems.Columns.Add("quantity", typeof(int));
            returnItems.Columns.Add("total", typeof(decimal));
        }

        private void LoadCustomers()
        {
            cmbCustomer.DataSource = returnsBL.LoadCustomers();
            cmbCustomer.DisplayMember = "name";
            cmbCustomer.ValueMember = "customer_id";
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null && int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerId))
            {
                LoadCustomerProducts(customerId);
                DisplayCustomerDetails(customerId);
            }
        }

        private void LoadCustomerProducts(int customerId, string searchTerm = "")
        {
            cmbProducts.DataSource = returnsBL.SearchCustomerProducts(customerId, searchTerm);
            cmbProducts.DisplayMember = "name";
            cmbProducts.ValueMember = "product_id";

            // Update autocomplete
            productAutoComplete.Clear();
            foreach (DataRowView row in cmbProducts.Items)
            {
                productAutoComplete.Add(row["name"].ToString());
            }
            cmbProducts.AutoCompleteCustomSource = productAutoComplete;
        }

        private void DisplayCustomerDetails(int customerId)
        {
            DataRowView selectedRow = (DataRowView)cmbCustomer.SelectedItem;
            lblCustomerCNIC.Text = $"CNIC: {selectedRow["cnic"]}";
            lblCustomerContact.Text = $"Contact: {selectedRow["contact"]}";
        }

        private void cmbProducts_KeyUp(object sender, KeyEventArgs e)
        {
            if (cmbCustomer.SelectedValue != null &&
                int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerId))
            {
                LoadCustomerProducts(customerId, cmbProducts.Text);
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue != null)
            {
                // Enable quantity field when product is selected
                Quantity.Enabled = true;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedValue == null || Quantity.Value <= 0)
            {
                MessageBox.Show("Please select a product and enter valid quantity");
                return;
            }

            DataRowView selectedProduct = (DataRowView)cmbProducts.SelectedItem;
            decimal unitPrice = Convert.ToDecimal(selectedProduct["unit_price"]);
            int quantity = (int)Quantity.Value;

            DataRow newRow = returnItems.NewRow();
            newRow["product_id"] = selectedProduct["product_id"];
            newRow["product_name"] = selectedProduct["name"];
            newRow["unit_price"] = unitPrice;
            newRow["quantity"] = quantity;
            newRow["total"] = unitPrice * quantity;
            returnItems.Rows.Add(newRow);

            dgvProducts.DataSource = returnItems;
            UpdateSummary();

            // Reset selection
            cmbProducts.SelectedIndex = -1;
            Quantity.Value = 1;
            Quantity.Enabled = false;
        }

        private void UpdateSummary()
        {
            lbltotalitems.Text = $"Total Items: {returnItems.Rows.Count}";
            lblrefund.Text = $"Total Refund: {returnsBL.CalculateRefund(returnItems):C}";
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (returnItems.Rows.Count == 0)
            {
                MessageBox.Show("No items to return");
                return;
            }

            try
            {
                int customerId = Convert.ToInt32(cmbCustomer.SelectedValue);
                if (returnsBL.ProcessCustomerReturn(customerId, returnItems))
                {
                    MessageBox.Show("Return processed successfully");
                    InitializeReturnItemsTable();
                    dgvProducts.DataSource = returnItems;
                    UpdateSummary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing return: {ex.Message}");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeReturnItemsTable();
            dgvProducts.DataSource = returnItems;
            UpdateSummary();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns["Remove"].Index && e.RowIndex >= 0)
            {
                returnItems.Rows.RemoveAt(e.RowIndex);
                dgvProducts.DataSource = returnItems;
                UpdateSummary();
            }
        }
    }
}