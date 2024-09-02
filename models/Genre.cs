using Online_Bookstore_System.Contract;
using System.ComponentModel.DataAnnotations;

namespace Online_Bookstore_System.models
{
    public class Genre : AuditableEntity
    {
       // public int Id { get; set; }
        [Display(Name = "Genre")]
        public string GenreName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
