using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.DL
{
    public class CreateBillDL
    {
        public bool UpdatePaymentStatus(int billId, int paymentStatusId)
        {
            string query = @"UPDATE bill_quotation 
                   SET payment_status_id = @paymentStatusId
                   WHERE bill_id = @billId";

            MySqlParameter[] parameters = {
        new MySqlParameter("@paymentStatusId", paymentStatusId),
        new MySqlParameter("@billId", billId)
    };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public bool AdjustStockForBill(int billId, bool restoreStock)
        {
            // Get all items in the bill
            string query = $@"SELECT product_id, quantity, batch_id 
                    FROM bill_items 
                    WHERE bill_id = {billId}";

            DataTable billItems = DatabaseHelper.Instance.GetDataTable(query);

            foreach (DataRow row in billItems.Rows)
            {
                int productId = Convert.ToInt32(row["product_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                int batchId = Convert.ToInt32(row["batch_id"]);

                // Determine whether to add or subtract stock
                int adjustment = restoreStock ? quantity : -quantity;

                // Update stock
                string updateQuery = $@"UPDATE stock 
                              SET quantity_in_stock = quantity_in_stock + {adjustment}
                              WHERE product_id = {productId} AND batch_id = {batchId}";

                DatabaseHelper.Instance.Update(updateQuery);
            }

            return true;
        }



        public DataTable GetCustomers()
        {
            string query = "SELECT customer_id, name FROM customer ORDER BY name";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetProducts()
        {
            string query = "SELECT product_id, name, selling_price FROM products WHERE quantity > 0";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetPaymentStatuses()
        {
            string query = @"SELECT lookup_id, value 
                            FROM lookup 
                            WHERE category = 'Payment Status'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public int CreateBill(int? customerId, int staffId, decimal discountAmount, decimal totalAmount, int paymentStatusId)
        {
            string customerIdValue = customerId.HasValue ? customerId.Value.ToString() : "NULL";

            string query = $@"INSERT INTO bill_quotation 
                   (customer_id, staff_id, discount, payment_status_id, total_amount)
                   VALUES ({customerIdValue}, {staffId}, {discountAmount}, 
                          {paymentStatusId},
                          {totalAmount});
                   SELECT LAST_INSERT_ID();";

            return DatabaseHelper.Instance.Scaler(query);
        }
        public bool AddBillItem(int billId, int productId, int quantity, decimal unitPrice, int? batchId)
        {
            string batchIdValue = batchId.HasValue ? batchId.Value.ToString() : "NULL";

            string query = $@"INSERT INTO bill_items 
                           (bill_id, product_id, quantity, unit_price, batch_id)
                           VALUES ({billId}, {productId}, {quantity}, {unitPrice}, {batchIdValue})";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public bool UpdateBillTotal(int billId, decimal totalAmount, decimal taxAmount)
        {
            string query = $@"UPDATE bill_quotation 
                           SET total_amount = {totalAmount}, 
                               tax_amount = {taxAmount} 
                           WHERE bill_id = {billId}";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public DataRow GetCustomerDetails(int customerId)
        {
            string query = $@"SELECT cnic, loyalty_points 
                           FROM customer 
                           WHERE customer_id = {customerId}";

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }
    }
}