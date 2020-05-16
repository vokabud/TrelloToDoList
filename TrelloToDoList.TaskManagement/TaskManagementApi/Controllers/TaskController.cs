using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using TaskManagementApi.Database.Entities;
using TaskManagementApi.Database.Interfaces;
using TaskManagementApi.Models;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly IMongoRepository<TaskEntity> taskRepository;

        public TaskController(
            IMongoRepository<TaskEntity> taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        // GET: api/Task
        [HttpGet]
        public IEnumerable<TaskItem> GetAll()
        {
            return taskRepository
                .AsQueryable()
                .Select(
                    task => new TaskItem
                    {
                        Description = task.Description, 
                        Title = task.Title, 
                        Id = task.Id.ToString()
                    });
        }

        // GET: api/Task/5
        [HttpGet("{id}", Name = "Get")]
        public TaskItem Get(string id)
        {
            var task = taskRepository
                .FindById(id);

            return new TaskItem
            {
                Title = task.Title,
                Description = task.Description,
                Id = task.Id.ToString()
            };
        }

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody] TaskItem value)
        {
            taskRepository.Insert(new TaskEntity
            {
                Description = value.Description,
                Title = value.Title
            });
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] TaskItem value)
        {
            taskRepository.Replace(new TaskEntity
            {
                Title = value.Title,
                Description = value.Description,
                Id = new ObjectId(id)
            });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            taskRepository.DeleteById(id);
        }
    }
}
