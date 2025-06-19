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
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSupplierUI addStaff = new AddSupplierUI();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SupplierUI addStaff = new SupplierUI();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            AdminDashboard addStaff = new AdminDashboard();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
