using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ITaskHandler
    {
        IEnumerable<TaskItem> GetAllTasks();
        TaskItem GetTask(int taskId);
        bool CreateTask(TaskDto task);
        bool UpdateTask(int taskId, TaskDto updatedTask);
        bool DeleteTask(int taskId);
        void DeleteAllTasks();
    }
}