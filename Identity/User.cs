using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Identity
{
    public class User
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Admin Admin { get; set; }
        public Author Author { get; set; }
        public ICollection<UserRole> UserRoles { get; set;} = new HashSet<UserRole>();
    }
}
