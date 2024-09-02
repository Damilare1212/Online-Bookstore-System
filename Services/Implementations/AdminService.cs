using Online_Bookstore_System.Dtos;
using Online_Bookstore_System.Repositorys.Interface;
using Online_Bookstore_System.Services.Interface;

namespace Online_Bookstore_System.Services.Implementations
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public Task<AdminResponseModel> GetAdminInfo(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AdminsResponseModel> GetAllAdmins()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> RegisterAdmin(AdminRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpdateAdmin(AdminRequestModel model, int Id)
        {
            throw new NotImplementedException();
        }
    }
}
