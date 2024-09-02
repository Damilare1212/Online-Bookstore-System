using Online_Bookstore_System.Dtos;

namespace Online_Bookstore_System.Services.Interface
{
    public interface IBookService
    {
        Task<BookResponseModel> RegisterBook(BookResponseModel model);

        Task<BookResponseModel> UpdateBook(UpdateBookDto model);

        Task<BookResponseModel> DeleteBook( int BookId );

        Task<BookResponseModel> GetBookById(int Id);

        Task<BookResponseModel> GetAllBooks();

    }
}
