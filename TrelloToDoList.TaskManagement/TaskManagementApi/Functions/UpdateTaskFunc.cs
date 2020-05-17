using MongoDB.Bson;
using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;
using TaskManagementApi.Models.Requests;

namespace TaskManagementApi.Functions
{
    public class UpdateTaskFunc
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public UpdateTaskFunc(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public void Invoke(UpdateTaskRequest task)
        {
            taskRepository.Replace(new TaskEntity
            {
                Title = task.Title,
                Description = task.Description,
                Id = new ObjectId(task.Id)
            });
        }
    }
}
