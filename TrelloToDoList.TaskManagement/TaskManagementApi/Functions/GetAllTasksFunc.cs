using System.Collections.Generic;
using System.Linq;
using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;
using TaskManagementApi.Models.Responses;

namespace TaskManagementApi.Functions
{
    public class GetAllTasksFunc
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public GetAllTasksFunc(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IEnumerable<TaskResponse> Invoke()
        {
            return taskRepository
                .AsQueryable()
                .Select(
                    task => new TaskResponse(
                        task.Id.ToString(), 
                        task.Title, 
                        task.Description));
        }
    }
}
