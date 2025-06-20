using Bismillah.Entities;
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
            string query = $"SELECT * FROM products WHERE product_id = {id}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
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
            string query = $@"
                UPDATE products SET 
                    name = '{p.Name}', 
                    category_id = {p.CategoryId}, 
                    supplier_id = {p.SupplierId}, 
                    size = '{p.Size}', 
                    unit_price = {p.UnitPrice}, 
                    quantity_in_stock = {p.QuantityInStock}, 
                    last_updated = CURRENT_TIMESTAMP 
                WHERE product_id = {p.ProductId}";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool DeleteProduct(int id)
        {
            string query = $"DELETE FROM products WHERE product_id = {id}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }
    }
}

