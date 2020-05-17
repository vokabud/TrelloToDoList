using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;
using MongoDB.Driver;
using TaskManagementApi.Database.Interfaces;

namespace TaskManagementApi.Database
{
    public class MongoRepository<TEntity> : IMongoRepository<TEntity>
        where TEntity : IEntity
    {
        private readonly IMongoCollection<TEntity> collection;

        public MongoRepository(IMongoDbSettings settings)
        {
            var database = new MongoClient(settings.ConnectionString)
                .GetDatabase(settings.DatabaseName);

            collection = database.GetCollection<TEntity>(
                GetCollectionName(typeof(TEntity)));
        }

        public IEnumerable<TEntity> FilterBy(
            Expression<Func<TEntity, bool>> filterExpression)
        {
            return collection
                .Find(filterExpression)
                .ToEnumerable();
        }

        public ObjectId Insert(TEntity document)
        {
            collection
                .InsertOne(document);

            return document.Id;
        }

        public void Replace(TEntity document)
        {
            var filter = Builders<TEntity>
                .Filter
                .Eq(doc => doc.Id, document.Id);

            collection
                .FindOneAndReplace(filter, document);
        }

        public void DeleteById(ObjectId id)
        {
            var filter = Builders<TEntity>
                .Filter
                .Eq(doc => doc.Id, id);

            collection
                .FindOneAndDelete(filter);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return collection
                .AsQueryable();
        }

        private protected string GetCollectionName(Type documentType)
        {
            return ((BsonCollectionAttribute)documentType.GetCustomAttributes(
                    typeof(BsonCollectionAttribute),
                    true)
                .FirstOrDefault())?
                .CollectionName;
        }
    }
}
