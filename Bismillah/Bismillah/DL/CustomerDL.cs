using Bismillah.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            string query = "SELECT * FROM customer WHERE customer_id = @id";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@id", id)
            };

            var dt = DatabaseHelper.Instance.GetDataTable(query, parameters);
            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new Customer
            {
                CustomerId = Convert.ToInt32(row["customer_id"]),
                Name = row["name"].ToString(),
                Contact = row["contact"].ToString(),
                CNIC = row["cnic"].ToString(),
                Address = row["address"].ToString()
            };
        }

        public static bool UpdateCustomer(Customer customer)
        {
            string query = @"
                UPDATE customer SET 
                    name = @name, 
                    contact = @contact, 
                    cnic = @cnic, 
                    address = @address
                WHERE customer_id = @customerId";

            var parameters = new MySqlParameter[] {
                new MySqlParameter("@name", customer.Name),
                new MySqlParameter("@contact", customer.Contact),
                new MySqlParameter("@cnic", customer.CNIC),
                new MySqlParameter("@address", customer.Address),
                new MySqlParameter("@customerId", customer.CustomerId)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static List<DependencyRecord> CheckCustomerDependencies(int customerId)
        {
            var dependencies = new List<DependencyRecord>();

            // Tables that reference customer_id with their friendly names
            var referenceTables = new Dictionary<string, string>
            {
                {"bill_quotation", "Bills/Quotations"},
                {"customer_returns_products", "Product Returns"},
                {"borrowed", "Borrowed Products"},
                {"payments", "Payments"}
            };

            foreach (var table in referenceTables)
            {
                string query = $"SELECT COUNT(*) FROM {table.Key} WHERE customer_id = @customerId";
                var count = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query,
                    new MySqlParameter("@customerId", customerId)));

                if (count > 0)
                {
                    dependencies.Add(new DependencyRecord
                    {
                        TableName = table.Value,
                        RecordCount = count
                    });
                }
            }

            return dependencies;
        }

        public static bool DeleteCustomer(int id)
        {
            // First check for dependencies
            var dependencies = CheckCustomerDependencies(id);
            if (dependencies.Any())
            {
                throw new InvalidOperationException(
                    "Customer cannot be deleted because they have associated records in other tables.");
            }

            string query = "DELETE FROM customer WHERE customer_id = @id";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@id", id)
            };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static bool IsContactDuplicate(string contact, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM customer WHERE contact = @contact AND customer_id <> @excludeId";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@contact", contact),
                new MySqlParameter("@excludeId", excludeId)
            };
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }

        public static bool IsCnicDuplicate(string cnic, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM customer WHERE cnic = @cnic AND customer_id <> @excludeId";
            var parameters = new MySqlParameter[] {
                new MySqlParameter("@cnic", cnic),
                new MySqlParameter("@excludeId", excludeId)
            };
            return Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(query, parameters)) > 0;
        }
    }
}