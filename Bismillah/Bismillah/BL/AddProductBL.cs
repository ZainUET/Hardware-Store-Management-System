using Bismillah.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.BL
{
    internal class AddProductBL
    {
        public static string ValidateProduct(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Name)) return "Product name is required.";
            if (product.CategoryId <= 0) return "Please select a category.";
            if (product.SupplierId <= 0) return "Please select a supplier.";
            if (product.BatchId <= 0) return "Please select a batch.";
            if (string.IsNullOrWhiteSpace(product.Size)) return "Size is required.";
            if (product.Quantity < 0) return "Quantity cannot be negative.";
            if (product.PurchasePrice < 0) return "Purchase price cannot be negative.";
            if (product.SellingPrice < 0) return "Selling price cannot be negative.";
            return string.Empty;
        }
    }
}
