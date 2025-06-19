using Bismillah.DL;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using Bismillah.Entities;

namespace Bismillah.DAL
{
    public class AddStaffDL
    {
        private readonly DatabaseHelper dbHelper;

        public AddStaffDL()
        {
            dbHelper = DatabaseHelper.Instance;
        }

        public bool AddStaff(StaffDTO staff)
        {
            string query = @"INSERT INTO staff 
                            (name, contact, salary, cnic, password, role_id) 
                            VALUES 
                            (@Name, @Contact, @Salary, @CNIC, @Password, @RoleID)";

            MySqlParameter[] parameters = {
                new MySqlParameter("@Name", staff.Name),
                new MySqlParameter("@Contact", staff.Contact),
                new MySqlParameter("@Salary", staff.Salary),
                new MySqlParameter("@CNIC", staff.CNIC),
                new MySqlParameter("@Password", staff.Password),
                new MySqlParameter("@RoleID", staff.RoleID)
            };

            int rowsAffected = dbHelper.Update(query, parameters);
            return rowsAffected > 0;
        }

        public DataTable GetRoles()
        {
            string query = @"SELECT lookup_id, value 
                    FROM lookup 
                    WHERE category = 'User Role'";

            DataTable roles = dbHelper.GetDataTable(query);

            // Debug output to verify data
            Console.WriteLine($"Retrieved {roles.Rows.Count} roles");
            foreach (DataRow row in roles.Rows)
            {
                Console.WriteLine($"ID: {row["lookup_id"]}, Value: {row["value"]}");
            }

            return roles;
        }

        public bool IsCNICAlreadyExists(string cnic)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE cnic = @CNIC";
            MySqlParameter parameter = new MySqlParameter("@CNIC", cnic);
            object result = dbHelper.ExecuteScalar(query, parameter);
            return Convert.ToInt32(result) > 0;
        }
    }
}