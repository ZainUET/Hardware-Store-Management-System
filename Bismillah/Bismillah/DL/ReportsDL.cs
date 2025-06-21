using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public class ReportsDL
    {
        private readonly DatabaseHelper dbHelper;

        public ReportsDL()
        {
            dbHelper = DatabaseHelper.Instance;
        }

        public DataTable GetProductStockReport()
        {
            string query = @"
                SELECT 
                    p.product_id AS 'Product ID',
                    p.name AS 'Product Name',
                    l.value AS 'Category',
                    p.size AS 'Size',
                    p.unit_price AS 'Unit Price',
                    p.quantity_in_stock AS 'Stock Quantity',
                    s.name AS 'Supplier',
                    p.last_updated AS 'Last Updated'
                FROM products p
                JOIN lookup l ON p.category_id = l.lookup_id
                JOIN supplier s ON p.supplier_id = s.supplier_id
                ORDER BY p.name";

            return dbHelper.GetDataTable(query);
        }

        public DataTable GetCustomerPurchaseReport()
        {
            string query = @"
                SELECT 
                    c.customer_id AS 'Customer ID',
                    c.name AS 'Customer Name',
                    c.contact AS 'Contact',
                    COUNT(b.bill_id) AS 'Total Bills',
                    SUM(b.total_amount - b.discount) AS 'Total Spent',
                    MAX(b.bill_date) AS 'Last Purchase Date'
                FROM customer c
                LEFT JOIN bill_quotation b ON c.customer_id = b.customer_id
                GROUP BY c.customer_id
                ORDER BY c.name";

            return dbHelper.GetDataTable(query);
        }

        public DataTable GetSalesReport(DateTime? startDate = null, DateTime? endDate = null)
        {
            string query = @"
                SELECT 
                    b.bill_id AS 'Bill ID',
                    b.bill_date AS 'Date',
                    c.name AS 'Customer',
                    s.name AS 'Staff',
                    b.total_amount AS 'Total Amount',
                    b.discount AS 'Discount',
                    (b.total_amount - b.discount) AS 'Net Amount',
                    l.value AS 'Payment Status'
                FROM bill_quotation b
                JOIN customer c ON b.customer_id = c.customer_id
                JOIN staff s ON b.staff_id = s.staff_id
                LEFT JOIN lookup l ON b.payment_status_id = l.lookup_id
                WHERE (@startDate IS NULL OR b.bill_date >= @startDate)
                AND (@endDate IS NULL OR b.bill_date <= @endDate)
                ORDER BY b.bill_date DESC";

            MySqlParameter[] parameters = {
                new MySqlParameter("@startDate", startDate ?? (object)DBNull.Value),
                new MySqlParameter("@endDate", endDate ?? (object)DBNull.Value)
            };

            return dbHelper.GetDataTable(query, parameters);
        }

        public DataTable GetSupplierOrdersReport()
        {
            string query = @"
                SELECT 
                    po.order_id AS 'Order ID',
                    po.order_date AS 'Order Date',
                    s.name AS 'Supplier',
                    s.company AS 'Company',
                    SUM(pod.quantity * pod.unit_price) AS 'Total Amount',
                    l.value AS 'Status'
                FROM purchase_orders po
                JOIN supplier s ON po.supplier_id = s.supplier_id
                JOIN purchase_order_details pod ON po.order_id = pod.order_id
                LEFT JOIN lookup l ON po.status_id = l.lookup_id
                GROUP BY po.order_id
                ORDER BY po.order_date DESC";

            return dbHelper.GetDataTable(query);
        }
    }
}