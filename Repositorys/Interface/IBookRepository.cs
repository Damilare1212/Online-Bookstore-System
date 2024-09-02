using Online_Bookstore_System.Enum;
using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Repositorys.Interface
{
    public interface IBookRepository : IRepository<Book>
    {
         Task<Book> GetBookByDate(Book book);
        Task<Book> GetPurchasedBooks(Book book);
        Task<Book> GetBookById(Book bookId);
        Task<Book> GetBookByName(string name);
        Task<Book> BookStatus (ORderStatus status);

        Task<IList<Book>> GetAllBooks();

        Task<IList<Book>> GetUploadedBooks();



    }
}
