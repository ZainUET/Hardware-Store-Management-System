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

            btnBack.Click += (s, e) => this.Close();
        }

        private void BorrowedUI_Load(object sender, EventArgs e)
        {
            cmbcustomers.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT customer_id, name FROM customer WHERE is_regular = 1");
            cmbcustomers.DisplayMember = "name";
            cmbcustomers.ValueMember = "customer_id";

            comboBox2.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT product_id, name FROM products");
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "product_id";

            comboBox3.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT batch_id FROM batch");
            comboBox3.DisplayMember = "batch_id";
            comboBox3.ValueMember = "batch_id";

            LoadBorrowedGrid();
        }
        private void LoadBorrowedGrid()
        {
            dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!int.TryParse(txtaddress.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtpoints.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for unit price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Borrowed b = new Borrowed
            {
                CustomerId = Convert.ToInt32(cmbcustomers.SelectedValue),
                ProductId = Convert.ToInt32(comboBox2.SelectedValue),
                BatchId = Convert.ToInt32(comboBox3.SelectedValue),
                Quantity = quantity,
                UnitPrice = unitPrice,
                IsPaid = chkIsPaid.Checked
            };

            string validation = BorrowedBL.ValidateBorrowed(b);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = BorrowedDL.AddBorrowed(b);
            if (success)
            {
                MessageBox.Show("Product borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowedGrid();
            }
            else
            {
                MessageBox.Show("Failed to borrow product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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

            btnBack.Click += (s, e) => this.Close();
        }

        private void BorrowedUI_Load(object sender, EventArgs e)
        {
            cmbcustomers.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT customer_id, name FROM customer WHERE is_regular = 1");
            cmbcustomers.DisplayMember = "name";
            cmbcustomers.ValueMember = "customer_id";

            comboBox2.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT product_id, name FROM products");
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "product_id";

            comboBox3.DataSource = DatabaseHelper.Instance.GetDataTable("SELECT batch_id FROM batch");
            comboBox3.DisplayMember = "batch_id";
            comboBox3.ValueMember = "batch_id";

            LoadBorrowedGrid();
        }
        private void LoadBorrowedGrid()
        {
            dgvBorrowed.DataSource = BorrowedDL.GetBorrowedList();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!int.TryParse(txtaddress.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtpoints.Text, out decimal unitPrice) || unitPrice <= 0)
            {
                MessageBox.Show("Please enter a valid positive number for unit price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Borrowed b = new Borrowed
            {
                CustomerId = Convert.ToInt32(cmbcustomers.SelectedValue),
                ProductId = Convert.ToInt32(comboBox2.SelectedValue),
                BatchId = Convert.ToInt32(comboBox3.SelectedValue),
                Quantity = quantity,
                UnitPrice = unitPrice,
                IsPaid = chkIsPaid.Checked
            };

            string validation = BorrowedBL.ValidateBorrowed(b);
            if (!string.IsNullOrEmpty(validation))
            {
                MessageBox.Show(validation, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = BorrowedDL.AddBorrowed(b);
            if (success)
            {
                MessageBox.Show("Product borrowed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowedGrid();
            }
            else
            {
                MessageBox.Show("Failed to borrow product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}