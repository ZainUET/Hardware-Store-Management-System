using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public class frmBillingDL
    {
        private readonly DatabaseHelper _dbHelper;

        public frmBillingDL()
        {
            _dbHelper = DatabaseHelper.Instance;
        }

        public DataTable GetProducts(string searchTerm = "")
        {
            string query = @"SELECT p.product_id, p.name, p.selling_price, p.batch_id, 
                           s.quantity_in_stock as quantity
                           FROM products p
                           JOIN stock s ON p.product_id = s.product_id AND p.batch_id = s.batch_id
                           WHERE s.quantity_in_stock > 0";

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += $" AND p.name LIKE '%{searchTerm}%'";
            }

            return _dbHelper.GetDataTable(query);
        }

        public DataTable GetCustomers(bool regularOnly = false)
        {
            string query = "SELECT customer_id, name, contact, cnic, address, loyalty_points, is_regular FROM customer";

            if (regularOnly)
            {
                query += " WHERE is_regular = 1";
            }

            return _dbHelper.GetDataTable(query);
        }

        public DataRow GetCustomerById(int customerId)
        {
            string query = $"SELECT * FROM customer WHERE customer_id = {customerId}";
            DataTable dt = _dbHelper.GetDataTable(query);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataTable GetPaymentStatuses()
        {
            return _dbHelper.GetDataTable(
                "SELECT lookup_id, value FROM lookup WHERE category = 'Payment Status'");
        }

        public int SaveBill(int? customerId, int staffId, DateTime billDate, decimal totalAmount,
                          decimal discount, decimal taxAmount, int? paymentStatusId)
        {
            string query = $@"INSERT INTO bill_quotation 
                            (customer_id, staff_id, bill_date, total_amount, 
                             discount, tax_amount, payment_status_id) 
                            VALUES 
                            ({(customerId.HasValue ? customerId.ToString() : "NULL")}, 
                             {staffId}, '{billDate:yyyy-MM-dd HH:mm:ss}', 
                             {totalAmount}, {discount}, {taxAmount}, 
                             {(paymentStatusId.HasValue ? paymentStatusId.ToString() : "NULL")});
                             SELECT LAST_INSERT_ID();";

            return _dbHelper.Scaler(query);
        }

        public int SaveBillItem(int billId, int productId, int quantity, decimal unitPrice, int? batchId)
        {
            string query = $@"INSERT INTO bill_items 
                            (bill_id, product_id, quantity, unit_price, batch_id) 
                            VALUES 
                            ({billId}, {productId}, {quantity}, {unitPrice}, 
                             {(batchId.HasValue ? batchId.ToString() : "NULL")})";

            return _dbHelper.Update(query);
        }

        public int UpdateStock(int productId, int batchId, int quantity)
        {
            string query = $@"UPDATE stock 
                            SET quantity_in_stock = quantity_in_stock - {quantity} 
                            WHERE product_id = {productId} AND batch_id = {batchId}";

            return _dbHelper.Update(query);
        }

        public int UpdateCustomerLoyaltyPoints(int customerId, int pointsToAdd)
        {
            string query = $@"UPDATE customer 
                            SET loyalty_points = loyalty_points + {pointsToAdd} 
                            WHERE customer_id = {customerId}";

            return _dbHelper.Update(query);
        }
    }
}