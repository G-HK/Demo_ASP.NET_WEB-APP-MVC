using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HSPXL2.Pages.User
{
    public class UserDetailModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public UserDetailModel(UserManager<IdentityUser> usrManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = usrManager;
            _roleManager = roleManager;
        }

        [BindProperty]
        [Required]
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
        public string Role { get; set; }



        public async Task OnGetAsync(string id = null)
        {
            IdentityUser user = null;
            if (id == null)
            {
                user = await _userManager.GetUserAsync(HttpContext.User);
            }
            else
            {
                user = await _userManager.FindByIdAsync(id);
            }
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;
            Password = user.PasswordHash;
            //840c9335-1ce9-4813-9385-b3c80205a5f3

        }
    }
}
