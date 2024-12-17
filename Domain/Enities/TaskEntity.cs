using Domain.Enums;
namespace Domain.Enities
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
