using Domain.Enums;

namespace Domain.Dto
{
    public class TaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime LastUpdateTime { get; } = DateTime.Now.Date;
        public DateTime DeadLine { get; set; }
    }
}
