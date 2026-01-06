using Microsoft.AspNetCore.Identity;
namespace BugTracker.Data
{
    public  class RoleSeeder
    {
        public static async Task SeedRoleAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] Roles =
            {
                "Admin",
                "Project Manager",
                "Developer",
                "Submitter"
            };
                
               foreach(var role in Roles)
            {
                if(!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));

                }
            }

        }
    }
}
