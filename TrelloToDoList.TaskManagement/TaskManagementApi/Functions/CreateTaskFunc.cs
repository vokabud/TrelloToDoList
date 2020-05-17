using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;
using TaskManagementApi.Models.Requests;

namespace TaskManagementApi.Functions
{
    public class CreateTaskFunc
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public CreateTaskFunc(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public string Invoke(CreateTaskRequest task)
        {
            var objectId =taskRepository.Insert(new TaskEntity
            {
                Description = task.Description,
                Title = task.Title
            });

            return objectId.ToString();
        }
    }
}
