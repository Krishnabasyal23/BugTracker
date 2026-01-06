using BugTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Data.Seeders

{
    public class AdminUserSeeder

    {
        public static async Task SeedAdminAsync(
        UserManager<ApplicationUser> userManager)
        {
            Console.WriteLine("Adminuserseeder starting");
            string adminEmail = "admin@email.com";
            string adminPassword = "Admin@123";
            // to check if admin already exists
            var adminUser = await userManager.FindByEmailAsync("admin@email.com");
            if (adminUser != null)
            {
                Console.WriteLine("Admin already exists.");
                return;
            
            }

            adminUser = new ApplicationUser
            {
                UserName = "admin@email.com",
                Email = "admin@email.com",
                EmailConfirmed = true,
                FullName="System Administrator"
            }; 
            var result = await userManager.CreateAsync(adminUser, adminPassword);

            if (result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    Console.WriteLine($"Error creating admin:{error.Description}");
                }
                return;
            }
            await userManager.AddToRoleAsync(adminUser, "Admin");

            Console.WriteLine("Admin user created successfully");
        }
    }
}
