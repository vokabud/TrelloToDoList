using System.Linq;
using MongoDB.Bson;
using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;
using TaskManagementApi.Models.Responses;

namespace TaskManagementApi.Functions
{
    public class GetTaskByIdFunc
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public GetTaskByIdFunc(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public TaskResponse Invoke(string taskId)
        {
            var objectId = new ObjectId(taskId);

            var taskEntity = taskRepository
                .FilterBy(task => task.Id == objectId)
                .First();

            return new TaskResponse(
                taskId, 
                taskEntity.Title,
                taskEntity.Description);
        }
    }
}
