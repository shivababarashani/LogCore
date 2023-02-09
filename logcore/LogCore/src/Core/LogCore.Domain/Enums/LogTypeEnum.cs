using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogCore.Domain.Enums
{
    public enum LogTypeEnum
    {

        [Display(Name = "اشکال زدایی")]
        Debug = 1,

        [Display(Name = "اطلاعات")]
        Information = 2,

        [Display(Name = "خطا")]
        Error = 3,
    }
}
