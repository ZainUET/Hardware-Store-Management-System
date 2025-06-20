
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
        private PrintDocument printDocument = new PrintDocument();
        private string billTitle = "BISMILLAH SANITARY ELECTRIC AND HARDWARE STORE";
        private Font billFont = new Font("Consolas", 10, FontStyle.Regular);
        private string billContent = "";
        private readonly CreateBillBL _billBL;
        private DataTable _billItems;
        private int _currentStaffId;
        private int _rowNumber = 1;
        private decimal _subtotal = 0;
        private decimal _discountPercentage = 0;

        public CreateBill(int staffId)
        {
            InitializeComponent();
            _billBL = new CreateBillBL();
            _currentStaffId = staffId;
            printDocument.PrintPage += printDocument1_PrintPage;
            InitializeData();
        }
        private void GenerateBillContent()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(billTitle);
            sb.AppendLine($"Date: {DateTime.Now:dd-MM-yyyy HH:mm}");
            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"{"Sr",-4}{"Product",-28}{"Qty",5}{"Unit",10}{"Total",12}");
            sb.AppendLine(new string('-', 60));

            foreach (DataRow row in _billItems.Rows)
            {
                string sr = row["sr_no"].ToString();
                string product = row["name"].ToString();
                if (product.Length > 27) product = product.Substring(0, 27); // truncate

                string qty = row["quantity"].ToString();
                string unit = $"Rs. {Convert.ToDecimal(row["unit_price"]):N2}";
                string total = $"Rs. {Convert.ToDecimal(row["total"]):N2}";

                sb.AppendLine($"{sr,-4}{product,-28}{qty,5}{unit,10}{total,12}");
            }

            sb.AppendLine(new string('-', 60));
            sb.AppendLine($"{"Subtotal:",-20} Rs. {_subtotal:N2}");
            sb.AppendLine($"{"Discount:",-20} {_discountPercentage}%");
            decimal totalAmount = _subtotal - (_subtotal * (_discountPercentage / 100m));
            sb.AppendLine($"{"Total:",-20} Rs. {totalAmount:N2}");
            sb.AppendLine(new string('-', 60));
            sb.AppendLine("Thank you for shopping with us!");

            billContent = sb.ToString();
        }
        private void InitializeData()
        {
            _billItems = new DataTable();
            _billItems.Columns.Add("sr_no", typeof(int));
            _billItems.Columns.Add("product_id", typeof(int));
            _billItems.Columns.Add("name", typeof(string));
            _billItems.Columns.Add("quantity", typeof(int));
            _billItems.Columns.Add("unit_price", typeof(decimal));
            _billItems.Columns.Add("unit_price_display", typeof(string));
            _billItems.Columns.Add("total", typeof(decimal));
            _billItems.Columns.Add("total_display", typeof(string));
            dvgProductsinBill.DataSource = _billItems;

            LoadCustomers();
            LoadProducts();
            LoadPaymentStatuses();
            ClearBillForm();
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
            SetDefaultPaymentStatus();
        }

        private void SetDefaultPaymentStatus()
        {
            foreach (DataRowView item in cmbPaymentStatus.Items)
            {
                if (item["value"].ToString() == "Pending")
                {
                    cmbPaymentStatus.SelectedItem = item;
                    break;
                }
            }
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
                MessageBox.Show("Insufficient stock for this product");
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
            _subtotal = _billItems.AsEnumerable().Sum(row => Convert.ToDecimal(row["total"]));
            lblSubtotal.Text = DatabaseHelper.FormatAsPKR(_subtotal);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal discountAmount = _subtotal * (_discountPercentage / 100m);
            decimal total = _subtotal - discountAmount;
            lblTotal.Text = DatabaseHelper.FormatAsPKR(total);
        }


        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdiscount.Text, out decimal discountPercent) && discountPercent >= 0 && discountPercent <= 100)
            {
                _discountPercentage = discountPercent;
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Discount must be between 0 and 100");
                txtdiscount.Text = "0";
                _discountPercentage = 0;
                CalculateTotal();
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
                MessageBox.Show("Add products before saving.");
                return;
            }

            try
            {
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);
                int? customerId = rdregular.Checked ? (int?)cmbCustomer.SelectedValue : null;

                int billId = _billBL.ProcessBill(
                    customerId,
                    _currentStaffId,
                    _subtotal * (_discountPercentage / 100m),
                    _billItems,
                    paymentStatusId,
                    out string formattedTotal
                );

                MessageBox.Show($"Bill #{billId} saved. Total: {formattedTotal}");
                ClearBillForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bill: {ex.Message}");
            }
        }

        private void ClearBillForm()
        {
            _billItems.Rows.Clear();
            _rowNumber = 1;
            _subtotal = 0;
            _discountPercentage = 0;

            cmbCustomer.SelectedIndex = -1;
            cmbSelectProducts.SelectedIndex = -1;
            txtdiscount.Text = "0";
            numQuantity.Value = 1;

            lblSubtotal.Text = "Rs. 0.00";
            lblTotal.Text = "Rs. 0.00";
            rdWalkin.Checked = true;
            grpRegularCustomer.Visible = false;
        }

        private void rdregular_CheckedChanged(object sender, EventArgs e)
        {
            grpRegularCustomer.Visible = rdregular.Checked;
            if (!rdregular.Checked)
            {
                cmbCustomer.SelectedIndex = -1;
                customerCNIC.Text = string.Empty;
                customerLoyaltyPoints.Text = string.Empty;
            }
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
            float x = 20, y = 20;
            e.Graphics.DrawString(billContent, billFont, Brushes.Black, new RectangleF(x, y, e.MarginBounds.Width, e.MarginBounds.Height));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("No bill to print.");
                return;
            }

            GenerateBillContent();

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument,
                Width = 800,
                Height = 600
            };

            previewDialog.ShowDialog();
        }
    }
}