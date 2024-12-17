using Domain.Dto;
using Domain.Enities;

namespace Domain.Interfaces
{
    public interface ITaskHandler
    {
        Task<IEnumerable<TaskEntity>> GetAllTasksAsync();
        Task<TaskEntity> GetTaskByIdAsync(int id);
        Task<bool> CreateTaskAsync(TaskDto taskDto);
        Task<bool> UpdateTaskAsync(int id, TaskDto taskDto);
        Task<bool> DeleteTaskAsync(int id);
        Task<bool> DeleteAllTaskAsync();
    }
}
