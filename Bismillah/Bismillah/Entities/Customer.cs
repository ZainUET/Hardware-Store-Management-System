namespace Bismillah.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string CNIC { get; set; }
        public string Address { get; set; }
        public int LoyaltyPoints { get; set; }
        public bool IsRegular { get; set; }

    }
}