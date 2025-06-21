using Bismillah.BL;
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
            if (cmbProducts.SelectedValue == null || nudQuantity.Value <= 0)
            {
                MessageBox.Show("Please select a product and enter valid quantity");
                return;
            }

            DataRowView selectedProduct = (DataRowView)cmbProducts.SelectedItem;
            decimal unitPrice = Convert.ToDecimal(selectedProduct["unit_price"]);
            int quantity = (int)nudQuantity.Value;

            DataRow newRow = orderItems.NewRow();
            newRow["product_id"] = selectedProduct["product_id"];
            newRow["product_name"] = selectedProduct["name"];
            newRow["quantity"] = quantity;
            newRow["unit_price"] = unitPrice;
            newRow["total"] = quantity * unitPrice;
            orderItems.Rows.Add(newRow);

            dgvOrderItems.DataSource = orderItems;
            UpdateOrderSummary();
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
                MessageBox.Show("Please add items to the order");
                return;
            }

            try
            {
                int supplierId = Convert.ToInt32(cmbSuppliers.SelectedValue);
                if (purchaseOrderBL.ProcessPurchaseOrder(supplierId, orderItems, ""))
                {
                    MessageBox.Show("Purchase order saved successfully");
                    InitializeOrderItemsTable();
                    dgvOrderItems.DataSource = orderItems;
                    UpdateOrderSummary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving purchase order: {ex.Message}");
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

        
    }
}