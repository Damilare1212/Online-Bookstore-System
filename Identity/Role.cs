using Online_Bookstore_System.Contract;

namespace Online_Bookstore_System.Identity
{
    public class Role : AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<UserRole> UserRoles { get; set; } = new HashSet<UserRole>();
    }
}
