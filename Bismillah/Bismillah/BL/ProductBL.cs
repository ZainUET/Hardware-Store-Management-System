using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class ProductBL
    {
        public static string ValidateProduct(Product p)
        {
            if (string.IsNullOrWhiteSpace(p.Name)) return "Product name is required.";
            if (p.CategoryId <= 0) return "Select a valid category.";
            if (p.SupplierId <= 0) return "Select a valid supplier.";
            if (p.BatchId <= 0) return "Select a valid batch.";
            if (string.IsNullOrWhiteSpace(p.Size)) return "Size is required.";
            if (p.Quantity < 0) return "Quantity must be non-negative.";
            if (p.PurchasePrice < 0) return "Purchase price must be non-negative.";
            if (p.SellingPrice < 0) return "Selling price must be non-negative.";
            return "";
        }
    }
}
