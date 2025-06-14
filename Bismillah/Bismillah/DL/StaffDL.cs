using Bismillah.Entities;
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
            string query = $"SELECT * FROM staff WHERE staff_id = {staffId}";
            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

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
            string query = $@"
                UPDATE staff SET 
                    name = '{staff.Name}', 
                    contact = '{staff.Contact}', 
                    cnic = '{staff.CNIC}', 
                    salary = {staff.Salary}, 
                    password = '{staff.Password}'
                WHERE staff_id = {staff.StaffId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool DeleteStaff(int staffId)
        {
            string query = $"DELETE FROM staff WHERE staff_id = {staffId}";
            return DatabaseHelper.Instance.Update(query) > 0;
        }

        public static bool ContactExists(string contact, int excludeId = 0)
        {
            string query = $"SELECT COUNT(*) FROM staff WHERE contact = '{contact}' AND staff_id != {excludeId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }

        public static bool CNICExists(string cnic, int excludeId = 0)
        {
            string query = $"SELECT COUNT(*) FROM staff WHERE cnic = '{cnic}' AND staff_id != {excludeId}";
            return DatabaseHelper.Instance.Scaler(query) > 0;
        }
    }
}
