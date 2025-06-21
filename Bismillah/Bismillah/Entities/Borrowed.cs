using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bismillah.Entities
{
    internal class Borrowed
    {
        public int BorrowedId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalAmount => Quantity * UnitPrice; // Calculated property
        public bool IsPaid { get; set; }
        public DateTime DateBorrowed { get; set; }
    }
}