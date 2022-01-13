using Microsoft.AspNetCore.Identity;

namespace LeagueScoreWebsite.Data
{
    public class IdentityHelper
    {
        // SetIdentityOptions make this happen


        public const string Admin = "admin";
        public const string Member = "member";


        internal static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

            IdentityResult roleResult;

            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        public static async Task CreateDefaultUser(IServiceProvider provider, string role)
        {
            var userManager = provider.GetService<UserManager<IdentityUser>>();

            // if no users are present make default user
            int numUsers = (await userManager.GetUsersInRoleAsync(role)).Count;
            if (numUsers == 0) // if no users are in the specified role
            {
                var defaultUser = new IdentityUser()
                {
                    Email = "admin@leaguescoresite.com",
                    // UserName = "Admin"
                };

                await userManager.CreateAsync(defaultUser, "thisisTHEadminPassw0rd!");

                await userManager.AddToRoleAsync(defaultUser, role);
            }
        }
    }
}
