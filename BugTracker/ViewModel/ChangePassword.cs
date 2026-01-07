using System.ComponentModel.DataAnnotations;

namespace BugTracker.ViewModel
{
    public class ChangePassword
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public String Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Please enter at least 8 and at max 20 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Enter New Passowrd")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Enter the same password again to confirm")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = " passwords do not match")]
        [Display (Name="Confirm New Passowrd")]
        public string ConfirmNewPassword { get; set; }

    }
}
