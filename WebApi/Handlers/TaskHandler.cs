using WebApi.Interfaces;
using WebApi.Models;
using FluentValidation;

namespace WebApi.Handlers
{
    public class TaskHandler : ITaskHandler
    {
        private readonly ITaskRepository _repository;
        private readonly IValidator<TaskDto> _taskDtoValidator;

        public TaskHandler(ITaskRepository repository, IValidator<TaskDto> taskDtoValidator)
        {
            _taskDtoValidator = taskDtoValidator;
            _repository = repository;
        }

        public IEnumerable<TaskItem> GetAllTasks()
        {
            return _repository.GetAll();
        }

        public TaskItem GetTask(int taskId) 
        {
            var task = _repository.Get(taskId);

            if (task == null)
            {
                 throw new KeyNotFoundException($"Task with ID {taskId} not found.");
            }
            return task; 
        }

        public bool CreateTask(TaskDto newTaskDto)
        {
            var validationResult = _taskDtoValidator.Validate(newTaskDto);

            if (!validationResult.IsValid)
            {                
                throw new ArgumentException(string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage)));
            }

            if (newTaskDto == null)
            {
                throw new ArgumentNullException(nameof(newTaskDto));
            }
               
            TaskItem task = new TaskItem(newTaskDto);

            var result = _repository.Add(task);

            if (result)
            {
                return result;
            }
            else
            {
               throw new InvalidOperationException($"A task with the title '{newTaskDto.Title}' already exists.");
            }
        }

        public bool UpdateTask(int taskId, TaskDto updatedTaskDto)
        {    
            var existingTask = _repository.Get(taskId);

            if (existingTask == null)
            {
                throw new KeyNotFoundException($"Task with ID {taskId} not found.");
            }

            var validationResult = _taskDtoValidator.Validate(updatedTaskDto);

            if (!validationResult.IsValid)
            {
                throw new ArgumentException(string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage)));
            }

            var task = new TaskItem(updatedTaskDto);

            return _repository.Update(taskId, task);
        }

        public bool DeleteTask(int taskId)
        {
            var existingTask = _repository.Get(taskId);
            if (existingTask == null)
            {
                throw new KeyNotFoundException($"Task with ID {taskId} not found.");
            }

            return _repository.Delete(taskId);
        }

        public void DeleteAllTasks()
        {
            _repository.DeleteAll();
        }
    }
}