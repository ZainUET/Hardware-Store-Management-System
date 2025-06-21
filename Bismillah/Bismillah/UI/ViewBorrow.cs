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
    public partial class ViewBorrow : Form
    {
        public ViewBorrow()
        {
            InitializeComponent();

            
        }

        private void btnedit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvborrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a borrowed record to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dgvborrowed.SelectedRows[0];

            int borrowedId = Convert.ToInt32(row.Cells["borrowed_id"].Value);
            int customerId = Convert.ToInt32(row.Cells["customer_id"].Value);
            int productId = Convert.ToInt32(row.Cells["product_id"].Value);
            int batchId = Convert.ToInt32(row.Cells["batch_id"].Value);
            int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
            decimal unitPrice = Convert.ToDecimal(row.Cells["unit_price"].Value);
            bool isPaid = Convert.ToBoolean(row.Cells["is_paid"].Value);

            string newQtyStr = Prompt("Quantity:", quantity.ToString());
            string newPriceStr = Prompt("Unit Price:", unitPrice.ToString());

            if (!int.TryParse(newQtyStr, out int newQty) || newQty <= 0)
            {
                MessageBox.Show("Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(newPriceStr, out decimal newPrice) || newPrice <= 0)
            {
                MessageBox.Show("Unit Price must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Borrowed b = new Borrowed
            {
                BorrowedId = borrowedId,
                CustomerId = customerId,
                ProductId = productId,
                BatchId = batchId,
                Quantity = newQty,
                UnitPrice = newPrice,
                IsPaid = isPaid
            };

            string validation = BorrowedBL.ValidateBorrowed(b);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool updated = BorrowedDL.UpdateBorrowed(b);
            if (updated)
            {
                MessageBox.Show("Borrowed record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowedGrid();
            }
            else
            {
                MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void E_DBorrowUI_Load(object sender, EventArgs e)
        {
            LoadBorrowedGrid();
        }
        private void LoadBorrowedGrid()
        {
            DataTable dt = BorrowedDL.GetBorrowedList();
            dgvborrowed.DataSource = dt;
            dgvborrowed.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvborrowed.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvborrowed.Refresh();
        }

        private void btndelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvborrowed.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a borrowed record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int borrowedId = Convert.ToInt32(dgvborrowed.SelectedRows[0].Cells["borrowed_id"].Value);

            DialogResult result = MessageBox.Show("Are you sure to delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool deleted = BorrowedDL.DeleteBorrowed(borrowedId);
                if (deleted)
                {
                    MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrowedGrid();
                }
                else
                {
                    MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string Prompt(string title, string defaultValue)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(title, "Edit Borrowed", defaultValue);
        }

       
    }
}
