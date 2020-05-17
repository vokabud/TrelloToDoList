using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskManagementApi.Functions;
using TaskManagementApi.Models.Requests;
using TaskManagementApi.Models.Responses;

namespace TaskManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly CreateTaskFunc createTaskFunc;
        private readonly DeleteTaskFunc deleteTaskFunc;
        private readonly GetAllTasksFunc getAllTasksFunc;
        private readonly GetTaskByIdFunc getTaskByIdFunc;
        private readonly UpdateTaskFunc updateTaskFunc;

        public TaskController(
            CreateTaskFunc createTaskFunc,
            DeleteTaskFunc deleteTaskFunc,
            GetAllTasksFunc getAllTasksFunc, 
            GetTaskByIdFunc getTaskByIdFunc, 
            UpdateTaskFunc updateTaskFunc)
        {
            this.createTaskFunc = createTaskFunc;
            this.deleteTaskFunc = deleteTaskFunc;
            this.getAllTasksFunc = getAllTasksFunc;
            this.getTaskByIdFunc = getTaskByIdFunc;
            this.updateTaskFunc = updateTaskFunc;
        }

        /// <summary>
        /// GET: api/task
        /// </summary>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<TaskResponse>> GetAll()
        {
            var tasks = getAllTasksFunc
                .Invoke();

            return Ok(tasks);
        }

        /// <summary>
        /// GET: api/task/5
        /// </summary>
        /// <param name="id">Task id.</param>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<TaskResponse> Get(
            string id)
        {
            try
            {
                var task = getTaskByIdFunc
                    .Invoke(id);

                return Ok(task);
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
        }

        /// <summary>
        /// POST: api/task
        /// </summary>
        /// <param name="taskRequest">Create task request.</param>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<string> Post(
            [FromBody] CreateTaskRequest taskRequest)
        {
            var taskId = createTaskFunc.Invoke(taskRequest);

            return Created(".", taskId);
        }

        /// <summary>
        /// PUT: api/task/5
        /// </summary>
        /// <param name="updateTaskRequest">Update task request.</param>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Put(
            [FromBody] UpdateTaskRequest updateTaskRequest)
        {
            updateTaskFunc.Invoke(updateTaskRequest);
            return Ok();
        }

        /// <summary>
        ///  DELETE: api/task/5
        /// </summary>
        /// <param name="id">Task id.</param>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult Delete(string id)
        {
            deleteTaskFunc.Invoke(id);
            return Ok();
        }
    }
}
