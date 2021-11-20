using Domain.Contract.Models;
using MongoDB.Driver;
using Persistence.DbContexts;
using System;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;

namespace Persistence.Repositories
{
    public class MongoRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : IBaseEntity
    {
        #region Fields

        private readonly IMongoCollection<TEntity> _collection;

        #endregion

        #region Constructors

        public MongoRepository(IMongoDbContext dbContext)
        {
            _collection = dbContext.GetTEntityCollection<TEntity>();
        }

        #endregion

        #region Write Methods
        public async Task CreateAsync(TEntity entity)
        {
            BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
            await _collection.InsertOneAsync(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _collection.ReplaceOneAsync(p => p.Id == entity.Id, entity, new ReplaceOptions {IsUpsert = false});
        }

        public async Task DeleteAsync(Guid id)
        {
            await _collection.DeleteOneAsync(p => p.Id == id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}