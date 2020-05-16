using MongoDB.Bson;
using TaskManagementApi.Database.Interfaces;

namespace TaskManagementApi.Database.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public ObjectId Id { get; set; }
    }
}
