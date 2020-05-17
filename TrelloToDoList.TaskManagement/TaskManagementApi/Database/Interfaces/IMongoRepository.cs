using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Bson;

namespace TaskManagementApi.Database.Interfaces
{
    public interface IMongoRepository<TEntity> 
        where TEntity : IEntity
    {
        IEnumerable<TEntity> FilterBy(
            Expression<Func<TEntity, bool>> filterExpression);

        ObjectId Insert(TEntity document);

        void Replace(TEntity document);

        void DeleteById(ObjectId id);

        IQueryable<TEntity> AsQueryable();
    }
}
