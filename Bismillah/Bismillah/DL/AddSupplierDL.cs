using Bismillah.Entities;
using MySql.Data.MySqlClient;
using System;

namespace Bismillah.DL
{
    internal class AddSupplierDL
    {
        public static bool AddSupplier(Supplier supplier)
        {
            string query = $@"
                INSERT INTO supplier (name, contact, cnic, address, company)
                VALUES ('{supplier.Name}', '{supplier.Contact}', '{supplier.CNIC}', '{supplier.Address}', '{supplier.Company}')";

            try
            {
                return DatabaseHelper.Instance.Update(query) > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    throw new Exception("Duplicate CNIC or contact found.");
                throw;
            }
        }
    }
}
