using Domain.Enities;
using Microsoft.EntityFrameworkCore;


namespace DataAccess.Repository
{
    public class TaskRepository : BaseRepository<TaskEntity>
    {
        public TaskRepository(AppDbContext context) : base(context)
        {
        }
    }
}
