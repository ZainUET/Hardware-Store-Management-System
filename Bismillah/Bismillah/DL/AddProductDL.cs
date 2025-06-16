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
                INSERT INTO products (name, category_id, supplier_id, batch_id, size, quantity, purchase_price, selling_price, last_updated)
                VALUES ('{product.Name}', {product.CategoryId}, {product.SupplierId}, {product.BatchId}, '{product.Size}', {product.Quantity}, {product.PurchasePrice}, {product.SellingPrice}, '{product.LastUpdated:yyyy-MM-dd HH:mm:ss}')";

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

        public static DataTable GetBatches()
        {
            string query = "SELECT batch_id, arrival_date FROM batch";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}


