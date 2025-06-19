using Bismillah.DAL;
using Bismillah.DL;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using Bismillah.Entities;
namespace Bismillah.BL
{
    public class AddStaffBL
    {
        private readonly AddStaffDL staffDL;

        public AddStaffBL()
        {
            staffDL = new AddStaffDL();
        }

        public bool AddStaff(StaffDTO staff)
        {
            ValidateStaffData(staff);

            // Check if CNIC already exists
            if (staffDL.IsCNICAlreadyExists(staff.CNIC))
            {
                throw new ArgumentException("Staff with this CNIC already exists.");
            }

            // Hash the password before storing
            staff.Password = HashPassword(staff.Password);

            return staffDL.AddStaff(staff);
        }

        public DataTable GetRoles()
        {
            return staffDL.GetRoles();
        }

        private void ValidateStaffData(StaffDTO staff)
        {
            if (string.IsNullOrWhiteSpace(staff.Name))
                throw new ArgumentException("Name is required.");

            if (string.IsNullOrWhiteSpace(staff.Contact))
                throw new ArgumentException("Contact is required.");

            if (staff.Salary <= 0)
                throw new ArgumentException("Salary must be greater than 0.");

            if (string.IsNullOrWhiteSpace(staff.CNIC) || staff.CNIC.Length != 13)
                throw new ArgumentException("CNIC must be 13 digits.");

            if (string.IsNullOrWhiteSpace(staff.Password) || staff.Password.Length < 6)
                throw new ArgumentException("Password must be at least 6 characters.");

            if (staff.RoleID <= 0)
                throw new ArgumentException("Role must be selected.");
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}