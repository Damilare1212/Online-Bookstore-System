using Online_Bookstore_System.Context;
using Online_Bookstore_System.models;
using Online_Bookstore_System.Repositorys.Interface;

namespace Online_Bookstore_System.Repositorys.Implementations
{
    public class GenreRepository : BaseRepository<Genre>, IGenreRepository
    {
        public GenreRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IList<Genre>> GetAllGenre()
        {
           var genre = await _context.Genres.Include(x => x.Genre);

        }

        public Task<IList<Genre>> GetAuthorByGenre(string genreId)
        {
            throw new NotImplementedException();
        }
    }
}
