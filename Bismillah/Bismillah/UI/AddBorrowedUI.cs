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
            cmbcustomers.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT customer_id, name FROM customer");
            cmbcustomers.DisplayMember = "name";
            cmbcustomers.ValueMember = "customer_id";

            comboBox2.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT product_id, name FROM products");
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "product_id";

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
               !int.TryParse(txtaddress.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid data.");
                return;
            }

            decimal total = unitPrice * quantity;
            bool isPaid = chkIsPaid.Checked;

            var borrowed = new Borrowed
            {
                CustomerId = Convert.ToInt32(cmbcustomers.SelectedValue),
                ProductId = Convert.ToInt32(comboBox2.SelectedValue),
                Quantity = int.Parse(txtaddress.Text),
                UnitPrice = decimal.Parse(txtpoints.Text),
                IsPaid = chkIsPaid.Checked
            };

            // borrowed.TotalAmount will be automatically calculated
            string validation = BorrowedBL.ValidateBorrowed(borrowed);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation);
                return;
            }

            bool success = BorrowedDL.AddBorrowed(borrowed);
            if (success)
            {
                MessageBox.Show("Borrowed product added successfully!");
                dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList(); // refresh grid
            }
            else
            {
                MessageBox.Show("Failed to add.");
            }
        }
        private void ClearForm()
        {
            cmbcustomers.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            txtpoints.Clear();
            txtaddress.Clear();
            chkIsPaid.Checked = false;
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

