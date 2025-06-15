using Bismillah.Entities;
using Bismillah.DL;

namespace Bismillah.BL
{
    public class StaffEditBL
    {
        public static string ValidateForEdit(Staff staff)
        {
            if (staff == null || staff.StaffId <= 0)
                return "Invalid staff selection.";

            if (string.IsNullOrWhiteSpace(staff.Name))
                return "Name is required.";

            if (string.IsNullOrWhiteSpace(staff.Contact) || staff.Contact.Length != 11)
                return "Contact must be 11 digits.";

            if (string.IsNullOrWhiteSpace(staff.CNIC) || staff.CNIC.Length != 13)
                return "CNIC must be 13 digits.";

            if (staff.Salary <= 0)
                return "Salary must be greater than zero.";

            if (string.IsNullOrWhiteSpace(staff.Password))
                return "Password is required.";

            if (StaffDL.ContactExists(staff.Contact, staff.StaffId))
                return "This contact number already exists.";

            if (StaffDL.CNICExists(staff.CNIC, staff.StaffId))
                return "This CNIC already exists.";

            return string.Empty;
        }

        public static string ValidateForDelete(Staff staff)
        {
            if (staff == null || staff.StaffId <= 0)
                return "Invalid staff selected for deletion.";
            return string.Empty;
        }
    }
}

