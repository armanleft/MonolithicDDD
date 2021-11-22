// using Microsoft.Extensions.Configuration;
// using MongoDB.Driver;
//
// namespace Persistence.DbContexts
// {
//     public class MongoDbContext : IMongoDbContext
//     {
//         #region Fields
//
//         private readonly IMongoDatabase _database;
//
//         #endregion
//
//         #region Ctor
//
//         public MongoDbContext(IConfiguration configuration)
//         {
//             IMongoClient client = new MongoClient(MongoClientSettings.FromUrl(new MongoUrl(configuration["Mongo:Connection"])));
//             _database = client.GetDatabase(configuration["Mongo:Database"]);
//         }
//
//         #endregion
//
//         #region Public Methods
//
//         /// <summary>
//         /// 
//         /// </summary>
//         public IMongoCollection<TEntity> GetTEntityCollection<TEntity>()
//         {
//             return _database.GetCollection<TEntity>(typeof(TEntity).Name.TrimStart('I') + "s");
//         }
//
//         #endregion
//     }
// }