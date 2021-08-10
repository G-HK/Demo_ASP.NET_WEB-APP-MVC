using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using HSPXL2.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HSPXL2.Pages.Admin
{
    //[Authorize(Roles = "Admin")]
    public class EditUserModel : PageModel
    {
        public UserManager<IdentityUser> UserManager;
        public readonly RoleManager<IdentityRole> Role;
        public readonly IdentityContext _Context;
        private IPasswordHasher<IdentityUser> _passwordHasher;


        public EditUserModel(UserManager<IdentityUser> usrManager ,RoleManager<IdentityRole> role, IdentityContext Context, IPasswordHasher<IdentityUser> passwordHasher)
        {
            _Context = Context;
            UserManager = usrManager;
            Role = role;
            _passwordHasher = passwordHasher;
        }

        [BindProperty]
        [Required]
        [Parameter]
        public string Id { get; set; }


        [BindProperty]
        [Required]
        public string UserName { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public List<IdentityRole> RoleName { get; set; }


        public async Task OnGetAsync(string id)
        {
            IdentityUser user = await UserManager.FindByIdAsync(id);
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;


            //ViewData["Role"] = new SelectList(_Context.Roles, "HandboekID", "Title", cursus.HandboekID);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await UserManager.FindByIdAsync(Id);
                user.UserName = UserName;
                user.Email = Email;
                user.PasswordHash = _passwordHasher.HashPassword(user, Password);


                // IdentityResult bewaart het succes van het uitvoeren van UpdateAsync()
                IdentityResult result = await UserManager.UpdateAsync(user);
                if (result.Succeeded && !String.IsNullOrEmpty(Password))
                {
                    return RedirectToAction("Index","Home");
                }

                foreach (IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return Page();
        }

    }
}
