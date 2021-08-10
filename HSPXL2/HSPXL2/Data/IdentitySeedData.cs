using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Data
{
    public static class IdentitySeedData
    {

        private const string adminUser = "Admin";
        private const string adminPassword = "Admin1234$";

        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            IdentityContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<IdentityContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }


            UserManager<IdentityUser> userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            RoleManager<IdentityRole> roleManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            IdentityRole roleAdmin = await roleManager.FindByNameAsync("Admin");
            IdentityRole roleStudent = await roleManager.FindByNameAsync("Student");
            IdentityRole roleTeacher = await roleManager.FindByNameAsync("Teacher");

            //check if admin exists
            IdentityUser Admin = await userManager.FindByNameAsync(adminUser);


            //Create Admin Role.
            if (roleAdmin == null)
            {
                roleAdmin = new IdentityRole();
                roleAdmin.Name = "Admin";
                await roleManager.CreateAsync(roleAdmin);
            }

            //Create Student Role.
            if (roleStudent == null)
            {
                roleStudent = new IdentityRole();
                roleStudent.Name = "Student";
                await roleManager.CreateAsync(roleStudent);
            }

            //Create Techer Role.
            if (roleTeacher == null)
            {
                roleTeacher = new IdentityRole();
                roleTeacher.Name = "Teacher";
                await roleManager.CreateAsync(roleTeacher);
            }

            //check if admin exists, if not : create Admin user with admin Role
            if (Admin == null)
            {
                Admin = new IdentityUser("Admin");
                Admin.Email = "admin@admin.com";
                Admin.PhoneNumber = "888-4213";
                await userManager.CreateAsync(Admin, adminPassword);
                await userManager.AddToRoleAsync(Admin, "Admin");
            }

            //TestUser
            IdentityUser Testuser = new IdentityUser {
                UserName = "JK",
                Email = "test@user.com"            
            };
            await userManager.CreateAsync(Testuser, "Test123!");
            await userManager.AddToRoleAsync(Testuser, "Student");


        }
    }
}
 