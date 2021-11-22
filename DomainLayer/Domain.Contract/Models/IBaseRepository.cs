using System;
using System.Threading.Tasks;

namespace Domain.Contract.Models
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : IBaseEntity
    {
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(string id);
        Task<TEntity> GetByIdAsync(string id);
    }
}