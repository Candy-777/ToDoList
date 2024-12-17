using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum Priority
    {
        [Display(Name = "Низкий")]
        Low = 1,
        [Display(Name = "Средний")]
        Medium = 2,
        [Display(Name = "Высокий")]
        High = 3
    }
}
