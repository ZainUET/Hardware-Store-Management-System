using Bismillah.DL;
using Bismillah.Entities;

namespace Bismillah.BL
{
    internal class BorrowedBL
    {
        public static string ValidateBorrowed(Borrowed b)
        {
            if (b.CustomerId <= 0) return "Customer selection is required.";
            if (b.ProductId <= 0) return "Product selection is required.";
            if (b.Quantity <= 0) return "Quantity must be greater than 0.";
            if (b.UnitPrice <= 0) return "Unit price must be greater than 0.";

            int availableStock = BorrowedDL.GetProductStock(b.ProductId);
            if (b.Quantity > availableStock)
                return $"Insufficient stock. Only {availableStock} unit(s) available.";

            return string.Empty;
        }
    }
}
