using Bismillah.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.DL
{
    internal class StaffDL
    {
        public static DataTable GetAllStaff()
        {
            string query = "SELECT * FROM staff";
            return DatabaseHelper.Instance.GetDataTable(query);
        }

        public static Staff GetStaffById(int staffId)
        {
            string query = "SELECT * FROM staff WHERE staff_id = @staffId";
            var parameters = new MySqlParameter[] {
            new MySqlParameter("@staffId", staffId)
        };

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query, parameters);

            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Staff
            {
                StaffId = Convert.ToInt32(row["staff_id"]),
                Name = row["name"].ToString(),
                Contact = row["contact"].ToString(),
                CNIC = row["cnic"].ToString(),
                Salary = Convert.ToDecimal(row["salary"]),
                Password = row["password"].ToString(),
                RoleID = Convert.ToInt32(row["role_id"])
            };
        }

        public static bool UpdateStaff(Staff staff)
        {
            string query = @"
            UPDATE staff SET 
                name = @name, 
                contact = @contact, 
                cnic = @cnic, 
                salary = @salary, 
                password = @password
            WHERE staff_id = @staffId";

            var parameters = new MySqlParameter[] {
            new MySqlParameter("@name", staff.Name),
            new MySqlParameter("@contact", staff.Contact),
            new MySqlParameter("@cnic", staff.CNIC),
            new MySqlParameter("@salary", staff.Salary),
            new MySqlParameter("@password", staff.Password),
            new MySqlParameter("@staffId", staff.StaffId)
        };

            return DatabaseHelper.Instance.Update(query, parameters) > 0;
        }

        public static bool ContactExists(string contact, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE contact = @contact AND staff_id != @excludeId";
            var parameters = new MySqlParameter[] {
            new MySqlParameter("@contact", contact),
            new MySqlParameter("@excludeId", excludeId)
        };
            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        public static bool CNICExists(string cnic, int excludeId = 0)
        {
            string query = "SELECT COUNT(*) FROM staff WHERE cnic = @cnic AND staff_id != @excludeId";
            var parameters = new MySqlParameter[] {
            new MySqlParameter("@cnic", cnic),
            new MySqlParameter("@excludeId", excludeId)
        };
            object result = DatabaseHelper.Instance.ExecuteScalar(query, parameters);
            return Convert.ToInt32(result) > 0;
        }

        public static List<DependencyRecord> CheckStaffDependencies(int staffId)
        {
            var dependencies = new List<DependencyRecord>();

            try
            {
                // Check bill_quotation table
                string billQuery = "SELECT COUNT(*) FROM bill_quotation WHERE staff_id = @staffId";
                var billParams = new MySqlParameter[] {
                new MySqlParameter("@staffId", staffId)
            };

                var billCount = Convert.ToInt32(DatabaseHelper.Instance.ExecuteScalar(billQuery, billParams));

                if (billCount > 0)
                {
                    dependencies.Add(new DependencyRecord
                    {
                        TableName = "Bills/Quotations",
                        RecordCount = billCount
                    });
                }

                // Add checks for other tables as needed
            }
            catch (Exception ex)
            {
                // Log error
                throw;
            }

            return dependencies;
        }

        public static bool DeleteStaff(int staffId)
        {
            try
            {
                // First check if there are any dependencies
                var dependencies = CheckStaffDependencies(staffId);
                if (dependencies.Any())
                {
                    return false;
                }

                string query = "DELETE FROM staff WHERE staff_id = @staffId";
                var parameters = new MySqlParameter[] {
                new MySqlParameter("@staffId", staffId)
            };

                int rowsAffected = DatabaseHelper.Instance.Update(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                // Log the error
                return false;
            }
        }
    }
}