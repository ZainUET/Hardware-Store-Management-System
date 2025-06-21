using Bismillah.DL;
using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class BorrowedBL
    {
        public static string ValidateBorrowed(Borrowed b)
        {
            if (b.CustomerId <= 0) return "Customer selection is required.";
            if (b.ProductId <= 0) return "Product selection is required.";
            if (b.BatchId <= 0) return "Batch selection is required.";
            if (b.Quantity <= 0) return "Quantity must be greater than 0.";
            if (b.UnitPrice <= 0) return "Unit price must be greater than 0.";
            return string.Empty;
        }

    }
}