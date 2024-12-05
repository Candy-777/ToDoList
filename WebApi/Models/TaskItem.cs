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
        public DateTime LastUpdateTime { get; set; } = DateTime.Now.Date;

        public DateTime DeadLine {  get;  set; }

        public TaskItem(int id, string title, string description, Priority priority, DateTime deadLine)
        {
            if (deadLine <= DateTime.Now.Date)
            {
                throw new ArgumentException("DeadLine must be after the creation date.");
            }
            Id = id;
            Title = title;
            Description = description;
            Priority = priority;
            DeadLine = deadLine;
        }

        public TaskItem(TaskDto taskDto)
        {
            this.Title = taskDto.Title;
            this.Description = taskDto.Description;
            this.Priority = taskDto.Priority;
            this.LastUpdateTime = taskDto.LastUpdateTime;
            this.DeadLine = taskDto.DeadLine;
            
        }
        public TaskItem() { }

    }
}
