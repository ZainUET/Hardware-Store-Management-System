﻿namespace Bismillah.Entities
{
    public class BillItem
    {
        public int BillItemId { get; set; }
        public int BillId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? BatchId { get; set; }
    }
}