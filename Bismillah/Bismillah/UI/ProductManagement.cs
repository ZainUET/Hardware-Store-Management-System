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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductsUI addStaff = new AddProductsUI();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            ProductUI addStaff = new ProductUI();
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

        private void button4_Click(object sender, EventArgs e)
        {
            ViewProduct addStaff = new ViewProduct(1);
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
