using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem? Get(int taskId);
        bool Add(TaskItem item);
        bool Delete(int taskId);
        void DeleteAll();
        bool Update(int taskId, TaskItem newTask);

    }
}
