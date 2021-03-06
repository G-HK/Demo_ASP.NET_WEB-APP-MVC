using HSPXL2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HSPXL2.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly ILogger<AccountController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<IdentityUser> userManager,  SignInManager<IdentityUser> signInManager, ILogger<AccountController> logger, RoleManager<IdentityRole> role)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = role;
            _logger = logger;

        }
        public ViewResult Login(string returnUrl)
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login( [Bind("Password, Email")] LoginModel loginModel)
        {

            if (ModelState.IsValid)
            {

                IdentityUser user = await _userManager.FindByEmailAsync(loginModel.Email);

                if (user != null)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    if ((await _signInManager.PasswordSignInAsync(user, loginModel.Password, false, false)).Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }


            ModelState.AddModelError("", "Invalid name or password");
            return View();
        }


        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ViewResult Register()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.UserName, Email = model.Email };
             //   IdentityUser user = new IdentityUser { UserName = regisModel.Name, Email = regisModel.Email };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {

                    var userOutDb = await _userManager.FindByEmailAsync(model.Email);

                    var identityRole = await _roleManager.FindByNameAsync("Student");

                    await _userManager.AddToRoleAsync(userOutDb, identityRole.Name);

                    await _signInManager.SignInAsync(user, isPersistent: false); 

                    return RedirectToAction("Index", "home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    _logger.LogError($"{error} this object cause error re-check input or code");
                }
            }
            return View();
        }
    }
}
