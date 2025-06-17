//using Bismillah.DL;
//using MySql.Data.MySqlClient;
//using System.Data;

//namespace Bismillah.BL
//{
//    public class CreateBillBL
//    {
//        private readonly CreateBillDL _billDL;

//        public CreateBillBL()
//        {
//            _billDL = new CreateBillDL();
//        }

//        public DataTable LoadCustomers()
//        {
//            return _billDL.GetCustomers();
//        }

//        public DataTable LoadProducts()
//        {
//            var products = _billDL.GetProducts();

//            // Add formatted price column
//            if (!products.Columns.Contains("formatted_price"))
//            {
//                products.Columns.Add("formatted_price", typeof(string));
//            }

//            foreach (DataRow row in products.Rows)
//            {
//                decimal price = Convert.ToDecimal(row["selling_price"]);
//                row["formatted_price"] = DatabaseHelper.FormatAsPKR(price);
//            }
//            return products;
//        }

//        public DataTable LoadPaymentStatuses()
//        {
//            return _billDL.GetPaymentStatuses();
//        }

//        public (string cnic, string loyaltyPoints) GetCustomerInfo(int customerId)
//        {
//            var row = _billDL.GetCustomerDetails(customerId);
//            if (row == null) return (string.Empty, "Rs. 0.00");

//            return (
//                row["cnic"].ToString(),
//                DatabaseHelper.FormatAsPKR(Convert.ToDecimal(row["loyalty_points"]))
//            );
//        }

//        public int ProcessBill(int? customerId, int staffId, decimal discountAmount,
//                     DataTable billItems, int paymentStatusId, out string formattedTotalAmount)
//        {
//            // Calculate subtotal
//            decimal subtotal = billItems.AsEnumerable()
//                .Sum(row => Convert.ToDecimal(row["total"]));

//            // Calculate total amount (subtotal - discount)
//            decimal totalAmount = subtotal - discountAmount;

//            // Create bill header with total amount
//            int billId = _billDL.CreateBill(customerId, staffId, discountAmount, totalAmount, paymentStatusId);

//            // Add bill items
//            foreach (DataRow row in billItems.Rows)
//            {
//                int productId = Convert.ToInt32(row["product_id"]);
//                int quantity = Convert.ToInt32(row["quantity"]);
//                decimal unitPrice = Convert.ToDecimal(row["unit_price"]);
//                int? batchId = row["batch_id"] != DBNull.Value ?
//                               Convert.ToInt32(row["batch_id"]) : (int?)null;

//                _billDL.AddBillItem(billId, productId, quantity, unitPrice, batchId);
//            }

//            formattedTotalAmount = DatabaseHelper.FormatAsPKR(totalAmount);
//            return billId;
//        }
//        public string GetFormattedPrice(decimal amount)
//        {
//            return DatabaseHelper.FormatAsPKR(amount);
//        }

//        public bool FinalizePayment(int billId, int newPaymentStatusId)
//        {
//            try
//            {
//                // Get current payment status
//                string currentStatus = GetCurrentPaymentStatus(billId);
//                string newStatus = GetStatusValue(newPaymentStatusId);

//                // Update payment status
//                bool statusUpdated = _billDL.UpdatePaymentStatus(billId, newPaymentStatusId);

//                if (!statusUpdated) return false;

//                // Handle stock adjustments
//                if (currentStatus == "Pending" && newStatus == "Completed")
//                {
//                    // Decrease stock when moving from Pending to Completed
//                    return _billDL.AdjustStockForBill(billId, false);
//                }
//                else if (currentStatus == "Completed" && newStatus == "Failed")
//                {
//                    // Increase stock when moving from Completed to Failed
//                    return _billDL.AdjustStockForBill(billId, true);
//                }

//                return true;
//            }
//            catch (Exception ex)
//            {
//                throw new Exception($"Error finalizing payment: {ex.Message}");
//            }
//        }

//        private string GetCurrentPaymentStatus(int billId)
//        {
//            string query = @"SELECT l.value FROM bill_quotation b
//                   JOIN lookup l ON b.payment_status_id = l.lookup_id
//                   WHERE b.bill_id = @billId";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@billId", billId)
//    };

//            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
//            return result?.ToString();
//        }

//        public bool HasSufficientStock(int productId, int quantity)
//        {
//            string query = @"SELECT COALESCE(SUM(quantity_in_stock), 0) 
//                     FROM stock 
//                     WHERE product_id = @productId";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@productId", productId)
//    };

//            int currentStock = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters));
//            return currentStock >= quantity;
//        }


//        private string GetStatusValue(string statusName)
//        {
//            string query = @"SELECT value FROM lookup 
//                   WHERE category = 'Payment Status' AND value = @statusName";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@statusName", statusName)
//    };

//            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
//            return result?.ToString();
//        }

//        private string GetStatusValue(int statusId)
//        {
//            string query = @"SELECT value FROM lookup 
//                   WHERE lookup_id = @statusId";

//            MySqlParameter[] parameters = {
//        new MySqlParameter("@statusId", statusId)
//    };

//            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
//            return result?.ToString();
//        }




//    }
//}




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
            var products = _billDL.GetProducts();
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

        public (string cnic, string loyaltyPoints) GetCustomerInfo(int customerId)
        {
            var row = _billDL.GetCustomerDetails(customerId);
            if (row == null) return (string.Empty, "0");

            return (
                row["cnic"].ToString(),
                row["loyalty_points"].ToString()
            );
        }

        public bool HasSufficientStock(int productId, int quantity)
        {
            return _billDL.HasSufficientStock(productId, quantity);
        }

        public int ProcessBill(int? customerId, int staffId, decimal discountAmount,
                     DataTable billItems, int paymentStatusId, out string formattedTotalAmount)
        {
            decimal subtotal = billItems.AsEnumerable()
                .Sum(row => Convert.ToDecimal(row["total"]));

            decimal totalAmount = subtotal - discountAmount;

            int billId = _billDL.CreateBill(customerId, staffId, discountAmount, totalAmount, paymentStatusId);

            foreach (DataRow row in billItems.Rows)
            {
                _billDL.AddBillItem(
                    billId,
                    Convert.ToInt32(row["product_id"]),
                    Convert.ToInt32(row["quantity"]),
                    Convert.ToDecimal(row["unit_price"]),
                    row["batch_id"] != DBNull.Value ? (int?)Convert.ToInt32(row["batch_id"]) : null
                );
            }

            formattedTotalAmount = DatabaseHelper.FormatAsPKR(totalAmount);
            return billId;
        }

        public bool FinalizePayment(int billId, int newPaymentStatusId)
        {
            return _billDL.FinalizePayment(billId, newPaymentStatusId);
        }
    }
}