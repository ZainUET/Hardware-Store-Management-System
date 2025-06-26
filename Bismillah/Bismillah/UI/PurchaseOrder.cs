using Bismillah.BL;
using Bismillah.DL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Windows.Forms;


namespace Bismillah.UI
{
    public partial class PurchaseOrder : Form
    {
        private readonly PurchaseOrderBL purchaseOrderBL;
        private DataTable orderItems;


        public PurchaseOrder()
        {
            InitializeComponent();
            purchaseOrderBL = new PurchaseOrderBL();
            InitializeOrderItemsTable();
            LoadSuppliers();
            LoadProducts();
           


            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeOrderItemsTable()
        {
            orderItems = new DataTable();
            orderItems.Columns.Add("product_id", typeof(int));
            orderItems.Columns.Add("product_name", typeof(string));
            orderItems.Columns.Add("quantity", typeof(int));
            orderItems.Columns.Add("unit_price", typeof(decimal));
            orderItems.Columns.Add("total", typeof(decimal));
        }

        private void LoadSuppliers()
        {
            cmbSuppliers.DataSource = purchaseOrderBL.LoadSuppliers();
            cmbSuppliers.DisplayMember = "name";
            cmbSuppliers.ValueMember = "supplier_id";
        }

        private void LoadProducts()
        {
            cmbProducts.DataSource = purchaseOrderBL.LoadProducts();
            cmbProducts.DisplayMember = "name";
            cmbProducts.ValueMember = "product_id";
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSuppliers.SelectedValue != null && int.TryParse(cmbSuppliers.SelectedValue.ToString(), out int supplierId))
            {
                txtSupplierContact.Text = purchaseOrderBL.GetSupplierContact(supplierId);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {



            if (cmbProducts.SelectedItem == null || nudQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a product and enter quantity.");
                return;
            }

            var selected = cmbProducts.SelectedItem as DataRowView;
            int productId = Convert.ToInt32(selected["product_id"]);
            string productName = selected["name"].ToString();
            decimal unitPrice = Convert.ToDecimal(selected["unit_price"]);
            int quantity = (int)nudQuantity.Value;
            decimal total = quantity * unitPrice;

            // Add to orderItems DataTable
            orderItems.Rows.Add(productId, productName, quantity, unitPrice, total);

            // Refresh GridView
            dgvOrderItems.DataSource = orderItems;

            CalculateTotals();

            // Reset inputs (optional)
            cmbProducts.SelectedIndex = -1;
            nudQuantity.Value = 1;
        }

        private void CalculateTotals()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvOrderItems.Rows)
            {
                if (row.IsNewRow) continue;

                decimal rowTotal = Convert.ToDecimal(row.Cells[4].Value); // Assuming 5th column is Total
                subtotal += rowTotal;
            }

            txtSubtotal.Text = subtotal.ToString("0.00");
            txtTotal.Text = subtotal.ToString("0.00"); // If no tax/discount, same as subtotal
        }


        private void UpdateOrderSummary()
        {
            decimal subtotal = purchaseOrderBL.CalculateOrderTotal(orderItems);
            //decimal tax = subtotal * 0.15m; // Assuming 15% tax
            //decimal total = subtotal + tax;
            decimal total = subtotal;

            txtSubtotal.Text = subtotal.ToString("N2");
            //txtTax.Text = tax.ToString("N2");
            txtTotal.Text = total.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (orderItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one product to save the order.");
                return;
            }

            try
            {
                int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);

                bool saved = purchaseOrderBL.ProcessPurchaseOrder(supplierId, orderItems, "");

                if (saved)
                {
                    MessageBox.Show("Purchase order saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset form
                    InitializeOrderItemsTable();
                    dgvOrderItems.DataSource = orderItems;
                    cmbProducts.SelectedIndex = -1;
                    nudQuantity.Value = 1;
                    txtSubtotal.Text = "0.00";
                    txtTotal.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeOrderItemsTable();
            dgvOrderItems.DataSource = orderItems;
            UpdateOrderSummary();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            AdminDashboard a = new AdminDashboard();
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void dgvOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvOrderItems.Columns["colRemove"].Index)
            {
                orderItems.Rows.RemoveAt(e.RowIndex);
                dgvOrderItems.DataSource = orderItems;
                UpdateOrderSummary();
            }
        }
        private void GeneratePurchaseOrderPDF(string filePath)
        {
            Document doc = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Fonts
            var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16f);
            var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f, BaseColor.WHITE);
            var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 9f);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10f);

            // Title
            var title = new Paragraph("Purchase Order", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 10f
            };
            doc.Add(title);

            // Supplier Info
            string supplier = cmbSuppliers.Text;
            string contact = txtSupplierContact.Text;
            var info = new Paragraph($"Supplier: {supplier}\nContact: {contact}\nDate: {DateTime.Now:dd-MM-yyyy HH:mm}", cellFont)
            {
                SpacingAfter = 10f
            };
            doc.Add(info);

            // Product Table
            PdfPTable table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 3f, 2f, 2f, 2f });

            string[] headers = { "Product Name", "Quantity", "Unit Price", "Total" };
            foreach (string col in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col, headerFont))
                {
                    BackgroundColor = new BaseColor(10, 35, 66),
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Padding = 5
                };
                table.AddCell(cell);
            }

            // Data rows from DataGridView (display product name, not ID!)
            foreach (DataGridViewRow row in dgvOrderItems.Rows)
            {
                if (row.IsNewRow) continue;

                table.AddCell(new Phrase(row.Cells["product_name"].Value?.ToString(), cellFont));
                table.AddCell(new Phrase(row.Cells["quantity"].Value?.ToString(), cellFont));
                table.AddCell(new Phrase(row.Cells["unit_price"].Value?.ToString(), cellFont));
                table.AddCell(new Phrase(row.Cells["total"].Value?.ToString(), cellFont));
            }

            doc.Add(table);

            // Final Total at bottom
            Paragraph totalAmount = new Paragraph($"\nGrand Total: Rs. {txtTotal.Text}", boldFont)
            {
                Alignment = Element.ALIGN_RIGHT,
                SpacingBefore = 20f
            };
            doc.Add(totalAmount);

            doc.Close();
        }



        private void btnPrint_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Title = "Save Purchase Order PDF",
                FileName = $"PurchaseOrder_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    GeneratePurchaseOrderPDF(saveFile.FileName);
                    MessageBox.Show("Purchase Order exported as PDF successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
