using System.ComponentModel.DataAnnotations;

namespace BugTracker.ViewModel
{
    public class VerifyEmailModel
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public String  Email{ get; set; }

    }
}