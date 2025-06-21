using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class BorrowedDL
    {
        public static bool AddBorrowed(Borrowed b)
        {
            string query = $@"
                INSERT INTO borrowed
                (customer_id, product_id, quantity, unit_price, total_amount, is_paid, date_borrowed)
                VALUES
                ({b.CustomerId}, {b.ProductId}, {b.Quantity}, {b.UnitPrice}, {b.TotalAmount}, {b.IsPaid}, NOW())";

            return DatabaseHelper.Instance.Update(query) > 0;
        }
        public static DataTable GetBorrowedListByCustomer(int customerId)
        {
            string query = $@"
        SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name,
               b.quantity, b.unit_price, b.total_amount, b.is_paid, b.date_borrowed
        FROM borrowed b
        JOIN customer c ON b.customer_id = c.customer_id
        JOIN products p ON b.product_id = p.product_id
        WHERE b.customer_id = {customerId}";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable GetBorrowedById(int borrowedId)
        {
            string query = $"SELECT * FROM borrowed WHERE borrowed_id = {borrowedId}";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable GetCustomerList()
        {
            string query = "SELECT customer_id, name FROM customer ORDER BY name ASC";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
        public static DataTable GetBorrowedList()
        {
            string query = @"
                SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name,
                       b.quantity, b.unit_price, b.total_amount, b.is_paid, b.date_borrowed
                FROM borrowed b
                JOIN customer c ON b.customer_id = c.customer_id
                JOIN products p ON b.product_id = p.product_id";

            return DatabaseHelper.Instance.GetDataTable(query);
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
                    is_paid = {b.IsPaid}
                WHERE borrowed_id = {b.BorrowedId}";

            return DatabaseHelper.Instance.Update(query) > 0;
        }
        public static DataTable GetBorrowedByCustomerId(int customerId)
        {
            string query = $@"
        SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name, b.quantity, b.unit_price, b.total_amount, b.date_borrowed, b.is_paid
        FROM borrowed b
        JOIN customer c ON b.customer_id = c.customer_id
        JOIN products p ON b.product_id = p.product_id
        WHERE b.customer_id = {customerId}
        ORDER BY b.date_borrowed DESC";

            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static DataTable GetAllBorrowedWithCustomerInfo()
        {
            string query = @"
        SELECT b.borrowed_id, c.name AS customer_name, p.name AS product_name, b.quantity, b.unit_price, b.total_amount, b.date_borrowed, b.is_paid
        FROM borrowed b
        JOIN customer c ON b.customer_id = c.customer_id
        JOIN products p ON b.product_id = p.product_id
        ORDER BY b.date_borrowed DESC";

            return DatabaseHelper.Instance.GetDataTable(query);
        }

        //public static DataTable GetCustomerList()
        //{
        //    string query = "SELECT customer_id, name FROM customer ORDER BY name";
        //    return DatabaseHelper.Instance.GetDataTable(query);
        //}

    }
}