using Bismillah.BL;
using Bismillah.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
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
            lblrefund.Text = $"Total Refund: Rs. {returnsBL.CalculateRefund(returnItems):N2}";

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
            CashierDashboard c = new CashierDashboard(2);
            this.Hide();
            c.ShowDialog();
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
        private void GenerateReturnPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Title
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18f, BaseColor.BLACK);
            var title = new Paragraph("Return Receipt - Bismillah Store", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 10f
            };
            doc.Add(title);

            // Customer Info
            var infoFont = FontFactory.GetFont(FontFactory.HELVETICA, 10f);
            var customerName = ((DataRowView)cmbCustomer.SelectedItem)["name"].ToString();
            var customerContact = ((DataRowView)cmbCustomer.SelectedItem)["contact"].ToString();

            PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100 };
            PdfPCell left = new PdfPCell(new Phrase($"Customer: {customerName}\nContact: {customerContact}", infoFont))
            {
                Border = iTextSharp.text.Rectangle.NO_BORDER

            };
            PdfPCell right = new PdfPCell(new Phrase($"Return Date: {DateTime.Now:dd-MM-yyyy HH:mm}", infoFont))
            {
                Border =iTextSharp.text.Rectangle.NO_BORDER,
                HorizontalAlignment = Element.ALIGN_RIGHT
            };
            infoTable.AddCell(left);
            infoTable.AddCell(right);
            doc.Add(infoTable);

            // Return Table
            PdfPTable table = new PdfPTable(5) { WidthPercentage = 100, SpacingBefore = 10f };
            table.SetWidths(new float[] { 1f, 3f, 2f, 2f, 2f });

            var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);
            var headerBg = new BaseColor(10, 35, 66);
            var bodyFont = FontFactory.GetFont(FontFactory.HELVETICA, 9f);

            string[] headers = { "Sr", "Product", "Qty", "Unit Price", "Total" };
            foreach (var h in headers)
            {
                var cell = new PdfPCell(new Phrase(h, headerFont))
                {
                    BackgroundColor = headerBg,
                    Padding = 5,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                table.AddCell(cell);
            }

            int sr = 1;
            decimal grandTotal = 0;
            foreach (DataRow row in returnItems.Rows)
            {
                decimal unitPrice = Convert.ToDecimal(row["unit_price"]);
                int qty = Convert.ToInt32(row["quantity"]);
                decimal total = unitPrice * qty;
                grandTotal += total;

                table.AddCell(new PdfPCell(new Phrase(sr++.ToString(), bodyFont)));
                table.AddCell(new PdfPCell(new Phrase(row["product_name"].ToString(), bodyFont)));
                table.AddCell(new PdfPCell(new Phrase(qty.ToString(), bodyFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase("Rs. " + unitPrice.ToString("0.00"), bodyFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase("Rs. " + total.ToString("0.00"), bodyFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
            }
            doc.Add(table);

            // Total Refund
            PdfPTable totals = new PdfPTable(2) { WidthPercentage = 40, HorizontalAlignment = Element.ALIGN_RIGHT, SpacingBefore = 10f };
            totals.AddCell(new PdfPCell(new Phrase("Total Refund:", headerFont)) { Border = 0 });
            totals.AddCell(new PdfPCell(new Phrase("Rs. " + grandTotal.ToString("0.00"), headerFont)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });
            doc.Add(totals);

            doc.Add(new Paragraph("Thank you! Return processed.", infoFont) { SpacingBefore = 20f, Alignment = Element.ALIGN_CENTER });
            doc.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
         
            if (returnItems.Rows.Count == 0)
            {
                MessageBox.Show("No return items to print.");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save Return Receipt",
                FileName = $"Return_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GenerateReturnPDF(saveFile.FileName);
                    MessageBox.Show("Return receipt saved as PDF successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message);
                }
            }
        }

    }
}
