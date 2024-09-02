using Online_Bookstore_System.Contract;
using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Identity
{
    public class UserRole : AuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
