using Bismillah.BL;
using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bismillah.UI
{
    public partial class E_DBorrowUI : Form
    {
        public E_DBorrowUI()
        {
            InitializeComponent();

            btnback.LinkClicked += (s, e) => this.Close();

        }

        private void btnedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvborrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            DataGridViewRow selectedRow = dgvborrowed.SelectedRows[0];
            int borrowedId = Convert.ToInt32(selectedRow.Cells["borrowed_id"].Value);

            DataTable dt = BorrowedDL.GetBorrowedById(borrowedId);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Borrowed record not found.");
                return;
            }

            DataRow row = dt.Rows[0];
            int originalQty = Convert.ToInt32(row["quantity"]);
            bool alreadyReduced = Convert.ToBoolean(row["stock_reduced"]);

            Borrowed b = new Borrowed
            {
                BorrowedId = borrowedId,
                CustomerId = Convert.ToInt32(row["customer_id"]),
                ProductId = Convert.ToInt32(row["product_id"]),
                Quantity = originalQty,
                UnitPrice = Convert.ToDecimal(row["unit_price"]),
                PaymentStatusId = Convert.ToInt32(row["payment_status_id"])
            };

            string oldStatus = BorrowedDL.GetLookupValueById(b.PaymentStatusId);

            // Prompt for new quantity
            string newQtyStr = Prompt("Quantity:", b.Quantity.ToString());
            int newQty = int.TryParse(newQtyStr, out int q) ? q : b.Quantity;

            // Prompt for new status
            DataTable statusTable = DatabaseHelper.Instance.GetDataTable("SELECT lookup_id, value FROM lookup WHERE category = 'Payment Status'");
            string selectedStatus = Microsoft.VisualBasic.Interaction.InputBox("Enter payment status (Pending, Completed, Failed):", "Edit Status", oldStatus);
            DataRow selectedStatusRow = statusTable.AsEnumerable().FirstOrDefault(r => r["value"].ToString().Equals(selectedStatus, StringComparison.OrdinalIgnoreCase));
            if (selectedStatusRow == null)
            {
                MessageBox.Show("Invalid status entered.");
                return;
            }

            b.Quantity = newQty;
            b.PaymentStatusId = Convert.ToInt32(selectedStatusRow["lookup_id"]);

            string validation = BorrowedBL.ValidateBorrowed(b);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = selectedStatus;
            decimal total = b.Quantity * b.UnitPrice;

            // Stock Handling Logic
            if ((newStatus == "Completed" || newStatus == "Pending"))
            {
                if (alreadyReduced)
                {
                    if (b.Quantity < originalQty)
                    {
                        int diff = originalQty - b.Quantity;
                        BorrowedDL.IncreaseProductStock(b.ProductId, diff);
                    }
                    else if (b.Quantity > originalQty)
                    {
                        int diff = b.Quantity - originalQty;
                        if (BorrowedDL.IsStockAvailable(b.ProductId, diff))
                        {
                            BorrowedDL.ReduceProductStock(b.ProductId, diff);
                        }
                        else
                        {
                            MessageBox.Show("Not enough stock to increase quantity.");
                            return;
                        }
                    }
                }
                else
                {
                    if (BorrowedDL.IsStockAvailable(b.ProductId, b.Quantity))
                    {
                        BorrowedDL.ReduceProductStock(b.ProductId, b.Quantity);
                        DatabaseHelper.Instance.Update($"UPDATE borrowed SET stock_reduced = TRUE WHERE borrowed_id = {b.BorrowedId}");
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock available.");
                        return;
                    }
                }

                // ✅ Final Payment Logic
                string method = newStatus == "Completed" ? "Completed" : "Pending (Borrow)";

                if (oldStatus == newStatus)
                {
                    BorrowedDL.UpdatePayment(b.CustomerId, total, method);
                }
                else if (oldStatus == "Pending" && newStatus == "Completed")
                {
                    // Just upgrade the payment from Pending → Completed
                    BorrowedDL.UpdatePayment(b.CustomerId, total, method);
                }
                else
                {
                    // All other transitions (like Failed → Completed)
                    BorrowedDL.InsertPayment(b.CustomerId, total, method, "");
                }
            }

            // Final update
            if (BorrowedDL.UpdateBorrowed(b))
            {
                MessageBox.Show("Record updated successfully.");
                cmbCustomer_SelectedIndexChanged(null, null);
            }
            else
            {
                MessageBox.Show("Failed to update.");
            }
        }


        private void E_DBorrowUI_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }
        private void LoadCustomers()
        {
            cmbCustomer.DataSource = BorrowedDL.GetCustomerList();
            cmbCustomer.DisplayMember = "name";
            cmbCustomer.ValueMember = "customer_id";
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
        }

        private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvborrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this borrowed record?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int borrowedId = Convert.ToInt32(dgvborrowed.SelectedRows[0].Cells["borrowed_id"].Value);
                if (BorrowedDL.DeleteBorrowed(borrowedId))
                {
                    MessageBox.Show("Record deleted.");
                    cmbCustomer_SelectedIndexChanged(null, null); // Refresh grid
                }
            }
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue != null && int.TryParse(cmbCustomer.SelectedValue.ToString(), out int customerId))
            {
                dgvborrowed.DataSource = BorrowedDL.GetBorrowedListByCustomer(customerId);
            }
        }
        private string Prompt(string title, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, "Edit Borrowed", defaultValue);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BorrowManagement b = new BorrowManagement();
            this.Hide();
            b.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}