using Microsoft.AspNetCore.Mvc;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Attribute;



namespace ToDoListApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskHandler _taskHandler;
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
             return Ok(_taskHandler.GetTask(id)); // Возвращаем 200 с задачей
        }

        [HttpPost]
        [ValidationFilter]
        public IActionResult CreateTask([FromBody] TaskDto newTaskDto)
        {
             return Ok(_taskHandler.CreateTask(newTaskDto));
            
        }

        [HttpPut("{id}")]
        [ValidationFilter]
        public IActionResult UpdateTask(int id, [FromBody] TaskDto updatedTask)
        {
            return Ok(_taskHandler.UpdateTask(id, updatedTask));
        }

        [HttpDelete("{id}", Name = "Delete Task")]
        public IActionResult DeleteTask(int id)
        {
            return Ok(_taskHandler.DeleteTask(id));
        }

        [HttpDelete(Name = "Delete All Task")]
        public IActionResult DeleteAllTasks()
        {
            _taskHandler.DeleteAllTasks();
            return Ok();
        }

    }
}
