using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class CustomerDL
    {
        public static DataTable GetAllCustomers()
        {
            string query = "SELECT * FROM customer";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static Customer GetCustomerById(int id)
        {
            string query = $"SELECT * FROM customer WHERE customer_id = {id}";
            var dt = DatabaseHelper.Instance.GetDataTable(query);
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new Customer
            {
                CustomerId = Convert.ToInt32(row["customer_id"]),
                Name = row["name"].ToString(),
                Contact = row["contact"].ToString(),
                CNIC = row["cnic"].ToString(),
                Address = row["address"].ToString(),
                LoyaltyPoints = Convert.ToInt32(row["loyalty_points"]),
                IsRegular = row["is_regular"].ToString().ToLower() == "yes"
            };
        }

        public static bool UpdateCustomer(Customer customer)
        {
            string query = $@"
                UPDATE customer SET 
                    name = '{customer.Name}', 
                    contact = '{customer.Contact}', 
                    cnic = '{customer.CNIC}', 
                    address = '{customer.Address}', 
                    loyalty_points = {customer.LoyaltyPoints},
                    is_regular = '{(customer.IsRegular ? "Yes" : "No")}'
                WHERE customer_id = {customer.CustomerId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool DeleteCustomer(int id)
        {
            string query = $"DELETE FROM customer WHERE customer_id = {id}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool IsContactDuplicate(string contact, int excludeId = 0)
        {
            string query = $"SELECT COUNT(*) FROM customer WHERE contact = '{contact}' AND customer_id <> {excludeId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }

        public static bool IsCnicDuplicate(string cnic, int excludeId = 0)
        {
            string query = $"SELECT COUNT(*) FROM customer WHERE cnic = '{cnic}' AND customer_id <> {excludeId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }
    }
}

