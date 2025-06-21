
using Bismillah.BL;
using Bismillah.DL;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class CreateBill : Form
    {
        private readonly CreateBillBL _billBL;
        private DataTable _billItems;
        private int _currentStaffId;
        private int _rowNumber = 1;
        private decimal _subtotal = 0;
        private decimal _discountPercentage = 0;

        private PrintDocument printDocument = new PrintDocument();
        private string billContent = "";
        private Font billFont = new Font("Consolas", 10);

        public CreateBill(int staffId)
        {
            InitializeComponent();
            _currentStaffId = staffId;
            _billBL = new CreateBillBL();

            printDocument.PrintPage += printDocument1_PrintPage;

            InitializeData();
        }
        private void GenerateBillContent()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("BISMILLAH SANITARY ELECTRIC AND HARDWARE STORE");
            sb.AppendLine($"Date: {DateTime.Now:dd-MM-yyyy HH:mm}");

            if (rdregular.Checked && cmbCustomer.SelectedItem != null)
            {
                var name = ((DataRowView)cmbCustomer.SelectedItem)["name"].ToString();
                var contact = ((DataRowView)cmbCustomer.SelectedItem)["contact"].ToString();
                sb.AppendLine($"Customer: {name}");
                sb.AppendLine($"Contact: {contact}");
            }
            else
            {
                sb.AppendLine($"Customer: {nametxt.Text.Trim()}");
                sb.AppendLine($"Contact: {contacttxt.Text.Trim()}");
            }

            sb.AppendLine(new string('-', 65));
            sb.AppendLine(string.Format("{0,-4}{1,-28}{2,5}{3,10}{4,12}", "Sr", "Product", "Qty", "Unit", "Total"));
            sb.AppendLine(new string('-', 65));

            foreach (DataRow row in _billItems.Rows)
            {
                string sr = row["sr_no"].ToString();
                string prod = row["name"].ToString();
                if (prod.Length > 27) prod = prod.Substring(0, 27);
                string qty = row["quantity"].ToString();
                string unit = $"Rs. {Convert.ToDecimal(row["unit_price"]):N2}";
                string total = $"Rs. {Convert.ToDecimal(row["total"]):N2}";

                sb.AppendLine(string.Format("{0,-4}{1,-28}{2,5}{3,10}{4,12}", sr, prod, qty, unit, total));
            }

            sb.AppendLine(new string('-', 65));
            sb.AppendLine(string.Format("{0,-20} Rs. {1:N2}", "Subtotal:", _subtotal));
            sb.AppendLine(string.Format("{0,-20} {1}%", "Discount:", _discountPercentage));
            decimal totalAmount = _subtotal - (_subtotal * (_discountPercentage / 100m));
            sb.AppendLine(string.Format("{0,-20} Rs. {1:N2}", "Total:", totalAmount));
            sb.AppendLine(new string('-', 65));
            sb.AppendLine("Thank you for shopping with us!");

            billContent = sb.ToString();
        }
        //private void InitializeData()
        //{
        //    _billItems = new DataTable();
        //    _billItems.Columns.Add("sr_no", typeof(int));
        //    _billItems.Columns.Add("product_id", typeof(int));
        //    _billItems.Columns.Add("name", typeof(string));
        //    _billItems.Columns.Add("quantity", typeof(int));
        //    _billItems.Columns.Add("unit_price", typeof(decimal));
        //    _billItems.Columns.Add("unit_price_display", typeof(string));
        //    _billItems.Columns.Add("total", typeof(decimal));
        //    _billItems.Columns.Add("total_display", typeof(string));

        //    dvgProductsinBill.Columns.Clear();
        //    dvgProductsinBill.DataSource = _billItems;
        //    dvgProductsinBill.ReadOnly = true;

        //    dvgProductsinBill.Columns["sr_no"].HeaderText = "Sr #";
        //    dvgProductsinBill.Columns["name"].HeaderText = "Product Name";
        //    dvgProductsinBill.Columns["quantity"].HeaderText = "Qty";
        //    dvgProductsinBill.Columns["unit_price_display"].HeaderText = "Unit Price";
        //    dvgProductsinBill.Columns["total_display"].HeaderText = "Total";

        //    LoadCustomers();
        //    LoadProducts();
        //    LoadPaymentStatuses();
        //    ClearBillForm();
        //}


        private void InitializeData()
        {
            // Create the DataTable structure
            _billItems = new DataTable();
            _billItems.Columns.Add("sr_no", typeof(int));
            _billItems.Columns.Add("product_id", typeof(int));
            _billItems.Columns.Add("name", typeof(string));
            _billItems.Columns.Add("quantity", typeof(int));
            _billItems.Columns.Add("unit_price", typeof(decimal));
            _billItems.Columns.Add("unit_price_display", typeof(string));
            _billItems.Columns.Add("total", typeof(decimal));
            _billItems.Columns.Add("total_display", typeof(string));

            // Configure DataGridView properties
            dvgProductsinBill.AutoGenerateColumns = false; // This is crucial
            dvgProductsinBill.Columns.Clear();

            // Manually add only the columns we want to display
            AddColumnToGridView("sr_no", "Sr #", 50, true, DataGridViewContentAlignment.MiddleRight);
            AddColumnToGridView("name", "Product Name", 250, true, DataGridViewContentAlignment.MiddleLeft);
            AddColumnToGridView("quantity", "Qty", 60, true, DataGridViewContentAlignment.MiddleRight);
            AddColumnToGridView("unit_price_display", "Unit Price", 100, true, DataGridViewContentAlignment.MiddleRight);
            AddColumnToGridView("total_display", "Total", 120, true, DataGridViewContentAlignment.MiddleRight);

            // Set the data source
            dvgProductsinBill.DataSource = _billItems;
            dvgProductsinBill.ReadOnly = true;

            LoadCustomers();
            LoadProducts();
            LoadPaymentStatuses();
            ClearBillForm();
        }

        private void AddColumnToGridView(string dataPropertyName, string headerText, int width,
                                       bool visible, DataGridViewContentAlignment alignment)
        {
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = dataPropertyName;
            column.HeaderText = headerText;
            column.Width = width;
            column.Visible = visible;
            column.DefaultCellStyle.Alignment = alignment;
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dvgProductsinBill.Columns.Add(column);
        }


        private void LoadCustomers()
        {
            cmbCustomer.DataSource = _billBL.LoadCustomers();
            cmbCustomer.DisplayMember = "name";
            cmbCustomer.ValueMember = "customer_id";
        }

        private void LoadProducts()
        {
            cmbSelectProducts.DataSource = _billBL.LoadProducts();
            cmbSelectProducts.DisplayMember = "name";
            cmbSelectProducts.ValueMember = "product_id";
        }

        private void LoadPaymentStatuses()
        {
            cmbPaymentStatus.DataSource = _billBL.LoadPaymentStatuses();
            cmbPaymentStatus.DisplayMember = "value";
            cmbPaymentStatus.ValueMember = "lookup_id";
        }




        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbSelectProducts.SelectedValue == null || numQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a product and quantity");
                return;
            }

            int productId = Convert.ToInt32(cmbSelectProducts.SelectedValue);
            int quantity = (int)numQuantity.Value;

            if (!_billBL.ValidateProductStock(productId, quantity))
            {
                MessageBox.Show("Insufficient stock");
                return;
            }

            DataRowView selectedProduct = (DataRowView)cmbSelectProducts.SelectedItem;
            decimal unitPrice = Convert.ToDecimal(selectedProduct["unit_price"]);
            decimal total = quantity * unitPrice;

            _billItems.Rows.Add(
                _rowNumber++,
                productId,
                selectedProduct["name"],
                quantity,
                unitPrice,
                DatabaseHelper.FormatAsPKR(unitPrice),
                total,
                DatabaseHelper.FormatAsPKR(total)
            );

            CalculateSubtotal();
            numQuantity.Value = 1;
        }

        private void CalculateSubtotal()
        {
            _subtotal = _billItems.AsEnumerable().Sum(r => Convert.ToDecimal(r["total"]));
            lblSubtotal.Text = DatabaseHelper.FormatAsPKR(_subtotal);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal discount = _subtotal * (_discountPercentage / 100);
            decimal total = _subtotal - discount;
            lblTotal.Text = DatabaseHelper.FormatAsPKR(total);
        }


        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdiscount.Text, out decimal percent) && percent >= 0 && percent <= 100)
            {
                _discountPercentage = percent;
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Discount must be between 0 and 100");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgProductsinBill.SelectedRows)
                dvgProductsinBill.Rows.Remove(row);

            _rowNumber = 1;
            foreach (DataRow row in _billItems.Rows)
                row["sr_no"] = _rowNumber++;

            CalculateSubtotal();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("Add at least one product.");
                return;
            }

            try
            {
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);
                int? customerId = rdregular.Checked ? (int?)cmbCustomer.SelectedValue : null;

                if (rdWalkin.Checked)
                {
                    string name = nametxt.Text.Trim();
                    string contact = contacttxt.Text.Trim();
                    decimal total = _subtotal - (_subtotal * (_discountPercentage / 100));

                    if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(contact))
                    {
                        string insert = $@"
                    INSERT INTO walkin_bills (name, contact, total_amount)
                     VALUES ('{name}', '{contact}', {total})";

                        DatabaseHelper.Instance.Update(insert);
                    }
                }

                int billId = _billBL.ProcessBill(
                    customerId,
                    _currentStaffId,
                    _subtotal * (_discountPercentage / 100),
                    _billItems,
                    paymentStatusId,
                    out string formattedTotal
                );

                MessageBox.Show($"Bill #{billId} saved. Total: {formattedTotal}");
                ClearBillForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving bill: " + ex.Message);
            }
        }

        private void ClearBillForm()
        {

            _billItems.Clear();
            _rowNumber = 1;
            _subtotal = 0;
            _discountPercentage = 0;

            lblSubtotal.Text = "Rs. 0.00";
            lblTotal.Text = "Rs. 0.00";
            txtdiscount.Text = "0";
            numQuantity.Value = 1;
            cmbSelectProducts.SelectedIndex = -1;
            cmbCustomer.SelectedIndex = -1;

            nametxt.Text = "";
            contacttxt.Text = "";

            rdWalkin.Checked = true; // reset to default;
        }

        private void rdregular_CheckedChanged(object sender, EventArgs e)
        {
            grpRegularCustomer.Visible = rdregular.Checked;
            grpcustomers.Visible = !rdregular.Checked;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbCustomer.SelectedValue?.ToString(), out int customerId))
            {
                var (cnic, contact) = _billBL.GetCustomerInfo(customerId);
                customerCNIC.Text = cnic;
                customerLoyaltyPoints.Text = contact;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(billContent, billFont, Brushes.Black,
                new RectangleF(20, 20, e.MarginBounds.Width, e.MarginBounds.Height));
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("Nothing to print.");
                return;
            }

            GenerateBillContent();
            PrintPreviewDialog preview = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };
            preview.ShowDialog();
        }


        private void grpRegularCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void rdWalkin_CheckedChanged(object sender, EventArgs e)
        {

            grpcustomers.Visible = rdWalkin.Checked;
            grpRegularCustomer.Visible = !rdWalkin.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass the current staff ID when creating the CashierDashboard
            CashierDashboard c = new CashierDashboard(_currentStaffId);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }
    }
}