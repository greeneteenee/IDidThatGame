using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDidThatGame.Models
{
    public static class IdentityHelper
    {
        //set constant variable for name of roles
        public const string AdministratorRole = "Administrator";
        public const string RegisteredUserRole = "Registered user";

        public static void SetIdentityOptions(IdentityOptions options)
        {
            //Set sign in options
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;

            //Set password strength
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
        }

        public static async Task CreateRoles(IServiceProvider serviceProvider, params string[] roles)

        {
            RoleManager<IdentityRole> roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //create role if it does not exist
            foreach (string role in roles)
            {
                bool doesRoleExist = await roleManager.RoleExistsAsync(role);
                if (!doesRoleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        internal static async Task CreateDefaultAdministrator(IServiceProvider serviceProvider)
        {
            const string email = "admin@ididthatgame.com";
            const string username = "admin@ididthatgame.com";
            const string password = "password";

            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            //Create a new default administrator if there are no user with AdmnistratorRole in database
            if(userManager.GetUsersInRoleAsync(IdentityHelper.AdministratorRole).Result.Count() == 0)
            {
                IdentityUser administrator = new IdentityUser()
                {
                    Email = email, UserName = username                    
                };

                await userManager.CreateAsync(administrator, password);
                await userManager.AddToRoleAsync(administrator, AdministratorRole);

            }
        }
    }
}
