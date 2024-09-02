using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Repositorys.Interface
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<Author> GetAuthorByBook(Book book);
        Task<IList<Author>> GetBookByAuthor(int id);


    }
}
