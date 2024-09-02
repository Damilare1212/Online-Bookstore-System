using Online_Bookstore_System.Context;
using Online_Bookstore_System.Enum;
using Online_Bookstore_System.models;
using Online_Bookstore_System.Repositorys.Interface;
using System.Linq.Expressions;
using System.Net;

namespace Online_Bookstore_System.Repositorys.Implementations
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        public BookRepository(ApplicationContext context
            )
        {
            _context = context;
        }

        public async Task<Book> BookStatus(ORderStatus status)
        {
           var book  = await _context.Books.Where(x =>  x.BookStatus == status);
            return book;
        }

        public Task<IList<Book>> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBookByDate(Book book)
        {
            var bk = await _context.Books.Include(x => x.Price)
           .Include(a => a.Title)
           .Include(b => b.Description).ToListAsync();
            return bk;
        }

        public async Task<Book> GetBookById(Book bookId)
        {
            var Bk = _context.Books.Include(x => x.Price)
            .Include(a => a.Title)
            .Include(b => b.Description).Where(x => x.BookId == bookId).ToListAsync();
            return Bk;
        }

        public Task<Book> GetBookByName(string name)
        {
            var Bk = _context.Books 
          .Include(a => a.Title)
           .Where(x => x.Title.ToUpper() == name,ToUpper()).ToListAsync();
            return Bk;
        }

        public async Task<Book> GetPurchasedBooks(Book book)
        {
           var bk = await _context.Books.Include(x => x.Title).Where(e => e.IsAproved == true).ToListAsync();
            return bk
        }

        public Task<IList<Book>> GetUploadedBooks()
        {
            var bk = await _context.Books.Include(x => x.Title).Where(e => e.IsDownloaded == false).ToListAsync();
            return bk;
        }
    }
}
