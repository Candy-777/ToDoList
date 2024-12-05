using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Enums;


namespace UI.Http_Client
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }

        [DataType(DataType.Date)]
        public DateTime LastUpdateTime { get; set; } = DateTime.Now;
        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }
    }
}
