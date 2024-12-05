using WebApi.Interfaces;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class UniqueTitleTaskRepositoryDecorator : ITaskRepository
    {
        private readonly ITaskRepository _innerRepository;

        public UniqueTitleTaskRepositoryDecorator(ITaskRepository innerRepository)
        {
            _innerRepository = innerRepository;
        }

        public IEnumerable<TaskItem> GetAll() => _innerRepository.GetAll();

        public TaskItem Get(int id) => _innerRepository.Get(id);

        public bool Add(TaskItem task)
        {
            // Проверяем, существует ли уже задача с таким названием
            if (_innerRepository.GetAll().Any(t => t.Title == task.Title))
            {
                throw new ArgumentException($"Task with title '{task.Title}' already exists.");
            }

            return _innerRepository.Add(task);
        }

        public bool Update(int id, TaskItem task)
        {
            if (_innerRepository.GetAll().Any(t => t.Id != id && t.Title == task.Title))
            {
                throw new ArgumentException($"(Update) Task with title '{task.Title}' already exists.");
            }

            return _innerRepository.Update(id, task);
        }

        public bool Delete(int id) => _innerRepository.Delete(id);

        public void DeleteAll() => _innerRepository.DeleteAll();
    }
}
