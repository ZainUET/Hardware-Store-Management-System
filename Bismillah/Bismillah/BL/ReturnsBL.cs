using Bismillah.DL;
using System;
using System.Data;

namespace Bismillah.BL
{
    public class ReturnsBL
    {
        private readonly ReturnsDL returnsDL;

        public ReturnsBL()
        {
            returnsDL = new ReturnsDL();
        }

        public DataTable LoadCustomers()
        {
            return returnsDL.GetCustomers();
        }

        public DataTable SearchCustomerProducts(int customerId, string searchTerm)
        {
            return returnsDL.SearchCustomerPurchases(customerId, searchTerm);
        }

        public bool ProcessCustomerReturn(int customerId, DataTable returnItems)
        {
            if (returnItems.Rows.Count == 0)
                throw new Exception("No items to return");

            return returnsDL.ProcessReturn(customerId, returnItems);
        }

        public DataTable GetReturnHistory(int customerId = 0)
        {
            return returnsDL.GetReturnHistory(customerId);
        }

        public decimal CalculateRefund(DataTable returnItems)
        {
            decimal totalRefund = 0;
            foreach (DataRow row in returnItems.Rows)
            {
                decimal price = Convert.ToDecimal(row["unit_price"]);
                int quantity = Convert.ToInt32(row["quantity"]);
                totalRefund += price * quantity;
            }
            return totalRefund;
        }
    }
}