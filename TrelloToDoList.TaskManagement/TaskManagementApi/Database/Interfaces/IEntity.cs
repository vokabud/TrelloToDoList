using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TaskManagementApi.Database.Interfaces
{
    public interface IEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        ObjectId Id { get; set; }
    }
}
