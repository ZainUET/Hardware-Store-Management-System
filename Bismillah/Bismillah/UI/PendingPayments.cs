//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Bismillah.BL;
//using Bismillah.DL;

//namespace Bismillah.UI
//{
//    public partial class PaymentManager : Form
//    {
//        private readonly CreateBillBL _billBL;

//        public PaymentManager()
//        {
//            InitializeComponent();
//            _billBL = new CreateBillBL();
//            LoadPendingPayments();
//        }

//        private void LoadPendingPayments()
//        {
//            string query = @"SELECT b.bill_id, b.bill_date, c.name AS customer_name, b.total_amount
//                       FROM bill_quotation b
//                       LEFT JOIN customer c ON b.customer_id = c.customer_id
//                       JOIN lookup l ON b.payment_status_id = l.lookup_id
//                       WHERE l.value = 'Pending'";

//            dgvPendingBills.DataSource = DatabaseHelper.Instance.GetDataTable(query);
//        }

//        private void btnMarkCompleted_Click(object sender, EventArgs e)
//        {
//            if (dgvPendingBills.SelectedRows.Count == 0) return;

//            int billId = Convert.ToInt32(dgvPendingBills.SelectedRows[0].Cells["bill_id"].Value);

//            if (_billBL.FinalizePayment(billId, _billBL.GetStatusId("Completed")))
//            {
//                MessageBox.Show("Payment marked as completed and stock adjusted");
//                LoadPendingPayments();
//            }
//        }

//        private void btnMarkFailed_Click(object sender, EventArgs e)
//        {
//            if (dgvPendingBills.SelectedRows.Count == 0) return;

//            int billId = Convert.ToInt32(dgvPendingBills.SelectedRows[0].Cells["bill_id"].Value);

//            if (_billBL.FinalizePayment(billId, _billBL.GetStatusId("Failed")))
//            {
//                MessageBox.Show("Payment marked as failed");
//                LoadPendingPayments();
//            }
//        }
//    }
//}
