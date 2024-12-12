using WebApi.Models;
using WebApi.Extencions;
using WebApi.Interfaces;

namespace WebApi.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Dictionary<int, TaskItem> _tasks = new Dictionary<int, TaskItem>();
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAll()
        {
            return _tasks.Values;
        }

        public TaskItem Get(int taskId)
        {
            return _tasks.GetRequiredValue(taskId);
        }

        public bool Add(TaskItem item)
        {
            item.Id = _nextId++; 
            _tasks.Add(item.Id, item);
            return true;
        }

        public bool Delete(int taskId)
        {
            _tasks.EnsureKeyExists(taskId);
            return _tasks.Remove(taskId);
        }

        public void DeleteAll()
        {
            if (_tasks.Count() == 0) return;
            _tasks.Clear(); 
            _nextId = 1; 
        }

        public bool Update(int taskId, TaskItem newTask)
        {
            _tasks.EnsureKeyExists(taskId);

            newTask.Id = taskId;
            _tasks[taskId] = newTask;

            return true;
        }


    }
}