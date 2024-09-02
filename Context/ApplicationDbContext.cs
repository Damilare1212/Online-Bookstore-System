using Online_Bookstore_System.models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Online_Bookstore_System.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        { }
        DbSet<Author> Authors { get; set; }


        DbSet<Book> Books { get; set; }
         

        DbSet<Genre> Genres { get; set; }
         

        DbSet<Order> Orders { get; set; }


    }
}
