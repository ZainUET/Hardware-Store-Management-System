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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewBorrow_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAllBorrowed();

            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;
        }
        private void LoadCustomers()
        {
            cmbCustomers.DataSource = BorrowedDL.GetCustomerList();
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.ValueMember = "customer_id";
            cmbCustomers.SelectedIndex = -1; // start unselected
        }

        private void LoadAllBorrowed()
        {
            dgvBorrow.DataSource = BorrowedDL.GetAllBorrowedWithCustomerInfo();
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue != null && int.TryParse(cmbCustomers.SelectedValue.ToString(), out int customerId))
            {
                dgvBorrow.DataSource = BorrowedDL.GetBorrowedByCustomerId(customerId);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            BorrowManagement b = new BorrowManagement();
            this.Hide();
            b.ShowDialog();
            this.Close();
        }
    }
}
