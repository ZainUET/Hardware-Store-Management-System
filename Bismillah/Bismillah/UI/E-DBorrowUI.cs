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

            // Get borrowed data
            DataTable dt = BorrowedDL.GetBorrowedById(borrowedId);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Borrowed record not found.");
                return;
            }

            DataRow row = dt.Rows[0];
            Borrowed b = new Borrowed
            {
                BorrowedId = borrowedId,
                CustomerId = Convert.ToInt32(row["customer_id"]),
                ProductId = Convert.ToInt32(row["product_id"]),
                Quantity = Convert.ToInt32(row["quantity"]),
                UnitPrice = Convert.ToDecimal(row["unit_price"]),
                IsPaid = Convert.ToBoolean(row["is_paid"]),
            };

            // Prompt user for updated values
            string newQtyStr = Prompt("Quantity:", b.Quantity.ToString());
            string newPriceStr = Prompt("Unit Price:", b.UnitPrice.ToString());
            DialogResult paidResult = MessageBox.Show("Is the item paid?", "Payment Status", MessageBoxButtons.YesNo);

            b.Quantity = int.TryParse(newQtyStr, out int q) ? q : b.Quantity;
            b.UnitPrice = decimal.TryParse(newPriceStr, out decimal p) ? p : b.UnitPrice;
            b.IsPaid = (paidResult == DialogResult.Yes);
           

            // Validate
            string validation = BorrowedBL.ValidateBorrowed(b);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update
            if (BorrowedDL.UpdateBorrowed(b))
            {
                MessageBox.Show("Record updated successfully.");
                cmbCustomer_SelectedIndexChanged(null, null); // Refresh grid
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
    }
}