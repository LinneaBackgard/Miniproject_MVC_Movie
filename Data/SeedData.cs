using Microsoft.AspNetCore.Identity;

namespace Miniproject_MVC_Movie.Data
{
    public static class SeedData
    {
        public static async Task EnsureAdminAsync(IServiceProvider services)
        {
            const string adminRole = "Admin";
            const string adminEmail = "admin@movieapp.test";
            const string adminPassword = "Admin123!";

            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<IdentityUser>>();

            // 1) Skapa rollen "Admin" om den inte finns
            if (!await roleManager.RoleExistsAsync(adminRole))
            {
                await roleManager.CreateAsync(new IdentityRole(adminRole));
            }

            // 2) Skapa admin-användaren om den inte finns
            var adminUser = await userManager.FindByEmailAsync(adminEmail);
            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(adminUser, adminPassword);
            }

            // 3) Lägg admin-användaren i Admin-rollen
            if (!await userManager.IsInRoleAsync(adminUser, adminRole))
            {
                await userManager.AddToRoleAsync(adminUser, adminRole);
            }
        }
    }
}
