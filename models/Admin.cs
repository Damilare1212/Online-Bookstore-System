using Online_Bookstore_System.Contract;

namespace Online_Bookstore_System.models
{
    public class Admin : AuditableEntity
    {
        public string? Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
