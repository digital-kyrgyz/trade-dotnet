using Domain.Entities.Commons;

namespace Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T entity);

        Task<bool> AddRangeAsync(List<T> entities);

        bool Remove(T entity);

        Task<bool> RemoveAsync(Guid id);

        bool RemoveRange(List<T> entities);

        bool Update(T entity);

        Task<int> SaveAsync();
    }
}