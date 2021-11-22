using Domain.Contract.Models;
using System;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class MongoRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : IBaseEntity
    {
        #region Fields

        // private readonly IMongoCollection<TEntity> _collection;
        // readonly DbSet<TEntity> _collection;

        #endregion

        #region Constructors

        public MongoRepository(/*IMongoDbContext dbContext*/)
        {
            // _collection = dbContext.GetTEntityCollection<TEntity>();
        }

        #endregion

        #region Write Methods

        public async Task CreateAsync(TEntity entity)
        {
            // await _collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            // await _collection.ReplaceOneAsync(p => p.Id == entity.Id, entity, new ReplaceOptions {IsUpsert = false});
        }

        public async Task DeleteAsync(string id)
        {
            // await _collection.DeleteOneAsync(p => p.Id == id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Read Methods

        public async Task<TEntity> GetByIdAsync(string id)
        {
            // return await _collection.Find(e => e.Id == id).FirstOrDefaultAsync();
            throw new NotImplementedException();
        }

        #endregion
    }
}