//using Bismillah.Entities;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Bismillah.DL
//{
//    internal class ProductDL
//    {
//        public static DataTable GetAllProducts()
//        {
//            string query = "SELECT * FROM products";
//            return DatabaseHelper.Instance.GetDataTable(query);
//        }

//        public static Product GetProductById(int id)
//        {
//            string query = $"SELECT * FROM products WHERE product_id = {id}";
//            var dt = DatabaseHelper.Instance.GetDataTable(query);
//            if (dt.Rows.Count == 0) return null;

//            DataRow row = dt.Rows[0];
//            return new Product
//            {
//                ProductId = Convert.ToInt32(row["product_id"]),
//                Name = row["name"].ToString(),
//                CategoryId = Convert.ToInt32(row["category_id"]),
//                SupplierId = Convert.ToInt32(row["supplier_id"]),
//                Size = row["size"].ToString(),
//                QuantityInStock = Convert.ToInt32(row["quantity_in_stock"]),
//                UnitPrice = Convert.ToDecimal(row["unit_price"]),
//                LastUpdated = Convert.ToDateTime(row["last_updated"])
//            };
//        }

//        public static bool UpdateProduct(Product p)
//        {
//            string query = $@"
//                UPDATE products SET 
//                    name = '{p.Name}', 
//                    category_id = {p.CategoryId}, 
//                    supplier_id = {p.SupplierId}, 
//                    size = '{p.Size}', 
//                    unit_price = {p.UnitPrice}, 
//                    quantity_in_stock = {p.QuantityInStock}, 
//                    last_updated = CURRENT_TIMESTAMP 
//                WHERE product_id = {p.ProductId}";

//            return DatabaseHelper.Instance.Update(query) > 0;
//        }

//        public static bool DeleteProduct(int id)
//        {
//            string query = $"DELETE FROM products WHERE product_id = {id}";
//            return DatabaseHelper.Instance.Update(query) > 0;
//        }
//    }
//}

using Bismillah.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class ProductDL
    {
        public static DataTable GetAllProducts()
        {
            string query = "SELECT * FROM products";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static Product GetProductById(int id)
        {
            string query = "SELECT * FROM products WHERE product_id = @id";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };

            var dt = DatabaseHelper.Instance.GetDataTable(query, parameters);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Product
            {
                ProductId = Convert.ToInt32(row["product_id"]),
                Name = row["name"].ToString(),
                CategoryId = Convert.ToInt32(row["category_id"]),
                SupplierId = Convert.ToInt32(row["supplier_id"]),
                Size = row["size"].ToString(),
                QuantityInStock = Convert.ToInt32(row["quantity_in_stock"]),
                UnitPrice = Convert.ToDecimal(row["unit_price"]),
                LastUpdated = Convert.ToDateTime(row["last_updated"])
            };
        }

        public static bool UpdateProduct(Product p)
        {
            string query = @"
                UPDATE products SET 
                    name = @name, 
                    category_id = @categoryId, 
                    supplier_id = @supplierId, 
                    size = @size, 
                    unit_price = @unitPrice, 
                    quantity_in_stock = @quantity, 
                    last_updated = CURRENT_TIMESTAMP 
                WHERE product_id = @productId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@name", p.Name),
                new MySqlParameter("@categoryId", p.CategoryId),
                new MySqlParameter("@supplierId", p.SupplierId),
                new MySqlParameter("@size", p.Size),
                new MySqlParameter("@unitPrice", p.UnitPrice),
                new MySqlParameter("@quantity", p.QuantityInStock),
                new MySqlParameter("@productId", p.ProductId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static bool DeleteProduct(int id)
        {
            string query = "DELETE FROM products WHERE product_id = @id";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", id)
            };
            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static DataTable SearchProducts(string searchTerm)
        {
            string query = "SELECT * FROM products WHERE name LIKE @searchTerm";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };
            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }

        public static bool ReduceProductStock(int productId, int quantity)
        {
            string query = @"
                UPDATE products 
                SET quantity_in_stock = quantity_in_stock - @quantity,
                    last_updated = CURRENT_TIMESTAMP
                WHERE product_id = @productId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@quantity", quantity),
                new MySqlParameter("@productId", productId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static bool IncreaseProductStock(int productId, int quantity)
        {
            string query = @"
                UPDATE products 
                SET quantity_in_stock = quantity_in_stock + @quantity,
                    last_updated = CURRENT_TIMESTAMP
                WHERE product_id = @productId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@quantity", quantity),
                new MySqlParameter("@productId", productId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static DataTable GetProductsByCategory(int categoryId)
        {
            string query = "SELECT * FROM products WHERE category_id = @categoryId";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@categoryId", categoryId)
            };
            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }

        public static DataTable GetLowStockProducts(int threshold = 10)
        {
            string query = "SELECT * FROM products WHERE quantity_in_stock < @threshold";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@threshold", threshold)
            };
            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }
    }
}