
namespace Bismillah.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int BatchId { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public DateTime LastUpdated { get; internal set; }
    }
}