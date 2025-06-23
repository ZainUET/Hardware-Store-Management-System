using Bismillah.BL;
using Bismillah.DL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PDF_Font = iTextSharp.text.Font;
using GDI_Font = System.Drawing.Font;
using GDI_Rectangle = System.Drawing.Rectangle;
using PDF_Rectangle = iTextSharp.text.Rectangle;


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
        private GDI_Font billFont = new GDI_Font("Consolas", 10);
        private string? billContent;

        public CreateBill(int staffId)
        {
            InitializeComponent();
            _currentStaffId = staffId;
            _billBL = new CreateBillBL();

            printDocument.PrintPage += printDocument1_PrintPage;

            InitializeData();
        }
        private void GenerateBillPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Title
            PDF_Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f, BaseColor.BLACK);
            Paragraph title = new Paragraph("Bismillah Sanitary Electric and Hardware Store", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 10f
            };
            doc.Add(title);

            // Customer Info
            PDF_Font infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f);
            PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100 };

            string customerName = rdregular.Checked && cmbCustomer.SelectedItem != null
                ? ((DataRowView)cmbCustomer.SelectedItem)["name"].ToString()
                : nametxt.Text.Trim();

            string customerContact = rdregular.Checked && cmbCustomer.SelectedItem != null
                ? ((DataRowView)cmbCustomer.SelectedItem)["contact"].ToString()
                : contacttxt.Text.Trim();

            PdfPCell leftInfo = new PdfPCell(new Phrase($"Customer: {customerName}\nContact: {customerContact}", infoFont))
            {
                Border = PDF_Rectangle.NO_BORDER
            };

            string paymentStatusText = ((DataRowView)cmbPaymentStatus.SelectedItem)["value"].ToString();
            PdfPCell rightInfo = new PdfPCell(new Phrase(
                $"Date: {DateTime.Now:dd-MM-yyyy HH:mm}\nPayment Status: {paymentStatusText}", infoFont))
            {
                Border = PDF_Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT
            };

           

            infoTable.AddCell(leftInfo);
            infoTable.AddCell(rightInfo);
            doc.Add(infoTable);

            // Product Table
            PdfPTable billTable = new PdfPTable(5)
            {
                WidthPercentage = 100,
                SpacingBefore = 10f
            };
            billTable.SetWidths(new float[] { 1.5f, 4f, 2f, 3f, 3f });

            PDF_Font headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);
            BaseColor headerBg = new BaseColor(10, 35, 66);
            PDF_Font cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 9f);

            string[] headers = { "Sr", "Product", "Qty", "Unit Price", "Total" };
            foreach (string col in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col, headerFont))
                {
                    BackgroundColor = headerBg,
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Padding = 5
                };
                billTable.AddCell(cell);
            }

            foreach (DataRow row in _billItems.Rows)
            {
                billTable.AddCell(new PdfPCell(new Phrase(row["sr_no"].ToString(), cellFont)));
                billTable.AddCell(new PdfPCell(new Phrase(row["name"].ToString(), cellFont)));
                billTable.AddCell(new PdfPCell(new Phrase(row["quantity"].ToString(), cellFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                billTable.AddCell(new PdfPCell(new Phrase(row["unit_price_display"].ToString(), cellFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                billTable.AddCell(new PdfPCell(new Phrase(row["total_display"].ToString(), cellFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
            }
            doc.Add(billTable);

            // Totals
            decimal totalAmount = _subtotal - (_subtotal * (_discountPercentage / 100m));
            PdfPTable totalsTable = new PdfPTable(2)
            {
                WidthPercentage = 40,
                HorizontalAlignment = Element.ALIGN_RIGHT,
                SpacingBefore = 10f
            };
            PDF_Font boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f);

            void AddTotalRow(string label, string value)
            {
                totalsTable.AddCell(new PdfPCell(new Phrase(label, boldFont)) { Border = PDF_Rectangle.NO_BORDER });
                totalsTable.AddCell(new PdfPCell(new Phrase(value, boldFont)) { Border = PDF_Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
            }

            AddTotalRow("Subtotal:", DatabaseHelper.FormatAsPKR(_subtotal));
            AddTotalRow("Discount:", $"{_discountPercentage}%");
            AddTotalRow("Total:", DatabaseHelper.FormatAsPKR(totalAmount));
            doc.Add(totalsTable);

            // Thank you note
            Paragraph footer = new Paragraph("Thank you for shopping with us!", infoFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingBefore = 30f
            };
            doc.Add(footer);
            doc.Close();
        }


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
            string query;
            if (rdWalkin.Checked)
            {
                query = @"SELECT lookup_id, value 
                  FROM lookup 
                  WHERE category = 'Payment Status' AND value IN ('Completed', 'Failed')";
            }
            else
            {
                query = @"SELECT lookup_id, value 
                  FROM lookup 
                  WHERE category = 'Payment Status'";
            }

            cmbPaymentStatus.DataSource = DatabaseHelper.Instance.GetDataTable(query);
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
                string customerName = rdregular.Checked
                    ? ((DataRowView)cmbCustomer.SelectedItem)["name"].ToString()
                    : nametxt.Text.Trim();

                decimal total = _subtotal - (_subtotal * (_discountPercentage / 100));

                // Save walk-in bill record if needed
                if (rdWalkin.Checked)
                {
                    string insert = $@"
        INSERT INTO walkin_bills (name, contact, total_amount)
        VALUES ('{customerName}', '{contacttxt.Text.Trim()}', {total})";

                    DatabaseHelper.Instance.Update(insert);
                }

                // Save bill quotation
                int billId = _billBL.ProcessBill(
                    customerId,
                    _currentStaffId,
                    _subtotal * (_discountPercentage / 100),
                    _billItems,
                    paymentStatusId,
                    out string formattedTotal
                );
                string paymentStatus = ((DataRowView)cmbPaymentStatus.SelectedItem)["value"].ToString();

                // Insert into payments if payment is Completed
                if (paymentStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase) && rdregular.Checked && customerId.HasValue)
                {
                    foreach (DataRow row in _billItems.Rows)
                    {
                        int productId = Convert.ToInt32(row["product_id"]);
                        int quantity = Convert.ToInt32(row["quantity"]);
                        decimal unitPrice = Convert.ToDecimal(row["unit_price"]);
                        decimal totalAmount = quantity * unitPrice;

                        string insertBorrowQuery = $@"
INSERT INTO borrowed 
(customer_id, product_id, quantity, unit_price, total_amount, payment_status_id, date_borrowed, stock_reduced)
VALUES 
({customerId.Value}, {productId}, {quantity}, {unitPrice}, {totalAmount}, {paymentStatusId}, NOW(), 1)";

                        DatabaseHelper.Instance.Update(insertBorrowQuery);
                    }
                }

                if (paymentStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase))
                {
                    string paymentQuery = $@"
        INSERT INTO payments (customer_id, customer_name, amount_paid, payment_method)
        VALUES (
            {(customerId.HasValue ? customerId.ToString() : "NULL")},
            '{customerName}',
            {total},
            'Cash'
        )";
                    DatabaseHelper.Instance.Update(paymentQuery);
                }

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

            LoadPaymentStatuses(); // reload statuses
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

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save Bill PDF",
                FileName = $"Bill_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerateBillPDF(saveFile.FileName);
                    MessageBox.Show("Bill exported as PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void grpRegularCustomer_Enter(object sender, EventArgs e)
        {

        }

        private void rdWalkin_CheckedChanged(object sender, EventArgs e)
        {

            grpcustomers.Visible = rdWalkin.Checked;
            grpRegularCustomer.Visible = !rdWalkin.Checked;

            LoadPaymentStatuses(); // Reload allowed statuses
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pass the current staff ID when creating the CashierDashboard
            CashierDashboard c = new CashierDashboard(_currentStaffId);
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void contacttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contacttxt_Leave(object sender, EventArgs e)
        {
            if (contacttxt.Text.Length != 11)
            {
                MessageBox.Show("Contact number must be exactly 11 digits.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contacttxt.Focus();
            }
        }
    }
}