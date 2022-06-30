using System.ComponentModel.DataAnnotations;

namespace Exam.ViewModels
{
    public class RegisterVM
    {
        [Required, MaxLength(100)]
        public string Firstname { get; set; }

        [Required, MaxLength(100)]
        public string Lastname { get; set; }

        [Required, MaxLength(100)]
        public string UserName { get; set; }

        [Required, MaxLength(100), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, MaxLength(100), DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, MaxLength(100), DataType(DataType.Password), Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
