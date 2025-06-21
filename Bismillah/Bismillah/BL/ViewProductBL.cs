using Bismillah.DL;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.BL
{
    public class ViewProductBL
    {
        private readonly ViewProductDL _productDL;

        public ViewProductBL()
        {
            _productDL = new ViewProductDL();
        }

        public DataTable GetAllProducts()
        {
            return _productDL.LoadAllProducts();
        }

        public DataTable GetProductsByCategory(int categoryId)
        {
            if (categoryId <= 0)
                return GetAllProducts();

            return _productDL.LoadProductsByCategory(categoryId);
        }

        public DataTable SearchProducts(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return GetAllProducts();

            return _productDL.SearchProducts(searchTerm);
        }

        public DataTable GetProductCategories()
        {
            return _productDL.LoadProductCategories();
        }

        public bool UpdateProduct(int productId, string name, int categoryId, string size, decimal unitPrice)
        {
            if (productId <= 0 || string.IsNullOrWhiteSpace(name) || categoryId <= 0 || unitPrice <= 0)
                return false;

            string query = @"
                UPDATE products 
                SET name = @name, 
                    category_id = @categoryId, 
                    size = @size, 
                    unit_price = @unitPrice,
                    last_updated = NOW()
                WHERE product_id = @productId";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@name", name),
                new MySqlParameter("@categoryId", categoryId),
                new MySqlParameter("@size", size ?? (object)DBNull.Value),
                new MySqlParameter("@unitPrice", unitPrice),
                new MySqlParameter("@productId", productId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public bool DeleteProduct(int productId)
        {
            if (productId <= 0)
                return false;

            string query = "DELETE FROM products WHERE product_id = @productId";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@productId", productId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }
    }
}