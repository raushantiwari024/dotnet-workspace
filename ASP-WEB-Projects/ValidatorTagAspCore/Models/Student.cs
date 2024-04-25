using System.ComponentModel.DataAnnotations;

namespace ValidatorTagAspCore.Models
{
    public class Student
    {
        [Required(ErrorMessage="Name is must")]
        public string Name { get; set; }
        [Required(ErrorMessage="Name is must")]
        public int? Age { get; set; }
        [Required(ErrorMessage="Name is must")]
        public ulong? Contact { get; set; }
        // [Required(ErrorMessage="This field can not be null")]
        // // [StringLength(30, MinimumLength = 2,ErrorMessage="Length Must be between 2-30")]
        // [MinLength(3)]
        // [MaxLength(20)]
        // public string Name { get; set; }

        // // [EmailAddress]
        // [Required(ErrorMessage="This field dan not be empty")]
        // [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        // public string Email { get; set; }

        // [Required]
        // [Range(10,20)]
        // public int? Age { get; set; }

        // [Required]
        // [RegularExpression(@"^(?=.*[0-9]).{10,10}$")]
        // public ulong? Contact { get; set; }

        // [Required]
        // [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",ErrorMessage="Password is weak, Try again")]
        // public string Password { get; set; }

        // [Required(ErrorMessage="ConfirmPassword can not be empty")]
        // [Compare("Password",ErrorMessage="Both password must be identical")]
        // [Display(Name = "Enter Confirm Password")]
        // public string ConfirmPassword { get; set; }

        // [Required]
        // [Url(ErrorMessage="Enter valid url")]
        // public string WebUrl { get; set; }
    }
}