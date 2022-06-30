using System.ComponentModel.DataAnnotations;

namespace Exam.ViewModels
{
    public class LoginVM
    {
        [Required, MaxLength(100)]
        public string UserName { get; set; }

        [Required, MaxLength(100), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public bool IsPersistent { get; set; }

    }
}
