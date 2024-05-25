using Passenger.Core.Interfaces;
using System.Linq.Expressions;


namespace Passenger.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(T entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public void AddList(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task AddListAsync(List<T> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Attach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Expression<Func<T, object>>[] includeExpressions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, object>>[] includeExpressions = null, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync(CancellationToken cancelationtoken)
        {
            throw new NotImplementedException();
        }
    }
}
