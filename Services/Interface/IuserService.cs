using Online_Bookstore_System.Dtos;

namespace Online_Bookstore_System.Services.Interface
{
    public interface IuserService
    {

        Task<UserResponseModel> Login(UserDto model);
    }
}
