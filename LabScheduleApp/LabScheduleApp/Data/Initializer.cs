using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabScheduleApp.Data
{
    public static class Initializer
    {
        public static async Task initial(RoleManager<IdentityRole> roleManager)
        {
            if(!await roleManager.RoleExistsAsync("Admin"))
            {
                var users = new IdentityRole("Admin");
                await roleManager.CreateAsync(users);
            }
            if (!await roleManager.RoleExistsAsync("Teacher"))
            {
                var users = new IdentityRole("Teacher");
                await roleManager.CreateAsync(users);
            }
            if (!await roleManager.RoleExistsAsync("Student"))
            {
                var users = new IdentityRole("Student");
                await roleManager.CreateAsync(users);
            }
        }
    }
}
