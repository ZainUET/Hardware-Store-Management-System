using System.Data;
using MySql.Data.MySqlClient;

namespace Bismillah.DL
{
    public class ViewProductDL
    {
        public DataTable LoadAllProducts()
        {
            string query = @"
                SELECT 
                    p.product_id AS 'ID',
                    p.name AS 'Product Name',
                    l.value AS 'Category',
                    p.size AS 'Size',
                    p.unit_price AS 'Unit Price',
                    p.quantity_in_stock AS 'Stock'
                FROM products p
                JOIN lookup l ON p.category_id = l.lookup_id
                ORDER BY p.name";

            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public DataTable LoadProductsByCategory(int categoryId)
        {
            string query = @"
                SELECT 
                    p.product_id AS 'ID',
                    p.name AS 'Product Name',
                    l.value AS 'Category',
                    p.size AS 'Size',
                    p.unit_price AS 'Unit Price',
                    p.quantity_in_stock AS 'Stock'
                FROM products p
                JOIN lookup l ON p.category_id = l.lookup_id
                WHERE p.category_id = @categoryId
                ORDER BY p.name";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@categoryId", categoryId)
            };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }

        public DataTable SearchProducts(string searchTerm)
        {
            string query = @"
                SELECT 
                    p.product_id AS 'ID',
                    p.name AS 'Product Name',
                    l.value AS 'Category',
                    p.size AS 'Size',
                    p.unit_price AS 'Unit Price',
                    p.quantity_in_stock AS 'Stock'
                FROM products p
                JOIN lookup l ON p.category_id = l.lookup_id
                WHERE p.name LIKE @searchTerm OR l.value LIKE @searchTerm
                ORDER BY p.name";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };

            return DatabaseHelper.Instance.GetDataTable(query, parameters);
        }

        public DataTable LoadProductCategories()
        {
            string query = "SELECT lookup_id, value FROM lookup WHERE category = 'Product Category'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}