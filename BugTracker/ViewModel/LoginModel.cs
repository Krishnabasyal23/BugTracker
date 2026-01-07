
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace BugTracker.ViewModel
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress]
        public string Email { get; set; }

       // public string Username { get; set; }

        [Required (ErrorMessage ="Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        [Display(Name= "Remember Me?")]
        public bool RememberMe { get; set; }
        
    }
}
