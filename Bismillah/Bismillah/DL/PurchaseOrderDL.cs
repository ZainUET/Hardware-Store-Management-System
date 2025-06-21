using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public class PurchaseOrderDL
    {
        private readonly DatabaseHelper dbHelper;

        public PurchaseOrderDL()
        {
            dbHelper = DatabaseHelper.Instance;
        }

        public DataTable GetSuppliers()
        {
            string query = "SELECT supplier_id, name, contact FROM supplier ORDER BY name";
            return dbHelper.GetDataTable(query);
        }

        public DataTable GetProducts()
        {
            string query = @"SELECT product_id, name, unit_price 
                           FROM products 
                           WHERE quantity_in_stock > 0 
                           ORDER BY name";
            return dbHelper.GetDataTable(query);
        }

        public int CreatePurchaseOrder(int supplierId, string notes, decimal totalAmount)
        {
            string query = @"INSERT INTO purchase_orders 
                           (supplier_id, order_date, total_amount, status_id)
                           VALUES (@supplierId, NOW(), @totalAmount, 
                           (SELECT lookup_id FROM lookup WHERE category = 'Payment Status' AND value = 'Pending'));
                           SELECT LAST_INSERT_ID();";

            MySqlParameter[] parameters = {
                new MySqlParameter("@supplierId", supplierId),
                new MySqlParameter("@totalAmount", totalAmount)
            };

            return Convert.ToInt32(dbHelper.ExecuteScalar(query, parameters));
        }

        public bool AddOrderItem(int orderId, int productId, int quantity, decimal unitPrice)
        {
            string query = @"INSERT INTO purchase_order_details 
                           (order_id, product_id, quantity, unit_price, received_quantity)
                           VALUES (@orderId, @productId, @quantity, @unitPrice, 0)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@orderId", orderId),
                new MySqlParameter("@productId", productId),
                new MySqlParameter("@quantity", quantity),
                new MySqlParameter("@unitPrice", unitPrice)
            };

            return dbHelper.Update(query, parameters) > 0;
        }

        public bool UpdateProductStock(int productId, int quantity)
        {
            string query = @"UPDATE products 
                            SET quantity_in_stock = quantity_in_stock + @quantity,
                                last_updated = NOW()
                            WHERE product_id = @productId";

            MySqlParameter[] parameters = {
                new MySqlParameter("@productId", productId),
                new MySqlParameter("@quantity", quantity)
            };

            return dbHelper.Update(query, parameters) > 0;
        }

        public DataTable GetSupplierContact(int supplierId)
        {
            string query = "SELECT contact FROM supplier WHERE supplier_id = @supplierId";
            MySqlParameter[] parameters = {
                new MySqlParameter("@supplierId", supplierId)
            };
            return dbHelper.GetDataTable(query, parameters);
        }

        public DataTable GetProductPrice(int productId)
        {
            string query = "SELECT unit_price FROM products WHERE product_id = @productId";
            MySqlParameter[] parameters = {
                new MySqlParameter("@productId", productId)
            };
            return dbHelper.GetDataTable(query, parameters);
        }
    }
}