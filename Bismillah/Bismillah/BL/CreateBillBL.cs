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

            // Add formatted price column
            if (!products.Columns.Contains("formatted_price"))
            {
                products.Columns.Add("formatted_price", typeof(string));
            }

            foreach (DataRow row in products.Rows)
            {
                decimal price = Convert.ToDecimal(row["selling_price"]);
                row["formatted_price"] = DatabaseHelper.FormatAsPKR(price);
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
            if (row == null) return (string.Empty, "Rs. 0.00");

            return (
                row["cnic"].ToString(),
                DatabaseHelper.FormatAsPKR(Convert.ToDecimal(row["loyalty_points"]))
            );
        }

        public int ProcessBill(int? customerId, int staffId, decimal discountAmount,
                     DataTable billItems, int paymentStatusId, out string formattedTotalAmount)
        {
            // Calculate subtotal
            decimal subtotal = billItems.AsEnumerable()
                .Sum(row => Convert.ToDecimal(row["total"]));

            // Calculate total amount (subtotal - discount)
            decimal totalAmount = subtotal - discountAmount;

            // Create bill header with total amount
            int billId = _billDL.CreateBill(customerId, staffId, discountAmount, totalAmount, paymentStatusId);

            // Add bill items
            foreach (DataRow row in billItems.Rows)
            {
                int productId = Convert.ToInt32(row["product_id"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                decimal unitPrice = Convert.ToDecimal(row["unit_price"]);
                int? batchId = row["batch_id"] != DBNull.Value ?
                               Convert.ToInt32(row["batch_id"]) : (int?)null;

                _billDL.AddBillItem(billId, productId, quantity, unitPrice, batchId);
            }

            formattedTotalAmount = DatabaseHelper.FormatAsPKR(totalAmount);
            return billId;
        }
        public string GetFormattedPrice(decimal amount)
        {
            return DatabaseHelper.FormatAsPKR(amount);
        }


        public bool FinalizePayment(int billId, int newPaymentStatusId)
        {
            try
            {
                // Get current payment status with parameterized query
                string statusQuery = @"SELECT l.value 
                             FROM bill_quotation b
                             JOIN lookup l ON b.payment_status_id = l.lookup_id
                             WHERE b.bill_id = @billId";

                MySqlParameter[] parameters = {
            new MySqlParameter("@billId", billId)
        };

                object statusResult = DatabaseHelper.Instance.ExecuteScalar(statusQuery, parameters);

                if (statusResult == null || statusResult == DBNull.Value)
                {
                    throw new Exception("Bill not found or has no payment status");
                }

                string currentStatus = statusResult.ToString();

                // Get status names safely
                string completedStatus = GetStatusValue("Completed");
                string pendingStatus = GetStatusValue("Pending");

                // Update payment status
                bool statusUpdated = _billDL.UpdatePaymentStatus(billId, newPaymentStatusId);

                if (!statusUpdated)
                {
                    return false;
                }

                // Handle stock adjustments
                string newStatus = GetStatusValue(newPaymentStatusId);

                if (currentStatus == pendingStatus && newStatus == completedStatus)
                {
                    // Decrease stock when moving from Pending to Completed
                    return _billDL.AdjustStockForBill(billId, false);
                }
                else if (currentStatus == completedStatus && newStatus == "Failed")
                {
                    // Increase stock when moving from Completed to Failed
                    return _billDL.AdjustStockForBill(billId, true);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Log the error (you could add logging here)
                throw new Exception($"Error finalizing payment: {ex.Message}");
            }
        }

        private string GetStatusValue(string statusName)
        {
            string query = @"SELECT value FROM lookup 
                   WHERE category = 'Payment Status' AND value = @statusName";

            MySqlParameter[] parameters = {
        new MySqlParameter("@statusName", statusName)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result?.ToString();
        }

        private string GetStatusValue(int statusId)
        {
            string query = @"SELECT value FROM lookup 
                   WHERE lookup_id = @statusId";

            MySqlParameter[] parameters = {
        new MySqlParameter("@statusId", statusId)
    };

            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return result?.ToString();
        }
        



    }
}