using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces;
using Domain.Dto;
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
        public async Task<IActionResult> Get()
        {
            return Ok(await _taskHandler.GetAllTasksAsync());
        }
        [HttpGet("{id}", Name = "Get Task By Id")]
        public async Task<IActionResult> GetTaskById(int id)
        {
             return Ok( await _taskHandler.GetTaskByIdAsync(id)); // Возвращаем 200 с задачей
        }

        [HttpPost]
        [ValidationFilter]
        public async Task<IActionResult> CreateTask([FromBody] TaskDto newTaskDto)
        {
             return Ok( await _taskHandler.CreateTaskAsync(newTaskDto));
            
        }

        [HttpPut("{id}")]
        [ValidationFilter]
        public async Task<IActionResult> UpdateTask(int id, [FromBody] TaskDto updatedTask)
        {
            return Ok( await _taskHandler.UpdateTaskAsync(id, updatedTask));
        }

        [HttpDelete("{id}", Name = "Delete Task")]
        public async Task<IActionResult> DeleteTask(int id)
        {
            return Ok(await _taskHandler.DeleteTaskAsync(id));
        }

        [HttpDelete(Name = "Delete All Task")]
        public async Task<IActionResult> DeleteAllTasks()
        {
            await _taskHandler.DeleteAllTaskAsync();
            return Ok();
        }

    }
}
