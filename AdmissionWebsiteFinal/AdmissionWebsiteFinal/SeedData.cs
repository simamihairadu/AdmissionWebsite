using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionWebsiteFinal
{
    public static class SeedData
    {
        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Admin"
                };

                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync("Employee").Result)
            {
                var role = new IdentityRole
                {
                    Name = "Employee"
                };

                var result = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync("ContestantAccount").Result)
            {
                var role = new IdentityRole
                {
                    Name = "ContestantAccount"
                };

                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}
