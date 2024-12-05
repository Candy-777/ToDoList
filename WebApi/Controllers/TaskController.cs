using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Interfaces;
using WebApi.Models;
using System.ComponentModel.DataAnnotations;



namespace ToDoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private ITaskHandler _taskHandler;
        private readonly ILogger<TaskController> _logger;
        public TaskController(ITaskHandler handler, ILogger<TaskController> logger)
        {
            _taskHandler = handler;
            _logger = logger;
        }

        [HttpGet(Name = "Get All Tasks")]
        public IActionResult Get()
        {
            return Ok(_taskHandler.GetAllTasks());
        }
        [HttpGet("{id}", Name = "Get Task By Id")]
        public IActionResult GetTaskById(int id)
        {
                var task = _taskHandler.GetTask(id);
                return Ok(task); // Возвращаем 200 с задачей
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskDto newTaskDto)
        {
             var result = _taskHandler.CreateTask(newTaskDto);
             return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(int id, [FromBody] TaskDto updatedTask)
        {
            _taskHandler.UpdateTask(id, updatedTask);
            return Ok();
        }

        [HttpDelete("{id}", Name = "Delete Task")]
        public IActionResult DeleteTask(int id)
        {
          _taskHandler.DeleteTask(id);
            return Ok();
        }

        [HttpDelete(Name = "Delete All Task")]
        public IActionResult DeleteAllTasks()
        {
            _taskHandler.DeleteAllTasks();
            return Ok();
        }

    }
}
