using System.ComponentModel.DataAnnotations;
using ToDoListApi.Enums;

namespace WebApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public DateTime DeadLine {  get;  set; }

        public TaskItem(TaskDto taskDto)
        {
            this.Title = taskDto.Title;
            this.Description = taskDto.Description;
            this.Priority = taskDto.Priority;
            this.LastUpdateTime = taskDto.LastUpdateTime;
            this.DeadLine = taskDto.DeadLine;
            
        }
        public TaskItem() { }

        public void Returns<T>(Func<object, TaskItem> value)
        {
            throw new NotImplementedException();
        }
    }
}
