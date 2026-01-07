using System.ComponentModel.DataAnnotations;

namespace BugTracker.ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [StringLength(20, MinimumLength = 8,ErrorMessage= "Please enter at least 8 and at max 20 characters")]
        [DataType(DataType.Password)]

        public string Password { get; set; }
        [Required(ErrorMessage ="Please enter your password again")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = " passwords do not match")]

        public string ConfirmPassword { get; set;}

    }
}
