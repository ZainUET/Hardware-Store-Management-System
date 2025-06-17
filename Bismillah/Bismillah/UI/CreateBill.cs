using Bismillah.BL;
using Bismillah.DL;
using System.Data;

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

        public CreateBill(int staffId)
        {
            InitializeComponent();
            _billBL = new CreateBillBL();
            _currentStaffId = staffId;

            // Wire up print events
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.EndPrint += printDocument1_EndPrint;

            InitializeData();
            ConfigureDataGridView();
        }

        private void InitializeData()
        {
            // Load dropdowns
            cmbCustomer.DataSource = _billBL.LoadCustomers();
            cmbCustomer.DisplayMember = "name";
            cmbCustomer.ValueMember = "customer_id";

            cmbSelectProducts.DataSource = _billBL.LoadProducts();
            cmbSelectProducts.DisplayMember = "name";
            cmbSelectProducts.ValueMember = "product_id";

            // Load payment statuses
            cmbPaymentStatus.DataSource = _billBL.LoadPaymentStatuses();
            cmbPaymentStatus.DisplayMember = "value";
            cmbPaymentStatus.ValueMember = "lookup_id";

            // Initialize bill items table
            _billItems = new DataTable();
            _billItems.Columns.Add("sr_no", typeof(int));
            _billItems.Columns.Add("product_id", typeof(int));
            _billItems.Columns.Add("name", typeof(string));
            _billItems.Columns.Add("quantity", typeof(int));
            _billItems.Columns.Add("unit_price", typeof(decimal));
            _billItems.Columns.Add("unit_price_display", typeof(string));
            _billItems.Columns.Add("total", typeof(decimal));
            _billItems.Columns.Add("total_display", typeof(string));
            _billItems.Columns.Add("batch_id", typeof(int));

            dvgProductsinBill.DataSource = _billItems;

            // Set default values
            ClearBillForm();
            BillDate.Value = DateTime.Now;
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

        private void ResetCustomerTypeSelection()
        {
            rdWalkin.Checked = true;
            grpRegularCustomer.Visible = false;
            cmbCustomer.SelectedIndex = -1;
            customerCNIC.Text = string.Empty;
            customerLoyaltyPoints.Text = string.Empty;
        }
        private void ConfigureDataGridView()
        {
            dvgProductsinBill.AutoGenerateColumns = false;
            dvgProductsinBill.Columns.Clear();

            // Add columns
            dvgProductsinBill.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "sr_no",
                HeaderText = "Sr.No",
                Width = 60
            });

            dvgProductsinBill.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "name",
                HeaderText = "Name",
                Width = 200
            });

            dvgProductsinBill.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "quantity",
                HeaderText = "Qty",
                Width = 80
            });

            dvgProductsinBill.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "unit_price_display",
                HeaderText = "Unit Price",
                Width = 100
            });

            dvgProductsinBill.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "total_display",
                HeaderText = "Total",
                Width = 100
            });

            // Hide technical columns
            dvgProductsinBill.Columns["product_id"].Visible = false;
            dvgProductsinBill.Columns["unit_price"].Visible = false;
            dvgProductsinBill.Columns["total"].Visible = false;
            dvgProductsinBill.Columns["batch_id"].Visible = false;
        }

        private int GetNextBillNumber()
        {
            return new Random().Next(1000, 9999);
        }

        private void rdregular_CheckedChanged(object sender, EventArgs e)
        {
            grpRegularCustomer.Visible = rdregular.Checked;

            // Clear customer selection if switching to Walk-in
            if (!rdregular.Checked)
            {
                cmbCustomer.SelectedIndex = -1;
                customerCNIC.Text = string.Empty;
                customerLoyaltyPoints.Text = string.Empty;
            }
        }

        private void rdWalkin_CheckedChanged(object sender, EventArgs e)
        {
            grpRegularCustomer.Visible = !rdWalkin.Checked;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null && int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerId))
            {
                var (cnic, points) = _billBL.GetCustomerInfo(customerId);
                customerCNIC.Text = cnic;
                customerLoyaltyPoints.Text = points;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (cmbSelectProducts.SelectedValue == null || numQuantity.Value <= 0) return;

            int productId = Convert.ToInt32(cmbSelectProducts.SelectedValue);
            int quantity = (int)numQuantity.Value;

            if (!_billBL.HasSufficientStock(productId, quantity))
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
                DatabaseHelper.FormatAsPKR(total),
                DBNull.Value // Batch ID will be set when saving
            );

            CalculateSubtotal();
            numQuantity.Value = 1;
        }
        private void CalculateSubtotal()
        {
            _subtotal = _billItems.AsEnumerable()
                .Sum(row => Convert.ToDecimal(row["total"]));

            lblSubtotal.Text = DatabaseHelper.FormatAsPKR(_subtotal);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal discountAmount = _subtotal * (_discountPercentage / 100);
            decimal total = _subtotal - discountAmount;
            lblTotal.Text = DatabaseHelper.FormatAsPKR(total);
        }
        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtdiscount.Text, out decimal discountPercent))
            {
                if (discountPercent >= 0 && discountPercent <= 100)
                {
                    _discountPercentage = discountPercent;
                    CalculateTotal();
                }
                else
                {
                    MessageBox.Show("Discount percentage must be between 0 and 100");
                    txtdiscount.Text = "0";
                    _discountPercentage = 0;
                    CalculateTotal();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid discount percentage");
                txtdiscount.Text = "0";
                _discountPercentage = 0;
                CalculateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dvgProductsinBill.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dvgProductsinBill.SelectedRows)
                {
                    dvgProductsinBill.Rows.Remove(row);
                }
                // Reset serial numbers
                _rowNumber = 1;
                foreach (DataRow row in _billItems.Rows)
                {
                    row["sr_no"] = _rowNumber++;
                }
                CalculateSubtotal();
            }
        }
        private void LoadCustomers()
        {
            var customers = _billBL.LoadCustomers();
            cmbCustomer.DataSource = customers;
            cmbCustomer.DisplayMember = "name";        // Must match column name exactly
            cmbCustomer.ValueMember = "customer_id";   // Must match column name exactly
        }
        private void LoadProducts()
        {
            var products = _billBL.LoadProducts();
            cmbSelectProducts.DataSource = products;
            cmbSelectProducts.DisplayMember = "name";  // Must match column name
            cmbSelectProducts.ValueMember = "product_id"; // Must match column name
        }
        private void LoadPaymentStatuses()
        {
            var statuses = _billBL.LoadPaymentStatuses();
            cmbPaymentStatus.DataSource = statuses;
            cmbPaymentStatus.DisplayMember = "value";      // As returned by your query
            cmbPaymentStatus.ValueMember = "lookup_id";    // Must match column name exactly
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add products to the bill");
                return;
            }

            try
            {
                int paymentStatusId = Convert.ToInt32(cmbPaymentStatus.SelectedValue);
                int? customerId = rdregular.Checked ? (int?)cmbCustomer.SelectedValue : null;

                int billId = _billBL.ProcessBill(
                    customerId,
                    _currentStaffId,
                    _subtotal * (_discountPercentage / 100),
                    _billItems,
                    paymentStatusId,
                    out string formattedTotal
                );

                MessageBox.Show($"Bill #{billId} saved successfully!\nTotal: {formattedTotal}");
                ClearBillForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving bill: {ex.Message}");
            }
        }

        private void ClearBillForm()
        {
            // Clear bill items
            _billItems.Rows.Clear();
            _rowNumber = 1;
            _subtotal = 0;
            _discountPercentage = 0;

            // Reset form controls
            cmbCustomer.SelectedIndex = -1;
            cmbSelectProducts.SelectedIndex = -1;
            numQuantity.Value = 1;
            txtdiscount.Text = "0";

            // Reset payment status to default (Pending)
            foreach (DataRowView item in cmbPaymentStatus.Items)
            {
                if (item["value"].ToString() == "Pending")
                {
                    cmbPaymentStatus.SelectedItem = item;
                    break;
                }
            }

            // Reset customer info display
            customerCNIC.Text = string.Empty;
            customerLoyaltyPoints.Text = string.Empty;

            // Reset totals display
            lblSubtotal.Text = "Rs. 0.00";
            lblTotal.Text = "Rs. 0.00";

            // Generate new bill number
            txtBillNumber.Text = GetNextBillNumber().ToString();

            // Reset customer type selection
            rdWalkin.Checked = true;
            grpRegularCustomer.Visible = false;

            // Set focus to product selection
            cmbSelectProducts.Focus();


            SetDefaultPaymentStatus();
            ResetCustomerTypeSelection();
        }



        // Class level variables
        private Bitmap _billImage;
        private bool _isPrinting = false;

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_billItems.Rows.Count == 0)
            {
                MessageBox.Show("No bill items to print");
                return;
            }

            // Create a bitmap of the bill content
            _billImage = CaptureBillContent();

            // Configure and show print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _isPrinting = true;
                printDocument1.Print();
            }
        }

        private Bitmap CaptureBillContent()
        {
            // Calculate the required height for the bill content
            int height = dvgProductsinBill.Height + 300; // Add space for header and totals

            // Create a bitmap to hold the bill image
            Bitmap bitmap = new Bitmap(this.Width, height);

            // Draw the bill content onto the bitmap
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);

                // Draw store header
                Font headerFont = new Font("Arial", 16, FontStyle.Bold);
                g.DrawString("Bismillah Sanitary Electric and Hardware Store", headerFont,
                            Brushes.Black, new PointF(50, 20));

                // Draw bill info
                Font infoFont = new Font("Arial", 10);
                g.DrawString($"Bill #: {txtBillNumber.Text}", infoFont, Brushes.Black, new PointF(50, 60));
                g.DrawString($"Date: {BillDate.Value.ToShortDateString()}", infoFont, Brushes.Black, new PointF(50, 80));

                if (rdregular.Checked && cmbCustomer.SelectedValue != null)
                {
                    g.DrawString($"Customer: {cmbCustomer.Text}", infoFont, Brushes.Black, new PointF(50, 100));
                }

                // Draw bill items header
                Font tableHeaderFont = new Font("Arial", 10, FontStyle.Bold);
                g.DrawString("Sr.No", tableHeaderFont, Brushes.Black, new PointF(50, 140));
                g.DrawString("Name", tableHeaderFont, Brushes.Black, new PointF(100, 140));
                g.DrawString("Qty", tableHeaderFont, Brushes.Black, new PointF(350, 140));
                g.DrawString("Price", tableHeaderFont, Brushes.Black, new PointF(400, 140));
                g.DrawString("Total", tableHeaderFont, Brushes.Black, new PointF(500, 140));

                // Draw bill items
                Font itemFont = new Font("Arial", 10);
                int yPos = 160;

                foreach (DataRow row in _billItems.Rows)
                {
                    g.DrawString(row["sr_no"].ToString(), itemFont, Brushes.Black, new PointF(50, yPos));
                    g.DrawString(row["name"].ToString(), itemFont, Brushes.Black, new PointF(100, yPos));
                    g.DrawString(row["quantity"].ToString(), itemFont, Brushes.Black, new PointF(350, yPos));
                    g.DrawString(row["unit_price_display"].ToString(), itemFont, Brushes.Black, new PointF(400, yPos));
                    g.DrawString(row["total_display"].ToString(), itemFont, Brushes.Black, new PointF(500, yPos));

                    yPos += 20;
                }

                // Draw totals
                Font totalFont = new Font("Arial", 10, FontStyle.Bold);
                g.DrawString("Subtotal:", totalFont, Brushes.Black, new PointF(400, yPos + 20));
                g.DrawString(lblSubtotal.Text, totalFont, Brushes.Black, new PointF(500, yPos + 20));

                if (_discountPercentage > 0)
                {
                    g.DrawString($"Discount ({_discountPercentage}%):", totalFont, Brushes.Black, new PointF(400, yPos + 40));
                    g.DrawString(DatabaseHelper.FormatAsPKR(_subtotal * (_discountPercentage / 100)),
                                totalFont, Brushes.Black, new PointF(500, yPos + 40));
                }

                g.DrawString("Total:", totalFont, Brushes.Black, new PointF(400, yPos + 60));
                g.DrawString(lblTotal.Text, totalFont, Brushes.Black, new PointF(500, yPos + 60));

                // Draw footer
                Font footerFont = new Font("Arial", 8);
                g.DrawString("Thank you for your business!", footerFont, Brushes.Black, new PointF(50, yPos + 100));
                g.DrawString($"Printed on: {DateTime.Now.ToString("g")}", footerFont, Brushes.Black, new PointF(50, yPos + 120));
            }

            return bitmap;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (_billImage != null)
            {
                // Draw the bill image on the printed page
                e.Graphics.DrawImage(_billImage, new Point(50, 50));
            }

            // No more pages to print
            e.HasMorePages = false;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // Clean up
            if (_billImage != null)
            {
                _billImage.Dispose();
                _billImage = null;
            }
            _isPrinting = false;
        }

       
    }
}