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
    public partial class StaffManagement : Form
    {
        public StaffManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            this.Hide();
            addStaff.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StaffUI addStaff = new StaffUI();
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
