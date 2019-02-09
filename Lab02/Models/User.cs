using System.ComponentModel.DataAnnotations;

namespace Lab02.Models
{
    [FluentValidation.Attributes.Validator(typeof(UserValidator))]
    public class User
    {
        [Display(Name = "UserName")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string ConfirmPassword { get; set; }
    }
}