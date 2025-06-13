using Bismillah.BL;
using Bismillah.DL;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class frmBilling : Form
    {
        private readonly frmBillingBL _billingBL;
        private DataTable _products;
        private DataTable _customers;
        private DataTable _paymentStatuses;
        private DataTable _billItems;
        private int _currentStaffId;

        public frmBilling(int staffId)
        {
            InitializeComponent();
            _currentStaffId = staffId;
            _billingBL = new frmBillingBL();
            InitializeDataTables();
        }

        private void InitializeDataTables()
        {
            // Initialize products table
            _products = new DataTable();
            _products.Columns.Add("product_id", typeof(int));
            _products.Columns.Add("name", typeof(string));
            _products.Columns.Add("selling_price", typeof(decimal));
            _products.Columns.Add("batch_id", typeof(int));
            _products.Columns.Add("quantity", typeof(int));

            // Initialize bill items table
            _billItems = new DataTable();
            _billItems.Columns.Add("SrNo", typeof(int));
            _billItems.Columns.Add("ProductID", typeof(int));
            _billItems.Columns.Add("ProductName", typeof(string));
            _billItems.Columns.Add("Quantity", typeof(int));
            _billItems.Columns.Add("UnitPrice", typeof(decimal));
            _billItems.Columns.Add("TotalPrice", typeof(decimal));
            _billItems.Columns.Add("BatchID", typeof(int));
        }
        private void frmBilling_Load_1(object sender, EventArgs e)
        {
            // Initialize DataGridView columns
            dgvBillItems.Columns.Clear();
            dgvBillItems.Columns.Add("SrNo", "Sr.No");
            dgvBillItems.Columns.Add("ProductID", "Product ID");
            dgvBillItems.Columns.Add("ProductName", "Product Name");
            dgvBillItems.Columns.Add("Quantity", "Quantity");

            // Add columns with PKR formatting
            DataGridViewColumn unitPriceCol = new DataGridViewTextBoxColumn();
            unitPriceCol.Name = "UnitPrice";
            unitPriceCol.HeaderText = "Unit Price (Rs.)";
            dgvBillItems.Columns.Add(unitPriceCol);

            DataGridViewColumn totalPriceCol = new DataGridViewTextBoxColumn();
            totalPriceCol.Name = "TotalPrice";
            totalPriceCol.HeaderText = "Total (Rs.)";
            dgvBillItems.Columns.Add(totalPriceCol);

            dgvBillItems.Columns.Add("BatchID", "Batch ID");

            // Format currency columns
            dgvBillItems.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            dgvBillItems.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";

            // Hide ID columns
            dgvBillItems.Columns["ProductID"].Visible = false;
            dgvBillItems.Columns["BatchID"].Visible = false;

            // Rest of your initialization code...
        }


        private void LoadProducts(string searchTerm = "")
        {
            try
            {
                DataTable products = _billingBL.SearchProducts(searchTerm);

                // Add display text column
                products.Columns.Add("DisplayText", typeof(string));

                // Format display text with PKR
                foreach (DataRow row in products.Rows)
                {
                    decimal price = Convert.ToDecimal(row["selling_price"]);
                    row["DisplayText"] = $"{row["name"]} - Rs. {price.ToString("N2")}";
                }

                cmbproducts.DataSource = products;
                cmbproducts.DisplayMember = "DisplayText";
                cmbproducts.ValueMember = "product_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}");
            }
        }

        private void AddProductToBill()
        {
            if (cmbproducts.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)cmbproducts.SelectedItem;

                // Check if product already exists in grid
                foreach (DataGridViewRow row in dgvBillItems.Rows)
                {
                    if (row.Cells["ProductID"].Value.ToString() == selectedRow["product_id"].ToString())
                    {
                        MessageBox.Show("This product is already added to the bill.");
                        return;
                    }
                }

                // Add to grid
                int srNo = dgvBillItems.Rows.Count + 1;
                int quantity = (int)numQuantity.Value;
                decimal price = Convert.ToDecimal(selectedRow["selling_price"]);
                decimal total = quantity * price;

                dgvBillItems.Rows.Add(
                    srNo,
                    selectedRow["product_id"],
                    selectedRow["name"],
                    quantity,
                    price,
                    total,
                    selectedRow["batch_id"]
                );

                // Reset for next product
                cmbproducts.SelectedIndex = -1;
                cmbproducts.Text = "";
                numQuantity.Value = 1;
                cmbproducts.Focus();

                UpdateTotals();
            }
        }

        private void UpdateTotals()
        {
            decimal subTotal = 0;

            foreach (DataGridViewRow row in dgvBillItems.Rows)
            {
                if (row.Cells["TotalPrice"].Value != null)
                {
                    subTotal += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }

            lblSubTotal.Text = FormatPkr(subTotal);

            // Calculate discount
            decimal discount = 0;
            if (!string.IsNullOrEmpty(txtDiscount.Text))
            {
                decimal.TryParse(txtDiscount.Text, out discount);
            }

            // Calculate tax (17% GST)
            decimal tax = subTotal * 0.17m;
            lblTax.Text = FormatPkr(tax);

            // Calculate total
            decimal total = subTotal - discount + tax;
            lblTotal.Text = FormatPkr(total);
        }

        private string FormatPkr(decimal amount)
        {
            return "Rs. " + amount.ToString("N2");
        }
        private void LoadInitialData()
        {
            _products = _billingBL.GetAllAvailableProducts();
            _customers = _billingBL.GetCustomers();
            _paymentStatuses = _billingBL.GetPaymentStatuses();

            cmbPaymentStatus.DataSource = _paymentStatuses;
            cmbPaymentStatus.DisplayMember = "value";
            cmbPaymentStatus.ValueMember = "lookup_id";

            txtBillNumber.Text = GenerateBillNumber();
        }

        private void SetupDataGridView()
        {
            dgvBillItems.DataSource = _billItems;
            dgvBillItems.Columns["ProductID"].Visible = false;
            dgvBillItems.Columns["BatchID"].Visible = false;
        }

        private void SetDefaultValues()
        {
            dtpBillDate.Value = DateTime.Now;
            numQuantity.Value = 1;
            rbWalkIn.Checked = true;
        }

        private string GenerateBillNumber()
        {
            return $"BIL-{DateTime.Now:yyyyMMdd}-{new Random().Next(1000, 9999)}";
        }

        private void cmbproducts_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbproducts.SelectedIndex >= 0)
                {
                    // Product is selected, move to quantity
                    numQuantity.Focus();
                    numQuantity.Select(0, numQuantity.Value.ToString().Length);
                }
                else
                {
                    // No selection, search for products
                    LoadProducts(cmbproducts.Text);
                    if (cmbproducts.Items.Count > 0)
                    {
                        cmbproducts.DroppedDown = true; // Show dropdown
                    }
                }
            }
        }

        private void SearchAndDisplayProducts()
        {
            string searchTerm = cmbproducts.Text.Trim();
            _products = _billingBL.SearchProducts(searchTerm);

            if (_products.Rows.Count == 1)
            {
                DisplayProductDetails(_products.Rows[0]);
                numQuantity.Focus();
            }
            else if (_products.Rows.Count > 1)
            {
                ShowProductSelectionDialog();
            }
            else
            {
                MessageBox.Show("No products found matching your search.");
            }
        }

        private void DisplayProductDetails(DataRow product)
        {
            cmbproducts.Text = $"{product["name"]} - {Convert.ToDecimal(product["selling_price"]):C}";
            cmbproducts.Tag = product; // Store the product row
        }

        private void ShowProductSelectionDialog()
        {
            // Implement a dialog to select from multiple products
            // For simplicity, we'll just select the first one here
            if (_products.Rows.Count > 0)
            {
                DisplayProductDetails(_products.Rows[0]);
                numQuantity.Focus();
            }
        }




        private void numQuantity_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && numQuantity.Value > 0)
            {
                AddProductToBill();
            }
        }
        
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvBillItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvBillItems.SelectedRows)
                {
                    dgvBillItems.Rows.Remove(row);
                }
                UpdateTotals();
                RenumberRows();
            }
        }

        private void RenumberRows()
        {
            for (int i = 0; i < _billItems.Rows.Count; i++)
            {
                _billItems.Rows[i]["SrNo"] = i + 1;
            }
        }

        private void rbWalkIn_CheckedChanged(object sender, EventArgs e)
        {
            _customers = _billingBL.GetCustomers();
            cmbCustomers.DataSource = _customers;
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.ValueMember = "customer_id";
            cmbCustomers.Text = "";
            lblCustomerName.Text = "";
            lblContact.Text = "";
            lblLoyaltyPoints.Text = "";
        }

        private void rbRegular_CheckedChanged(object sender, EventArgs e)
        {
            _customers = _billingBL.GetCustomers(true);
            cmbCustomers.DataSource = _customers;
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.ValueMember = "customer_id";
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue != null && int.TryParse(cmbCustomers.SelectedValue.ToString(), out int customerId))
            {
                var customer = _billingBL.GetCustomerDetails(customerId);
                if (customer != null)
                {
                    lblCustomerName.Text = customer["name"].ToString();
                    lblContact.Text = customer["contact"].ToString();
                    lblLoyaltyPoints.Text = customer["loyalty_points"].ToString();
                }
            }
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product to the bill.");
                return;
            }

            try
            {
                // Get customer ID if selected
                int? customerId = null;
                if (cmbCustomers.SelectedValue != null && int.TryParse(cmbCustomers.SelectedValue.ToString(), out int custId))
                {
                    customerId = custId;
                }

                // Get payment status
                int? paymentStatusId = null;
                if (cmbPaymentStatus.SelectedValue != null && int.TryParse(cmbPaymentStatus.SelectedValue.ToString(), out int statusId))
                {
                    paymentStatusId = statusId;
                }

                // Calculate totals
                decimal subTotal = _billingBL.CalculateSubTotal(_billItems);
                decimal discount = decimal.TryParse(txtDiscount.Text, out decimal d) ? d : 0;
                decimal taxRate = 0.17m; // Example tax rate

                // Process bill
                int billId = _billingBL.ProcessBill(
                    customerId,
                    _currentStaffId,
                    dtpBillDate.Value,
                    subTotal,
                    discount,
                    taxRate,
                    paymentStatusId,
                    _billItems
                );

                MessageBox.Show($"Bill #{billId} saved successfully!");
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bill: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            _billItems.Rows.Clear();
            txtBillNumber.Text = GenerateBillNumber();
            dtpBillDate.Value = DateTime.Now;
            cmbproducts.Text = "";
            numQuantity.Value = 1;
            txtDiscount.Text = "";
            lblSubTotal.Text = "0";
            lblTax.Text = "0";
            lblTotal.Text = "0";
            cmbproducts.Focus();
        }

        private void btnNewCustomer_Click_1(object sender, EventArgs e)
        {
            // Implement customer management form
            MessageBox.Show("Customer management functionality would be implemented here.");
        }

       
    }
}