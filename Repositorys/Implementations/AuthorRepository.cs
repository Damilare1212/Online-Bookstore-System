using Online_Bookstore_System.Context;
using Online_Bookstore_System.models;
using Online_Bookstore_System.Repositorys.Interface;
using System.Linq.Expressions;

namespace Online_Bookstore_System.Repositorys.Implementations
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationContext context
           )
        {
            _context = context;
        }

        public Task<bool> Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Get(Expression<Func<Author, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Author>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Author> GetAuthorByBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Author>> GetBookByAuthor(int id)
        {
           var author = _context

        }

        public Task<IList<Author>> GetByExpression(Expression<Func<Author, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Register(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<Author> Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
