using Online_Bookstore_System.Contract;
using System.ComponentModel.DataAnnotations;

namespace Online_Bookstore_System.models
{
    public class Author : AuditableEntity
    {
       // public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
