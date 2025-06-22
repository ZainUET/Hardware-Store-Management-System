using Bismillah.Entities;
using System.Data;

namespace Bismillah.DL
{
    internal class BorrowedDL
    {
        public static bool AddBorrowed(Borrowed b)
        {
            string query = $@"
                INSERT INTO borrowed
                (customer_id, product_id, quantity, unit_price, total_amount, payment_status_id, date_borrowed)
                VALUES
                ({b.CustomerId}, {b.ProductId}, {b.Quantity}, {b.UnitPrice}, {b.TotalAmount}, {b.PaymentStatusId}, NOW())";

            bool inserted = DatabaseHelper.Instance.Update(query) > 0;

            if (inserted && (b.PaymentStatusId == GetStatusId("Pending") || b.PaymentStatusId == GetStatusId("Completed")))
            {
                ReduceProductStock(b.ProductId, b.Quantity);
            }

            return inserted;
        }
        public static bool IsStockAvailable(int productId, int requestedQty)
        {
            string query = $"SELECT quantity_in_stock FROM products WHERE product_id = {productId}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count == 0) return false;

            int available = Convert.ToInt32(dt.Rows[0]["quantity_in_stock"]);
            return available >= requestedQty;
        }

        public static void InsertPayment(int customerId, decimal amount, string method, string customerName)
        {
            string query = $@"
        INSERT INTO payments (customer_id, customer_name, amount_paid, payment_method)
        VALUES ({customerId}, '{customerName}', {amount}, '{method}')";
            DatabaseHelper.Instance.Update(query);
        }


        public static string GetLookupValueById(int lookupId)
        {
            string query = $"SELECT value FROM lookup WHERE lookup_id = {lookupId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? dt.Rows[0]["value"].ToString() : "";
        }

        public static void ReduceProductStock(int productId, int quantity)
        {
            string query = $"UPDATE products SET quantity_in_stock = quantity_in_stock - {quantity} WHERE product_id = {productId}";
            DatabaseHelper.Instance.Update(query);
        }

        public static int GetStatusId(string status)
        {
            string query = $"SELECT lookup_id FROM lookup WHERE category = 'Payment Status' AND value = '{status}' LIMIT 1";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["lookup_id"]) : 0;
        }

        public static int GetProductStock(int productId)
        {
            string query = $"SELECT quantity_in_stock FROM products WHERE product_id = {productId}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            return dt.Rows.Count > 0 ? Convert.ToInt32(dt.Rows[0]["quantity_in_stock"]) : 0;
        }

        public static DataTable GetCustomerList()
        {
            return DatabaseHelper.Instance.GetDataTable("SELECT customer_id, name FROM customer ORDER BY name ASC");
        }

        public static DataTable GetBorrowedList()
        {
            string query = @"
                SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name,
                       b.quantity, b.unit_price, b.total_amount, l.value AS payment_status, b.date_borrowed
                FROM borrowed b
                JOIN customer c ON b.customer_id = c.customer_id
                JOIN products p ON b.product_id = p.product_id
                LEFT JOIN lookup l ON b.payment_status_id = l.lookup_id";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetBorrowedListByCustomer(int customerId)
        {
            string query = $@"
                SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name,
                       b.quantity, b.unit_price, b.total_amount, l.value AS payment_status, b.date_borrowed
                FROM borrowed b
                JOIN customer c ON b.customer_id = c.customer_id
                JOIN products p ON b.product_id = p.product_id
                LEFT JOIN lookup l ON b.payment_status_id = l.lookup_id
                WHERE b.customer_id = {customerId}";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetBorrowedById(int borrowedId)
        {
            return DatabaseHelper.Instance.GetDataTable($"SELECT * FROM borrowed WHERE borrowed_id = {borrowedId}");
        }

        public static bool DeleteBorrowed(int id)
        {
            string query = $"DELETE FROM borrowed WHERE borrowed_id = {id}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool UpdateBorrowed(Borrowed b)
        {
            string query = $@"
        UPDATE borrowed SET 
            customer_id = {b.CustomerId},
            product_id = {b.ProductId},
            quantity = {b.Quantity},
            unit_price = {b.UnitPrice},
            total_amount = {b.TotalAmount},
            payment_status_id = {b.PaymentStatusId}
        WHERE borrowed_id = {b.BorrowedId}";

            return DatabaseHelper.Instance.Update(query) > 0;
        }
        public static decimal GetUnitPrice(int productId)
        {
            string query = $"SELECT unit_price FROM products WHERE product_id = {productId}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count > 0)
                return Convert.ToDecimal(dt.Rows[0]["unit_price"]);
            return 0;
        }



    }
}
