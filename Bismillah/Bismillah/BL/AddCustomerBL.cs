using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.Entities;

namespace Bismillah.BL
{
    internal class AddCustomerBL
    {
        public static string ValidateCustomer(Customer customer)
        {
            if (string.IsNullOrWhiteSpace(customer.Name))
                return "Name is required.";

            if (string.IsNullOrWhiteSpace(customer.Contact) || customer.Contact.Length != 11)
                return "Contact must be 11 digits.";

            if (string.IsNullOrWhiteSpace(customer.CNIC) || customer.CNIC.Length != 13)
                return "CNIC must be 13 digits.";

            if (string.IsNullOrWhiteSpace(customer.Address))
                return "Address is required.";

            if (customer.LoyaltyPoints < 0)
                return "Loyalty points cannot be negative.";

            return string.Empty;
        }
    }
}


