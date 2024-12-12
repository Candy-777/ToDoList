using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Handlers
{
    public class TaskHandler : ITaskHandler
    {
        private readonly ITaskRepository _repository;

        public TaskHandler(ITaskRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaskItem> GetAllTasks()
        {
            return _repository.GetAll();
        }

        public TaskItem GetTask(int taskId) 
        {
            return _repository.Get(taskId);
  
        }

        public bool CreateTask(TaskDto newTaskDto)
        {
            TaskItem task = new TaskItem(newTaskDto);
            var result = _repository.Add(task);
            return result;
        }

        public bool UpdateTask(int taskId, TaskDto updatedTaskDto)
        {    
            var existingTask = _repository.Get(taskId);        

            var task = new TaskItem(updatedTaskDto);

            return _repository.Update(taskId, task);
        }

        public bool DeleteTask(int taskId)
        {
            return _repository.Delete(taskId);
        }

        public void DeleteAllTasks()
        {
            _repository.DeleteAll();
        }
    }
}