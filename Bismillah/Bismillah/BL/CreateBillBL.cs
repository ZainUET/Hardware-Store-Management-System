using Bismillah.DL;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bismillah.BL
{
    public class CreateBillBL
    {
        private readonly CreateBillDL _billDL;

        public CreateBillBL()
        {
            _billDL = new CreateBillDL();
        }

        public DataTable LoadCustomers()
        {
            return _billDL.GetCustomers();
        }

        public DataTable LoadProducts()
        {
            var products = _billDL.GetProductsWithStock();

            // Add formatted price column for display
            products.Columns.Add("formatted_price", typeof(string));
            foreach (DataRow row in products.Rows)
            {
                row["formatted_price"] = DatabaseHelper.FormatAsPKR(Convert.ToDecimal(row["unit_price"]));
            }

            return products;
        }

        public DataTable LoadPaymentStatuses()
        {
            return _billDL.GetPaymentStatuses();
        }
        public bool ValidateProductExists(int productId)
        {
            try
            {
                string query = "SELECT COUNT(1) FROM products WHERE product_id = @productId";
                var parameters = new MySqlParameter[] {
            new MySqlParameter("@productId", productId)
        };

                object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);

                // Handle null/DBNull cases
                if (result == null || Convert.IsDBNull(result))
                    return false;

                return Convert.ToInt32(result) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error validating product existence: {ex.Message}", ex);
            }
        }

        public (string cnic, string contact) GetCustomerInfo(int customerId)
        {
            return _billDL.GetCustomerDetails(customerId);
        }

        public bool ValidateProductStock(int productId, int quantity)
        {
            return _billDL.HasSufficientStock(productId, quantity);
        }

        public int ProcessBill(int? customerId, int staffId, decimal discountAmount,
                             DataTable billItems, int paymentStatusId, out string formattedTotal)
        {
            // Calculate subtotal
            decimal subtotal = 0;
            foreach (DataRow row in billItems.Rows)
            {
                subtotal += Convert.ToDecimal(row["quantity"]) * Convert.ToDecimal(row["unit_price"]);
            }

            // Calculate total amount after discount
            decimal totalAmount = subtotal - discountAmount;
            formattedTotal = DatabaseHelper.FormatAsPKR(totalAmount);

            // Process the bill transaction
            return _billDL.CreateBillTransaction(
                customerId,
                staffId,
                discountAmount,
                billItems,
                paymentStatusId
            );
        }
    }
}