namespace Passenger.Core.Interfaces
{
    public interface IBaseODataRepository<T>
    {
        Task<IQueryable<T>> GetQueryableAsync(CancellationToken cancellationToken);
    }
}
