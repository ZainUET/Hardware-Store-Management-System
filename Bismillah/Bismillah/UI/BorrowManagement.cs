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
    public partial class BorrowManagement : Form
    {
        public BorrowManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBorrowedUI addStaff = new AddBorrowedUI();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            E_DBorrowUI addStaff = new E_DBorrowUI();
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
    }
}
