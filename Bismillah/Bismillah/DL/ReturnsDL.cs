using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public class ReturnsDL
    {
        private readonly DatabaseHelper dbHelper;

        public ReturnsDL()
        {
            dbHelper = DatabaseHelper.Instance;
        }

        public DataTable GetCustomers()
        {
            string query = "SELECT customer_id, name, contact, cnic FROM customer ORDER BY name";
            return dbHelper.GetDataTable(query);
        }

        public DataTable SearchCustomerPurchases(int customerId, string searchTerm = "")
        {
            string query = @"
                SELECT DISTINCT p.product_id, p.name, p.unit_price
                FROM bill_quotation b
                JOIN bill_items bi ON b.bill_id = bi.bill_id
                JOIN products p ON bi.product_id = p.product_id
                WHERE b.customer_id = @customerId
                AND p.name LIKE @searchTerm
                ORDER BY p.name";

            MySqlParameter[] parameters = {
                new MySqlParameter("@customerId", customerId),
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };

            return dbHelper.GetDataTable(query, parameters);
        }

        public bool ProcessReturn(int customerId, DataTable returnItems)
        {
            using (var connection = dbHelper.getConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (DataRow row in returnItems.Rows)
                        {
                            string query = @"
                                INSERT INTO customer_returns_products 
                                (customer_id, product_id, quantity, return_date)
                                VALUES (@customerId, @productId, @quantity, NOW())";

                            MySqlParameter[] parameters = {
                                new MySqlParameter("@customerId", customerId),
                                new MySqlParameter("@productId", row["product_id"]),
                                new MySqlParameter("@quantity", row["quantity"])
                            };

                            dbHelper.Update(query, parameters);
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        public DataTable GetReturnHistory(int customerId = 0)
        {
            string query = @"
                SELECT 
                    r.return_id,
                    c.name AS customer_name,
                    p.name AS product_name,
                    r.quantity,
                    r.return_date
                FROM customer_returns_products r
                JOIN customer c ON r.customer_id = c.customer_id
                JOIN products p ON r.product_id = p.product_id
                WHERE (@customerId = 0 OR r.customer_id = @customerId)
                ORDER BY r.return_date DESC";

            MySqlParameter[] parameters = {
                new MySqlParameter("@customerId", customerId)
            };

            return dbHelper.GetDataTable(query, parameters);
        }
    }
}