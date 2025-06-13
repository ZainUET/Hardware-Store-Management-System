using System;
using System.Data;
using Bismillah.DL;

namespace Bismillah.BL
{
    public class frmBillingBL
    {
        private readonly frmBillingDL _dataLayer;

        public frmBillingBL()
        {
            _dataLayer = new frmBillingDL();
        }

        public DataTable SearchProducts(string searchTerm = "")
        {
            return _dataLayer.GetProducts(searchTerm);
        }

        public DataTable GetAllAvailableProducts()
        {
            return _dataLayer.GetProducts();
        }

        public DataTable GetCustomers(bool regularOnly = false)
        {
            return _dataLayer.GetCustomers(regularOnly);
        }

        public DataRow GetCustomerDetails(int customerId)
        {
            return _dataLayer.GetCustomerById(customerId);
        }

        public DataTable GetPaymentStatuses()
        {
            return _dataLayer.GetPaymentStatuses();
        }

        public int ProcessBill(int? customerId, int staffId, DateTime billDate, decimal subTotal,
                             decimal discount, decimal taxRate, int? paymentStatusId, DataTable billItems)
        {
            // Apply discount for regular customers
            if (customerId.HasValue)
            {
                var customer = _dataLayer.GetCustomerById(customerId.Value);
                if (customer != null && Convert.ToBoolean(customer["is_regular"]))
                {
                    discount = Math.Min(discount + 5, 25); // Additional 5% discount for regulars (max 25%)
                }
            }

            // Calculate tax and total
            decimal taxAmount = subTotal * taxRate;
            decimal totalAmount = subTotal - discount + taxAmount;

            // Save bill
            int billId = _dataLayer.SaveBill(customerId, staffId, billDate, totalAmount,
                                           discount, taxAmount, paymentStatusId);

            // Save bill items and update stock
            foreach (DataRow row in billItems.Rows)
            {
                int productId = Convert.ToInt32(row["ProductID"]);
                int quantity = Convert.ToInt32(row["Quantity"]);
                decimal unitPrice = Convert.ToDecimal(row["UnitPrice"]);
                int? batchId = row["BatchID"] != DBNull.Value ? Convert.ToInt32(row["BatchID"]) : (int?)null;

                _dataLayer.SaveBillItem(billId, productId, quantity, unitPrice, batchId);

                if (batchId.HasValue)
                {
                    _dataLayer.UpdateStock(productId, batchId.Value, quantity);
                }
            }

            // Update customer loyalty points (1 point per 100 spent)
            if (customerId.HasValue)
            {
                int pointsToAdd = (int)(totalAmount / 100);
                _dataLayer.UpdateCustomerLoyaltyPoints(customerId.Value, pointsToAdd);
            }

            return billId;
        }

        public decimal CalculateSubTotal(DataTable billItems)
        {
            decimal subTotal = 0;
            foreach (DataRow row in billItems.Rows)
            {
                subTotal += Convert.ToInt32(row["Quantity"]) * Convert.ToDecimal(row["UnitPrice"]);
            }
            return subTotal;
        }
    }
}