using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class AddSupplierBL
    {
        public static string ValidateSupplier(Supplier supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.Name))
                return "Name is required.";

            if (string.IsNullOrWhiteSpace(supplier.Contact) || supplier.Contact.Length != 11 || !supplier.Contact.All(char.IsDigit))
                return "Contact must be exactly 11 numeric digits.";

            if (SupplierDL.IsContactDuplicate(supplier.Contact))
                return "This contact number is already used by another supplier.";

            if (string.IsNullOrWhiteSpace(supplier.CNIC) || supplier.CNIC.Length != 13 || !supplier.CNIC.All(char.IsDigit))
                return "CNIC must be exactly 13 numeric digits.";

            if (SupplierDL.IsCnicDuplicate(supplier.CNIC))
                return "This CNIC is already used by another supplier.";

            if (string.IsNullOrWhiteSpace(supplier.Company))
                return "Company is required.";

            return string.Empty;
        }

       
    }
}
