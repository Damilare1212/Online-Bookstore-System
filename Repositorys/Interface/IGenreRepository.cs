using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Repositorys.Interface
{
    public interface IGenreRepository : IRepository<Genre>
    {
        Task<IList<Genre>> GetAllGenre();
        Task<IList<Genre>> GetAuthorByGenre(string genreId);

    }
}
