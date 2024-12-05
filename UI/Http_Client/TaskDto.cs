using System.ComponentModel.DataAnnotations;
using UI.Enums;

namespace Http_Client
{
    public class TaskDto
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        [Required]
        public Priority Priority { get; set; }

        [Required]
        public DateTime LastUpdateTime { get; set; } = DateTime.Now.Date;

        [Required]
        [DataType(DataType.Date)]
        [FutureDate(ErrorMessage = "Deadline must be in the future.")]
        public DateTime DeadLine { get; set; }
    }

    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is DateTime dateTime)
            {
                return dateTime > DateTime.Now;
            }
            return false;
        }
    }
}
