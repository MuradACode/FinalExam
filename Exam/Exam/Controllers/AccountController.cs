using DAL.Models;
using Exam.Helpers;
using Exam.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace Exam.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [Route("Register")]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [Route("Register")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All fields are required");
                return View();
            }

            AppUser newUser = new AppUser()
            {
                Firstname = register.Firstname,
                Lastname = register.Lastname,
                UserName = register.UserName,
                Email = register.Email,
            };

            IdentityResult result = await _userManager.CreateAsync(newUser, register.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                    return View();
                }
            }

            await _userManager.AddToRoleAsync(newUser, Enums.Roles.Member.ToString());

            await _signInManager.SignInAsync(newUser, false);

            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }

        [Route("Login")]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [Route("Login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "All fields are required");
                return View();
            }

            AppUser user = await _userManager.FindByNameAsync(login.UserName);

            if (user == null)
            {
                ModelState.AddModelError("", "User doesn't exists");
                return View();
            }

            SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, login.IsPersistent, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Password is wrong");
            }

            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(controllerName: "Home", actionName: "Index");
        }

        public async Task CreateRoles()
        {
            foreach (var role in Enum.GetNames(typeof(Enums.Roles)))
            {
                if (!await _roleManager.RoleExistsAsync(role))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }
    }
}
