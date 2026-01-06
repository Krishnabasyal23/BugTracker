
using Microsoft.AspNetCore.Identity; 
namespace BugTracker.Models
{
    public class ApplicationUser:IdentityUser
    {
        public String FullName { get; set; }
    }
}
