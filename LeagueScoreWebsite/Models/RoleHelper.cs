using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueScoreWebsite.Models
{
#nullable disable
    public static class RoleHelper
    {
        public const string Admin = "Admin";
        public const string SquadLeader = "SquadLeader";
        public static async Task CreateRoles(IServiceProvider provider, params string[] roles)
        {
            RoleManager<IdentityRole> roleManager = provider.GetService<RoleManager<IdentityRole>>();
            foreach(string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
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
                    UserName = "Admin"
                };

                await userManager.CreateAsync(defaultUser, "thisisTHEadminPassw0rd!");

                await userManager.AddToRoleAsync(defaultUser, role);
            }
        }

    }


}
