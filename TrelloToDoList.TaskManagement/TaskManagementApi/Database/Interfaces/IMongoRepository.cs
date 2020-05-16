using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TaskManagementApi.Database.Interfaces
{
    public interface IMongoRepository<TEntity> 
        where TEntity : IEntity
    {
        IEnumerable<TEntity> FilterBy(
            Expression<Func<TEntity, bool>> filterExpression);

        TEntity FindById(string id);

        void Insert(TEntity document);

        void Replace(TEntity document);

        void DeleteById(string id);

        IQueryable<TEntity> AsQueryable();
    }
}
