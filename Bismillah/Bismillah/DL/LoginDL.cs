using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bismillah.DL
{
    internal class LoginDL
    {
        public Entities.Login Authenticate(string cnic, string password)
        {
           

            string query = $@"
             SELECT * FROM staff 
             WHERE TRIM(cnic) = '{cnic}' AND TRIM(password) = '{password}'";

            DataTable dt = DatabaseHelper.Instance.GetDataTable(query);

            if (dt.Rows.Count == 1)
            {
               

                var row = dt.Rows[0];
                return new Entities.Login
                {
                    StaffId = Convert.ToInt32(row["staff_id"]),
                    Name = row["name"].ToString(),
                    CNIC = row["cnic"].ToString(),
                    Password = row["password"].ToString(),
                    RoleId = Convert.ToInt32(row["role_id"])
                };
            }
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No match found in staff table for this CNIC and Password.");
            }


            return null;
        }
    }
}

