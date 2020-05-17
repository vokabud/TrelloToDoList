using MongoDB.Bson;
using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;

namespace TaskManagementApi.Functions
{
    public class DeleteTaskFunc
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public DeleteTaskFunc(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void Invoke(string taskId)
        {
            var objectId = new ObjectId(taskId);

            taskRepository.DeleteById(objectId);
        }
    }
}
