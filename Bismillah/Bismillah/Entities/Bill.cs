namespace Bismillah.Entities
{
    public class Bill
    {
        public int BillId { get; set; }
        public int? CustomerId { get; set; }
        public int StaffId { get; set; }
        public DateTime BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxAmount { get; set; }
        public int? PaymentStatusId { get; set; }
        public List<BillItem> Items { get; set; } = new List<BillItem>();
    }
}