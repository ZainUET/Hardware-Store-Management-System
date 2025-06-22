using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class PaymentDL
    {

        public static DataTable GetAllPayments()
        {
            string query = @"
        SELECT 
            p.payment_id,
            IFNULL(c.name, p.customer_name) AS customer_name,
            p.amount_paid,
            p.payment_method,
            p.payment_date
        FROM payments p
        LEFT JOIN customer c ON p.customer_id = c.customer_id
        ORDER BY p.payment_date DESC";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetCustomerListForPayments()
        {
            string query = "SELECT customer_id, name FROM customer ORDER BY name";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetPaymentsByCustomerId(int customerId)
        {
            string query = $@"
        SELECT 
            p.payment_id,
            IFNULL(c.name, p.customer_name) AS customer_name,
            p.amount_paid,
            p.payment_method,
            p.payment_date
        FROM payments p
        LEFT JOIN customer c ON p.customer_id = c.customer_id
        WHERE p.customer_id = {customerId}
        ORDER BY p.payment_date DESC";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
