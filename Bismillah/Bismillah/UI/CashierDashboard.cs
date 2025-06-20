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
    }
}

