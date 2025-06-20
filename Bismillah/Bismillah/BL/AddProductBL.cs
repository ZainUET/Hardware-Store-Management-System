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
            if (string.IsNullOrWhiteSpace(product.Size)) return "Size is required.";
            if (product.QuantityInStock < 0) return "Quantity must be 0 or more.";
            if (product.UnitPrice < 0) return "Unit price must be 0 or more.";
            return string.Empty;
        }
    }
}
