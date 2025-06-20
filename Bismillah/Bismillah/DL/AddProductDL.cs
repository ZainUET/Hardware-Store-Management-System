using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class AddProductDL
    {
        public static bool AddProduct(Product product)
        {
            string query = $@"
                INSERT INTO products 
                (name, category_id, supplier_id, size, unit_price, quantity_in_stock, last_updated)
                VALUES 
                ('{product.Name}', {product.CategoryId}, {product.SupplierId}, '{product.Size}', {product.UnitPrice}, {product.QuantityInStock}, '{product.LastUpdated:yyyy-MM-dd HH:mm:ss}')";

            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static DataTable GetCategories()
        {
            return LookupDL.GetLookupValues("Product Category");
        }

        public static DataTable GetSuppliers()
        {
            string query = "SELECT supplier_id, name FROM supplier";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}


