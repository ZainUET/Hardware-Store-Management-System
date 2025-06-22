using Bismillah.DL;
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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            StaffManagement addStaff = new StaffManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SupplierManagement addStaff = new SupplierManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductManagement addStaff = new ProductManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerManagement addStaff = new CustomerManagement();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login addStaff = new Login();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports addStaff = new Reports();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            PurchaseOrder addStaff = new PurchaseOrder();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();

        }
    }
}
