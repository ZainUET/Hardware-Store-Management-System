//using MySql.Data.MySqlClient;
//using System.Data;

//namespace Bismillah.DL
//{
//    public class CreateBillDL
//    {
//        public bool UpdatePaymentStatus(int billId, int paymentStatusId)
//        {
//            string query = @"UPDATE bill_quotation 
//                   SET payment_status_id = @paymentStatusId
//                   WHERE bill_id = @billId";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@paymentStatusId", paymentStatusId),
//        new MySqlParameter("@billId", billId)
//    };

//            return DatabaseHelper.Instance.Update(query, parameters) > 0;
//        }
//        public bool AdjustStockForBill(int billId, bool restoreStock)
//        {
//            string query = @"SELECT bi.product_id, bi.quantity, bi.batch_id 
//                     FROM bill_items bi
//                     WHERE bi.bill_id = @billId";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@billId", billId)
//    };

//            DataTable billItems = DatabaseHelper.Instance.GetDataTable(query, parameters);

//            foreach (DataRow row in billItems.Rows)
//            {
//                int productId = Convert.ToInt32(row["product_id"]);
//                int quantity = Convert.ToInt32(row["quantity"]);
//                object batchIdValue = row["batch_id"];

//                if (batchIdValue == DBNull.Value) continue;

//                int batchId = Convert.ToInt32(batchIdValue);
//                int adjustment = restoreStock ? quantity : -quantity;

//                string updateQuery = @"UPDATE stock 
//                              SET quantity_in_stock = quantity_in_stock + @adjustment
//                              WHERE product_id = @productId 
//                              AND batch_id = @batchId";

//                MySqlParameter[] updateParams = {
//            new MySqlParameter("@adjustment", adjustment),
//            new MySqlParameter("@productId", productId),
//            new MySqlParameter("@batchId", batchId)
//        };

//                DatabaseHelper.Instance.Update(updateQuery, updateParams);
//            }
//            return true;
//        }

//        public DataTable GetCustomers()
//        {
//            string query = "SELECT customer_id, name FROM customer ORDER BY name";
//            return DatabaseHelper.Instance.GetDataTable(query);
//        }



//        public DataTable GetProducts()
//        {
//            string query = @"SELECT p.product_id, p.name, p.unit_price AS selling_price
//                     FROM products p
//                     JOIN stock s ON p.product_id = s.product_id
//                     WHERE s.quantity_in_stock > 0
//                     GROUP BY p.product_id";
//            return DatabaseHelper.Instance.GetDataTable(query);
//        }

//        public DataTable GetPaymentStatuses()
//        {
//            string query = @"SELECT lookup_id, value 
//                            FROM lookup 
//                            WHERE category = 'Payment Status'";
//            return DatabaseHelper.Instance.GetDataTable(query);
//        }

//        public int CreateBill(int? customerId, int staffId, decimal discountAmount, decimal totalAmount, int paymentStatusId)
//        {
//            string customerIdValue = customerId.HasValue ? customerId.Value.ToString() : "NULL";

//            string query = $@"INSERT INTO bill_quotation 
//                   (customer_id, staff_id, discount, payment_status_id, total_amount)
//                   VALUES ({customerIdValue}, {staffId}, {discountAmount}, 
//                          {paymentStatusId},
//                          {totalAmount});
//                   SELECT LAST_INSERT_ID();";

//            return DatabaseHelper.Instance.Scaler(query);
//        }
//        public bool AddBillItem(int billId, int productId, int quantity, decimal unitPrice, int? batchId)
//        {
//            string batchIdValue = batchId.HasValue ? batchId.Value.ToString() : "NULL";

//            string query = $@"INSERT INTO bill_items 
//                           (bill_id, product_id, quantity, unit_price, batch_id)
//                           VALUES ({billId}, {productId}, {quantity}, {unitPrice}, {batchIdValue})";

//            return DatabaseHelper.Instance.Update(query) > 0;
//        }

//        public bool UpdateBillTotal(int billId, decimal totalAmount, decimal taxAmount)
//        {
//            string query = $@"UPDATE bill_quotation 
//                           SET total_amount = {totalAmount}, 
//                               tax_amount = {taxAmount} 
//                           WHERE bill_id = {billId}";

//            return DatabaseHelper.Instance.Update(query) > 0;
//        }

//        public DataRow GetCustomerDetails(int customerId)
//        {
//            string query = $@"SELECT cnic, loyalty_points 
//                           FROM customer 
//                           WHERE customer_id = {customerId}";

//            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
//            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
//        }
//    }
//}



using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.DL
{
    public class CreateBillDL
    {
        public DataTable GetCustomers()
        {
            string query = "SELECT customer_id, name, cnic, loyalty_points FROM customer ORDER BY name";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetProducts()
        {
            string query = @"SELECT p.product_id, p.name, p.unit_price 
                     FROM products p
                     JOIN stock s ON p.product_id = s.product_id
                     WHERE s.quantity_in_stock > 0
                     GROUP BY p.product_id";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetPaymentStatuses()
        {
            string query = @"SELECT lookup_id, value 
                     FROM lookup 
                     WHERE category = 'Payment Status'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataRow GetCustomerDetails(int customerId)
        {
            string query = $@"SELECT cnic, loyalty_points 
                           FROM customer 
                           WHERE customer_id = {customerId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool HasSufficientStock(int productId, int quantity)
        {
            string query = @"SELECT COALESCE(SUM(quantity_in_stock), 0) 
                     FROM stock 
                     WHERE product_id = @productId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@productId", productId)
            };

            int currentStock = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
            return currentStock >= quantity;
        }

        public int CreateBill(int? customerId, int staffId, decimal discountAmount,
                            decimal totalAmount, int paymentStatusId)
        {
            string customerIdValue = customerId.HasValue ? customerId.Value.ToString() : "NULL";

            string query = $@"INSERT INTO bill_quotation 
                   (customer_id, staff_id, discount, total_amount, payment_status_id)
                   VALUES ({customerIdValue}, {staffId}, {discountAmount}, 
                          {totalAmount}, {paymentStatusId});
                   SELECT LAST_INSERT_ID();";

            return DatabaseHelper.Instance.Scaler(query);
        }

        public bool AddBillItem(int billId, int productId, int quantity,
                              decimal unitPrice, int? batchId)
        {
            string batchIdValue = batchId.HasValue ? batchId.Value.ToString() : "NULL";

            string query = $@"INSERT INTO bill_items 
                   (bill_id, product_id, quantity, unit_price, batch_id)
                   VALUES ({billId}, {productId}, {quantity}, {unitPrice}, {batchIdValue})";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public bool FinalizePayment(int billId, int newPaymentStatusId)
        {
            string query = @"UPDATE bill_quotation 
                   SET payment_status_id = @paymentStatusId
                   WHERE bill_id = @billId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@paymentStatusId", newPaymentStatusId),
                new MySqlParameter("@billId", billId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }
    }
}