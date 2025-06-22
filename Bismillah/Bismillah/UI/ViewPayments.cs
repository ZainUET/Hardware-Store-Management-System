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
    public partial class ViewPayments : Form
    {
        public ViewPayments()
        {
            InitializeComponent();
            Load += ViewPayments_Load;
            cmbCustomers.SelectedIndexChanged += cmbCustomers_SelectedIndexChanged;

        }

        private void ViewPayments_Load(object sender, EventArgs e)
        {
            LoadCustomerComboBox();
            LoadAllPayments();
        }
        private void LoadCustomerComboBox()
        {
            DataTable dt = PaymentDL.GetCustomerListForPayments();
            DataRow allRow = dt.NewRow();
            allRow["customer_id"] = -1;
            allRow["name"] = "All Customers";
            dt.Rows.InsertAt(allRow, 0);

            cmbCustomers.DataSource = dt;
            cmbCustomers.DisplayMember = "name";
            cmbCustomers.ValueMember = "customer_id";
        }

        private void LoadAllPayments()
        {
            dgvPayments.DataSource = PaymentDL.GetAllPayments();
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue != null && int.TryParse(cmbCustomers.SelectedValue.ToString(), out int customerId))
            {
                if (customerId == -1)
                {
                    LoadAllPayments();
                }
                else
                {
                    dgvPayments.DataSource = PaymentDL.GetPaymentsByCustomerId(customerId);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            CashierDashboard c = new CashierDashboard(2);
            this.Hide();
            c.Show(); 
            this.Close();
        }
    }
}
