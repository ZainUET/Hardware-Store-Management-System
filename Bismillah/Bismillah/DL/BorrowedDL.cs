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
                (customer_id, product_id, batch_id, quantity, unit_price, total_amount, is_paid, date_borrowed)
                VALUES
                ({b.CustomerId}, {b.ProductId}, {b.BatchId}, {b.Quantity}, {b.UnitPrice}, {b.TotalAmount}, {b.IsPaid}, NOW())";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static DataTable GetBorrowedList()
        {
            string query = @"SELECT * FROM borrowed";
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
                    batch_id = {b.BatchId},
                    quantity = {b.Quantity},
                    unit_price = {b.UnitPrice},
                    total_amount = {b.TotalAmount},
                    is_paid = {b.IsPaid}
                WHERE borrowed_id = {b.BorrowedId}";

            return DatabaseHelper.Instance.Update(query) > 0;
        }
    }
}