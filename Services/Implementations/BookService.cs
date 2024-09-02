using Online_Bookstore_System.Dtos;
using Online_Bookstore_System.Repositorys.Interface;
using Online_Bookstore_System.Services.Interface;
using static System.Net.Mime.MediaTypeNames;
using System.Net;

namespace Online_Bookstore_System.Services.Implementations
{
    public class BookService : IBookService
    {
        private readonly IAdminRepository _adminRepository;

        public BookService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<BookResponseModel> DeleteBook(int BookId)
        {
            throw new NotImplementedException();
        }

        public Task<BookResponseModel> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        public Task<BookResponseModel> GetBookById(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<BookResponseModel> RegisterBook(BookResponseModel model)
        {
            var user = await _userRepository.Get(x => x.Id == model.UserName);
            
          
            if (model == null)
            {
                return new BookResponseModel
                {
                    Message = "Value can't be null",
                    Status = true
                };
            }

            
            
            }

            
             
        }

        public Task<BookResponseModel> UpdateBook(UpdateBookDto model)
        {
            throw new NotImplementedException();
        }
    }
}
