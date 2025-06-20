using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.DL
{
    public class CreateBillDL
    {

        public DataTable GetCustomers()
        {
            string query = "SELECT customer_id, name, cnic, contact FROM customer ORDER BY name";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetProductsWithStock()
        {
            string query = @"SELECT p.product_id, p.name, p.unit_price, 
                           p.quantity_in_stock AS available_stock
                           FROM products p
                           WHERE p.quantity_in_stock > 0";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable GetPaymentStatuses()
        {
            string query = @"SELECT lookup_id, value 
                           FROM lookup 
                           WHERE category = 'Payment Status'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public (string cnic, string contact) GetCustomerDetails(int customerId)
        {
            string query = @"SELECT cnic, contact 
                           FROM customer 
                           WHERE customer_id = @customerId";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@customerId", customerId)
            };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);
            return dt.Rows.Count > 0 ?
                (dt.Rows[0]["cnic"].ToString(), dt.Rows[0]["contact"].ToString()) :
                (string.Empty, string.Empty);
        }

        public bool HasSufficientStock(int productId, int quantity)
        {
            string query = @"SELECT quantity_in_stock 
                           FROM products 
                           WHERE product_id = @productId";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@productId", productId)
            };

            int currentStock = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
            return currentStock >= quantity;
        }

        public int CreateBillTransaction(int? customerId, int staffId, decimal discountAmount,
                              DataTable billItems, int paymentStatusId)
        {
            using (var connection = DatabaseHelper.Instance.getConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Create bill header first
                        string billQuery = @"INSERT INTO bill_quotation 
                                    (customer_id, staff_id, discount, total_amount, payment_status_id)
                                    VALUES (@customerId, @staffId, @discount, @totalAmount, @paymentStatusId);
                                    SELECT LAST_INSERT_ID();";

                        decimal totalAmount = CalculateTotalAmount(billItems) - discountAmount;

                        var billParams = new MySqlParameter[] {
                    new MySqlParameter("@customerId", customerId ?? (object)DBNull.Value),
                    new MySqlParameter("@staffId", staffId),
                    new MySqlParameter("@discount", discountAmount),
                    new MySqlParameter("@totalAmount", totalAmount),
                    new MySqlParameter("@paymentStatusId", paymentStatusId)
                };

                        int billId = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(billQuery, billParams));

                        // 2. Add bill items with transaction
                        foreach (DataRow row in billItems.Rows)
                        {
                            int productId = Convert.ToInt32(row["product_id"]);
                            int quantity = Convert.ToInt32(row["quantity"]);
                            decimal unitPrice = Convert.ToDecimal(row["unit_price"]);

                            // Verify product exists first
                            string productCheck = "SELECT COUNT(1) FROM products WHERE product_id = @productId";
                            var checkParam = new MySqlParameter("@productId", productId);
                            int exists = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(productCheck, checkParam));

                            if (exists == 0)
                            {
                                throw new Exception($"Product ID {productId} does not exist in database");
                            }

                            // Add bill item
                            string itemQuery = @"INSERT INTO bill_items 
                                      (bill_id, product_id, quantity, unit_price)
                                      VALUES (@billId, @productId, @quantity, @unitPrice)";

                            var itemParams = new MySqlParameter[] {
                        new MySqlParameter("@billId", billId),
                        new MySqlParameter("@productId", productId),
                        new MySqlParameter("@quantity", quantity),
                        new MySqlParameter("@unitPrice", unitPrice)
                    };

                            DatabaseHelper.Instance.Update(itemQuery, itemParams);
                        }

                        transaction.Commit();
                        return billId;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Failed to save bill: " + ex.Message, ex);
                    }
                }
            }
        }
        //public int CreateBillTransaction(int? customerId, int staffId, decimal discountAmount,
        //                              DataTable billItems, int paymentStatusId)
        //{
        //    using (var connection = DatabaseHelper.Instance.getConnection())
        //    {
        //        connection.Open();
        //        using (var transaction = connection.BeginTransaction())
        //        {
        //            try
        //            {
        //                // 1. Create bill header
        //                string billQuery = @"INSERT INTO bill_quotation 
        //                                  (customer_id, staff_id, discount, total_amount, payment_status_id)
        //                                  VALUES (@customerId, @staffId, @discount, @totalAmount, @paymentStatusId);
        //                                  SELECT LAST_INSERT_ID();";

        //                decimal totalAmount = CalculateTotalAmount(billItems) - discountAmount;

        //                var billParams = new MySqlParameter[] {
        //                    new MySqlParameter("@customerId", customerId ?? (object)DBNull.Value),
        //                    new MySqlParameter("@staffId", staffId),
        //                    new MySqlParameter("@discount", discountAmount),
        //                    new MySqlParameter("@totalAmount", totalAmount),
        //                    new MySqlParameter("@paymentStatusId", paymentStatusId)
        //                };

        //                int billId = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(billQuery, billParams));

        //                // 2. Add bill items and update stock
        //                foreach (DataRow row in billItems.Rows)
        //                {
        //                    int productId = Convert.ToInt32(row["product_id"]);
        //                    int quantity = Convert.ToInt32(row["quantity"]);
        //                    decimal unitPrice = Convert.ToDecimal(row["unit_price"]);

        //                    // Add bill item
        //                    string itemQuery = @"INSERT INTO bill_items 
        //                                      (bill_id, product_id, quantity, unit_price)
        //                                      VALUES (@billId, @productId, @quantity, @unitPrice)";

        //                    var itemParams = new MySqlParameter[] {
        //                        new MySqlParameter("@billId", billId),
        //                        new MySqlParameter("@productId", productId),
        //                        new MySqlParameter("@quantity", quantity),
        //                        new MySqlParameter("@unitPrice", unitPrice)
        //                    };

        //                    DatabaseHelper.Instance.Update(itemQuery, itemParams);

        //                    // Update stock (trigger will handle this automatically)
        //                    // Left for explicit control if needed
        //                    string stockQuery = @"UPDATE products 
        //                                       SET quantity_in_stock = quantity_in_stock - @quantity
        //                                       WHERE product_id = @productId";

        //                    var stockParams = new MySqlParameter[] {
        //                        new MySqlParameter("@quantity", quantity),
        //                        new MySqlParameter("@productId", productId)
        //                    };

        //                    DatabaseHelper.Instance.Update(stockQuery, stockParams);
        //                }

        //                transaction.Commit();
        //                return billId;
        //            }
        //            catch
        //            {
        //                transaction.Rollback();
        //                throw;
        //            }
        //        }
        //    }
        //}

        private decimal CalculateTotalAmount(DataTable billItems)
        {
            decimal total = 0;
            foreach (DataRow row in billItems.Rows)
            {
                total += Convert.ToDecimal(row["quantity"]) * Convert.ToDecimal(row["unit_price"]);
            }
            return total;
        }
    }
}