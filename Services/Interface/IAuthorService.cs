using Online_Bookstore_System.Dtos;

namespace Online_Bookstore_System.Services.Interface
{
    public interface IAuthorService
    {
        Task<AuthorDTO> RegisterAuthor(AuthorDTO model);

        Task<AuthorDTO> UpdateAuthorDetails(UpdateAuthorRequestModel model);
        Task<AuthorDTO> GetAuthorByID(int id);
    }
}
