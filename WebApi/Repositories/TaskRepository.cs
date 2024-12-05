using WebApi.Models;
using WebApi.Interfaces;

namespace WebApi.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly Dictionary<int, TaskItem> _tasks = new Dictionary<int, TaskItem>();
        private int _nextId = 1;

        public IEnumerable<TaskItem> GetAll()
        {
            var b = _tasks.Values;
            return _tasks.Values;
        }

        public TaskItem? Get(int taskId)
        {
            if (_tasks.TryGetValue(taskId, out var task))
            {
                return task;
            }
            return null;
        }

        public bool Add(TaskItem item)
        {
            item.Id = _nextId++; 
            _tasks.Add(item.Id, item);
            return true;
        }

        public bool Delete(int taskId)
        {
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
            if (!_tasks.ContainsKey(taskId))
            {
                return false;
            }

            // Проверяем, что Title уникален (исключая текущую задачу)
            if (_tasks.Values.Any(task => task.Title == newTask.Title && task.Id != taskId))
            {
                throw new ArgumentException($"Task with Title '{newTask.Title}' already exists.");
            }

            // Обновляем задачу
            newTask.Id = taskId;
            _tasks[taskId] = newTask;

            return true;
        }


    }
}