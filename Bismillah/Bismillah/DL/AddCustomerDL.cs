using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bismillah.Entities;

namespace Bismillah.DL
{
    internal class AddCustomerDL
    {
        public static bool AddCustomer(Customer customer)
        {
            string query = $@"
        INSERT INTO customer (name, contact, cnic, address, loyalty_points, is_regular)
        VALUES ('{customer.Name}', '{customer.Contact}', '{customer.CNIC}', '{customer.Address}', {customer.LoyaltyPoints}, {(customer.IsRegular ? 1 : 0)})";

            try
            {
                return DatabaseHelper.Instance.Update(query) > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    throw new Exception("This CNIC already exists.");
                else
                    throw new Exception("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error: " + ex.Message);
            }
        }
    }
}

