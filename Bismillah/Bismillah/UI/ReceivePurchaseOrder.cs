using Bismillah.BL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bismillah.UI
{
    public partial class ReceivePurchaseOrder : Form
    {
        private readonly ReceivePurchaseOrderBL _receivePurchaseOrderBL;
        private int _currentOrderId;

        public ReceivePurchaseOrder(int orderId)
        {
            InitializeComponent();
            _receivePurchaseOrderBL = new ReceivePurchaseOrderBL();
            _currentOrderId = orderId;
            LoadPurchaseOrderDetails();
        }

        private void LoadPurchaseOrderDetails()
        {
            try
            {
                DataTable dt = _receivePurchaseOrderBL.LoadPurchaseOrderDetails(_currentOrderId);
                dgvReceivePurchaseOrder.DataSource = dt;

                // Configure DataGridView columns
                if (dgvReceivePurchaseOrder.Columns.Count > 0)
                {
                    dgvReceivePurchaseOrder.Columns["order_detail_id"].Visible = false;
                    dgvReceivePurchaseOrder.Columns["product_id"].Visible = false;
                    dgvReceivePurchaseOrder.Columns["product_name"].HeaderText = "Product Name";
                    dgvReceivePurchaseOrder.Columns["ordered_quantity"].HeaderText = "Ordered Qty";
                    dgvReceivePurchaseOrder.Columns["received_quantity"].HeaderText = "Received Qty";
                    dgvReceivePurchaseOrder.Columns["unit_price"].HeaderText = "Unit Price";
                    dgvReceivePurchaseOrder.Columns["total_price"].HeaderText = "Total Price";
                    dgvReceivePurchaseOrder.Columns["remaining_quantity"].HeaderText = "Remaining Qty";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading purchase order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReceivePurchaseOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReceivePurchaseOrder.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvReceivePurchaseOrder.SelectedRows[0];
                int remainingQty = Convert.ToInt32(row.Cells["remaining_quantity"].Value);
                numericUpDownReceivedQuantity.Value = remainingQty;
                numericUpDownReceivedQuantity.Maximum = remainingQty;
            }
        }

        private void btnSaveReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceivePurchaseOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to update.", "Information",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 1. Update the received quantity
                DataGridViewRow row = dgvReceivePurchaseOrder.SelectedRows[0];
                int orderDetailId = Convert.ToInt32(row.Cells["order_detail_id"].Value);
                int receivedQty = Convert.ToInt32(numericUpDownReceivedQuantity.Value);

                bool updateSuccess = _receivePurchaseOrderBL.UpdateItemReceivedQuantity(orderDetailId, receivedQty);

                if (!updateSuccess)
                {
                    MessageBox.Show("Failed to update received quantity.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Check if all items are received
                bool allReceived = _receivePurchaseOrderBL.CheckIfOrderFullyReceived(_currentOrderId);

                if (allReceived)
                {
                    // 3. Update order status
                    bool statusUpdated = _receivePurchaseOrderBL.CompletePurchaseOrder(_currentOrderId);

                    if (statusUpdated)
                    {
                        MessageBox.Show("All items received and order status updated to Completed!",
                                       "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("All items received but failed to update order status!",
                                       "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Received quantity updated successfully.",
                                   "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 4. Refresh the grid
                LoadPurchaseOrderDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving receipt: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAllReceived_Click(object sender, EventArgs e)
        {
 
            try
            {
                bool success = _receivePurchaseOrderBL.ReceiveAllItems(_currentOrderId);
                if (success)
                {
                    // ✅ Mark order as complete
                    _receivePurchaseOrderBL.MarkOrderAsComplete(_currentOrderId);

                    MessageBox.Show("All items marked as received and order completed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPurchaseOrderDetails();
                }
                else
                {
                    MessageBox.Show("Failed to mark all items as received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error marking all items as received: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkBoxproductfullyreceived_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxproductfullyreceived.Checked)
            {
                btnAllReceived_Click(sender, e);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Just close the form, let the calling form handle refresh
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}