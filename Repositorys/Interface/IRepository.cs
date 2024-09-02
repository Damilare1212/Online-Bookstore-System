using Online_Bookstore_System.Context;
using System.Linq.Expressions;

namespace Online_Bookstore_System.Repositorys.Interface
{
    public interface IRepository<T> where T : BaseEntity, new ()
    {
        Task<T> Register(T entity);

        Task<T> Update(T entity);

        Task<T> Get(Expression<Func<T, bool>> expression);

        Task<IList<T>> GetAll();

        Task<bool> Delete(T entity);

        Task<IList<T>> GetByExpression(Expression<Func<T, bool>> expression);
    }
}
