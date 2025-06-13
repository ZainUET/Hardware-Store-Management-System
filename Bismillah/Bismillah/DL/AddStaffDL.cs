using Bismillah.BL;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Bismillah.DL
{
    public static class AddStaffDL
    {
        public static DataTable GetRolesFromLookup()
        {
            string query = "SELECT lookup_id, value FROM lookup WHERE category = 'User Role'";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static bool SaveStaff(StaffBL staff)
        {
            string query = @"
                INSERT INTO staff (name, contact, salary, cnic, password, role_id)
                VALUES (@name, @contact, @salary, @cnic, @password, @role_id)";

            try
            {
                using (var connection = DatabaseHelper.Instance.getConnection())
                {
                    connection.Open();
                    using (var cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", staff.Name);
                        cmd.Parameters.AddWithValue("@contact", staff.Contact);
                        cmd.Parameters.AddWithValue("@salary", staff.Salary);
                        cmd.Parameters.AddWithValue("@cnic", staff.CNIC);
                        cmd.Parameters.AddWithValue("@password", staff.Password);
                        cmd.Parameters.AddWithValue("@role_id", staff.RoleID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicate CNIC
                {
                    throw new Exception("CNIC already exists in the system.");
                }
                throw;
            }
        }
    }
}