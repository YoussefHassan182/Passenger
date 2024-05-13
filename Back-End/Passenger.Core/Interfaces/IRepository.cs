using System.Linq.Expressions;

namespace Passenger.Core.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
        void DeleteRange(List<T> entities);
        void SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancelationtoken);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Expression<Func<T, object>>[] includeExpressions = null, CancellationToken cancellationToken = default);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[] includeExpressions = null, CancellationToken cancellationToken = default);
        Task AddAsync(T entity, CancellationToken cancellationToken);
        Task AddListAsync(List<T> entities, CancellationToken cancellationToken = default);
        void AddList(List<T> entities);
    }
}
