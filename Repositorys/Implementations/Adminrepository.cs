using Online_Bookstore_System.Context;
using Online_Bookstore_System.models;
using Online_Bookstore_System.Repositorys.Interface;
using System.Linq.Expressions;

namespace Online_Bookstore_System.Repositorys.Implementations
{
    public class Adminrepository : BaseRepository<Admin>, IAdminRepository
    {
         public Adminrepository(ApplicationContext context
             ) 
        {
            _context = context;
        }
       

        public Task<Admin> Get(Expression<Func<Admin, bool>> expression)
        {
            var ans = await _context.Set<T>().SingleOrDefaultAsync(expression);
            return ans;
        }

        public Task<Admin> GetAdminInfo(int id)
        {
            var admin = await _context.Admins
            .Include(x => x.User).Include(a => a.Address)
            .SingleOrDefaultAsync(x => x.User.Id == id && x.IsDeleted == false);
            return admin;
        }

        public Task<IList<Admin>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public Task<IList<Admin>> GetAllActivatedAdmin()
        {
            var admin = await _context.Admins.Where(x => x.IsDeleted == true).ToListAsync();
            return admin;
        }

        public Task<IList<Admin>> GetAllAdminWithUser()
        {
            var admin = await _context.Admins.Include(x => x.User).Include(a => a.Address).Where(x => x.IsDeleted == false).ToListAsync();
            return admin;
        }

        public Task<IList<Admin>> GetAllDeactivatedAdmin()
        {
            var admin = await _context.Admins.Where(x => x.IsDeleted == true).ToListAsync();
            return admin;
        }
    }

        public Task<IList<Admin>> GetAllDeactivatedAdmin()
        {
            var admin = await _context.Admins.Where(x => x.IsDeleted == true).ToListAsync();
            return admin;
        }

        public Task<IList<Admin>> GetByExpression(Expression<Func<Admin, bool>> expression)
        {
            var get = await _context.Set<T>().Where(expression).ToListAsync();
            return get;
        }

     
    
}
