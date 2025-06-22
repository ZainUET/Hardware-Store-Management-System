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

namespace Bismillah.UI
{
    public partial class AddBorrowedUI : Form
    {
        private EventHandler btnBorrow_Click;

        public AddBorrowedUI()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Load customers
            cmbcustomers.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT customer_id, name FROM customer");
            cmbcustomers.DisplayMember = "name";
            cmbcustomers.ValueMember = "customer_id";

            // Load products
            comboBox2.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT product_id, name FROM products");
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "product_id";

            // Load payment statuses from lookup table
            cmbPaymentStatus.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT lookup_id, value FROM lookup WHERE category = 'Payment Status'");
            cmbPaymentStatus.DisplayMember = "value";
            cmbPaymentStatus.ValueMember = "lookup_id";

            dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList();
        }
        private void BorrowedUI_Load(object sender, EventArgs e)
        {
            dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbcustomers.SelectedValue.ToString(), out int customerId) ||
        !int.TryParse(comboBox2.SelectedValue.ToString(), out int productId) ||
        !decimal.TryParse(txtpoints.Text, out decimal unitPrice) ||
        !int.TryParse(txtaddress.Text, out int quantity) ||
        !int.TryParse(cmbPaymentStatus.SelectedValue.ToString(), out int paymentStatusId))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            string paymentStatusText = cmbPaymentStatus.Text.Trim();
            decimal total = unitPrice * quantity;

            // Check stock
            if (!BorrowedDL.IsStockAvailable(productId, quantity))
            {
                MessageBox.Show("Insufficient stock available.");
                return;
            }

            var borrowed = new Borrowed
            {
                CustomerId = customerId,
                ProductId = productId,
                Quantity = quantity,
                UnitPrice = unitPrice,
                PaymentStatusId = paymentStatusId
            };

            string validation = BorrowedBL.ValidateBorrowed(borrowed);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation);
                return;
            }

            bool success = BorrowedDL.AddBorrowed(borrowed);
            if (success)
            {
                // Insert into payments if Paid or Pending
                if (paymentStatusText == "Completed" || paymentStatusText == "Pending")
                {
                    // Get customer name
                    string custName = cmbcustomers.Text.Trim();
                    string method = paymentStatusText == "Completed" ? "Cash" : "Pending (Borrow)";

                    BorrowedDL.InsertPayment(customerId, total, method, custName);
                    BorrowedDL.ReduceProductStock(productId, quantity);
                   
                    
                }
                dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList();
                MessageBox.Show("Borrowed Successfully.");
 
            }
            else
            {
                MessageBox.Show("Failed to add.");
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            BorrowManagement b = new BorrowManagement();
            this.Hide();
            b.ShowDialog();
            this.Close();
        }
    }
}

