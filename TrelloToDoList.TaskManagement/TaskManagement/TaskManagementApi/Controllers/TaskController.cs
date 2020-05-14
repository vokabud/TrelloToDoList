using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagementApi.Models;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        // GET: api/Task
        [HttpGet]
        public IEnumerable<TaskItem> Get()
        {
            return Enumerable.Empty<TaskItem>();
        }

        // GET: api/Task/5
        [HttpGet("{id}", Name = "Get")]
        public TaskItem Get(string id)
        {
            return new TaskItem(
                "id", 
                "title", 
                "description", 
                "user id");
        }

        // POST: api/Task
        [HttpPost]
        public void Post([FromBody] TaskItem value)
        {
        }

        // PUT: api/Task/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] TaskItem value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
