using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace HSPXL2.Pages.Admin
{
  //  [Authorize(Policy = "Admin")]

    public class DeleteUserModel : PageModel
    {
        public UserManager<IdentityUser> UserManager;

        public DeleteUserModel(UserManager<IdentityUser> usrManager)
        {
            UserManager = usrManager;
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

        public async void OnGetAsync(string id)
        {
            IdentityUser user = await UserManager.FindByIdAsync(id);
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            IdentityUser user = await UserManager.FindByIdAsync(Id);
            await UserManager.DeleteAsync(user);

            return RedirectToPage("Users");
        }
    }
}
