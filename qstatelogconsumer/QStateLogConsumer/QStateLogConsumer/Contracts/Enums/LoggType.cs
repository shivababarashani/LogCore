using System.ComponentModel.DataAnnotations;

namespace QStateLogConsumer.Contracts.Dto.Enums
{
    public enum LoggType
    {
        [Display(Name = "اشکال زدایی")]
        Debug = 1,

        [Display(Name = "اطلاعات")]
        Information = 2,

        [Display(Name = "خطا")]
        Error = 3,

    }
}
