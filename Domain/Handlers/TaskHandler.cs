using Domain.Dto;
using Domain.Enities;
using Domain.Interfaces;

namespace Domain.Handler
{
    public class TaskHandler: ITaskHandler
    {
        private readonly IBaseRepository<TaskEntity> _repository;

        public TaskHandler(IBaseRepository<TaskEntity> repository)
        {
            _repository = repository;
        }

        public async Task<bool> CreateTaskAsync(TaskDto taskDto)
        {
            var newTask = new TaskEntity
            {
                Title = taskDto.Title,
                Description = taskDto.Description,
                DeadLine = taskDto.DeadLine,
                Priority = taskDto.Priority
            };

            await _repository.Create(newTask);
            return true;
        }

        public async Task<bool> DeleteAllTaskAsync()
        {
            await _repository.DeleteAll();
            return true;
        }

        public async Task<bool> DeleteTaskAsync(int id)
        {
            await _repository.Delete(id);
            return true;
        }

        public async Task<IEnumerable<TaskEntity>> GetAllTasksAsync()
        {
            return await _repository.GetAll();
            
        }

        public async Task<TaskEntity> GetTaskByIdAsync(int id)
        {
            return await _repository.Get(id);
        }

        public async Task<bool> UpdateTaskAsync(int id, TaskDto taskDto)
        {
            var existingTask = await _repository.Get(id);
            if (existingTask == null)
                throw new KeyNotFoundException($"Task with id {id} not found.");
            
            existingTask.Title = taskDto.Title;
            existingTask.Description = taskDto.Description;
            existingTask.DeadLine = taskDto.DeadLine;
            existingTask.Priority = taskDto.Priority;

            await _repository.Update(existingTask);
            return true;
        }
    }
}
