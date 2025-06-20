
namespace Bismillah.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public string Size { get; set; }
        public int QuantityInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}