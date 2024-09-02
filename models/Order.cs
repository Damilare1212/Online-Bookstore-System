using Online_Bookstore_System.Contract;

namespace Online_Bookstore_System.models
{
    public class Order : AuditableEntity
    {
        public int OrderId { get; set; }
        public Book Book { get; set; }
        public int BookID { get; set; }


    }
}
