using Online_Bookstore_System.Context;
using Online_Bookstore_System.Repositorys.Interface;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Online_Bookstore_System.Repositorys.Implementations
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity, new()
    {
        protected ApplicationContext _Context;
        public async Task<bool> Delete(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            var ans = await _Context.Set<T>().SingleOrDefaultAsync(expression);
            return ans;
        }

        public Task<IList<T>> GetAll()
        {
            return await _Context.Set<T>().ToListAsync();
        }

        public async Task<IList<T>> GetByExpression(Expression<Func<T, bool>> expression)
        {
            var get = await _Context.Set<T>().Where(expression).ToListAsync();
            return get;
        }

        public async Task<T> Register(T entity)
        {
            await _Context.Set<T>().AddAsync(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }

        public Task<T> Update(T entity)
        {
            _Context.Set<T>().Update(entity);
            await _Context.SaveChangesAsync();
            return entity;
        }
    }
}
