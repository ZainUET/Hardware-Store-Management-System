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
    public partial class CashierDashboard : Form
    {
        // CashierDashboard.cs
        private readonly int _staffId;

        // Constructor now accepts staff ID
        public CashierDashboard(int staffId)
        {
            InitializeComponent();
            _staffId = staffId;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            // Pass the staff ID to CreateBill
            CreateBill billForm = new CreateBill(_staffId);
            this.Hide();
            billForm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login billForm = new Login();
            this.Hide();
            billForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerManagement billForm = new CustomerManagement();
            this.Hide();
            billForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewProduct v = new ViewProduct(2);
            this.Hide();
            v.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Returns r = new Returns();
            this.Hide();
            r.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowManagement borrowManagement = new BorrowManagement();
            this.Hide();
            borrowManagement.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewPayments v = new ViewPayments();
            this.Hide();
            v.ShowDialog();
            this.Close();
        }
    }
}


