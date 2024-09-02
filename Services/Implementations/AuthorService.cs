using Online_Bookstore_System.Dtos;
using Online_Bookstore_System.Repositorys.Interface;
using Online_Bookstore_System.Services.Interface;

namespace Online_Bookstore_System.Services.Implementations
{
    public class AuthorService : IAuthorService
    {
        private readonly IAdminRepository _adminRepository;

        public AuthorService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<AuthorDTO> GetAuthorByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDTO> RegisterAuthor(AuthorDTO model)
        {
            throw new NotImplementedException();
        }

        public Task<AuthorDTO> UpdateAuthorDetails(UpdateAuthorRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
