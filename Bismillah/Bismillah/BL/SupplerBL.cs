using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class SupplerBL
    {

        public static string ValidateForDelete(Supplier supplier)
        {
            if (supplier == null || supplier.SupplierId <= 0)
                return "No supplier selected for deletion.";
            return string.Empty;
        }

        public static string ValidateForEdit(Supplier supplier)
        {
            if (supplier == null || supplier.SupplierId <= 0)
                return "No supplier selected for update.";

            if (string.IsNullOrWhiteSpace(supplier.Name))
                return "Name is required.";

            if (string.IsNullOrWhiteSpace(supplier.Contact) || supplier.Contact.Length != 11 || !supplier.Contact.All(char.IsDigit))
                return "Contact must be exactly 11 numeric digits.";

            if (SupplierDL.IsContactDuplicate(supplier.Contact, supplier.SupplierId))
                return "This contact number is already used by another supplier.";

            if (string.IsNullOrWhiteSpace(supplier.CNIC) || supplier.CNIC.Length != 13 || !supplier.CNIC.All(char.IsDigit))
                return "CNIC must be exactly 13 numeric digits.";

            if (SupplierDL.IsCnicDuplicate(supplier.CNIC, supplier.SupplierId))
                return "This CNIC is already used by another supplier.";

            if (string.IsNullOrWhiteSpace(supplier.Address))
                return "Address is required.";

            if (string.IsNullOrWhiteSpace(supplier.Company))
                return "Company is required.";

            return string.Empty;
        }
    }
}
