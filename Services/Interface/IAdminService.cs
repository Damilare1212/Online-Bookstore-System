using Online_Bookstore_System.Dtos;

namespace Online_Bookstore_System.Services.Interface
{
    public interface IAdminService
    {
       Task<BaseResponse> RegisterAdmin(AdminRequestModel model);

        Task<BaseResponse> UpdateAdmin(AdminRequestModel model, int Id);

        Task<AdminResponseModel> GetAdminInfo(int id);

        Task<AdminsResponseModel> GetAllAdmins();
    }
}
