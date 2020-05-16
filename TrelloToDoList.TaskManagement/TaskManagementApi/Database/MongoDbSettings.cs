using TaskManagementApi.Database.Interfaces;

namespace TaskManagementApi.Database
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string DatabaseName
        {
            get; 
            set;
        }

        public string ConnectionString
        {
            get; 
            set;
        }
    }
}
