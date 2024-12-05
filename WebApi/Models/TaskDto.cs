using System.ComponentModel.DataAnnotations;
using ToDoListApi.Enums;

namespace WebApi.Models
{
    public class TaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public Priority Priority { get; set; }
        public DateTime LastUpdateTime { get; set; } = DateTime.Now.Date;

       // [Required]
        //[DataType(DataType.Date)]
       // [FutureDate(ErrorMessage = "Deadline must be in the future.")]
        public DateTime DeadLine { get; set; }
    }

/*    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dateTime)
            {
                return dateTime > DateTime.Now;
            }
            return false;
        }
    }*/
}
