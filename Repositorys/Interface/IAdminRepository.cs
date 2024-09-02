using Online_Bookstore_System.models;

namespace Online_Bookstore_System.Repositorys.Interface
{
    public interface IAdminRepository : IRepository<Admin>
    {

        Task<Admin> GetAdminInfo(int id);

        Task<IList<Admin>> GetAllAdminWithUser();

        Task<IList<Admin>> GetAllActivatedAdmin();

        Task<IList<Admin>> GetAllDeactivatedAdmin();
    }
}
