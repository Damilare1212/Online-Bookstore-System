using Online_Bookstore_System.Contract;

namespace Online_Bookstore_System.models
{
    public class Payment : AuditableEntity
    {
        public string ReferrenceNumber { get; set; }
        public int CustomerId { get; set; }
        public decimal AmountPaid { get; set; }
        public string DateOfPayment { get; set; }
        public decimal AmountSendToLandlord { get; set; }
        public int ApartmentId { get; set; }
        public Book Book { get; set; }
        public bool IsVerified { get; set; }
        public Author Author { get; set; }

    }
}
