using Bismillah.DL;
using Bismillah.Entities;
using Bismillah.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class CustomerBL
    {
        public static string ValidateForEdit(Customer customer)
        {
            if (customer == null || customer.CustomerId <= 0)
                return "Invalid customer.";

            if (string.IsNullOrWhiteSpace(customer.Name))
                return "Name is required.";

            if (string.IsNullOrWhiteSpace(customer.Contact) || customer.Contact.Length != 11 || !customer.Contact.All(char.IsDigit))
                return "Contact must be exactly 11 numeric digits.";

            if (CustomerDL.IsContactDuplicate(customer.Contact, customer.CustomerId))
                return "This contact number is already used by another customer.";

            if (string.IsNullOrWhiteSpace(customer.CNIC) || customer.CNIC.Length != 13 || !customer.CNIC.All(char.IsDigit))
                return "CNIC must be exactly 13 numeric digits.";

            if (CustomerDL.IsCnicDuplicate(customer.CNIC, customer.CustomerId))
                return "This CNIC is already used by another customer.";

            if (string.IsNullOrWhiteSpace(customer.Address))
                return "Address is required.";

            return string.Empty;
        }

        public DataTable GetAllCustomers()
        {
            string query = "SELECT customer_id, name FROM customer ORDER BY name";
            return DatabaseHelper.Instance.GetDataTable(query);
        }
    }
}
