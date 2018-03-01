using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using LaymanFinance.Models;

namespace LaymanFinance.Controllers
{
    public class AccountController : Controller
    {
        //Using Microsoft.AspNetCore.Identity
        private SignInManager<ApplicationUser> _signInManager;
        public AccountController(SignInManager<ApplicationUser> signInManager)
        {
            this._signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return Content("You can only see this if you're signed in!");
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult Register(string username, string password)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser newUser = new ApplicationUser { UserName = username };

                var userResult = _signInManager.UserManager.CreateAsync(newUser).Result;

                if (userResult.Succeeded)
                {
                    var passwordResult = _signInManager.UserManager.AddPasswordAsync(newUser, password).Result;
                    if (passwordResult.Succeeded)
                    {
                        _signInManager.SignInAsync(newUser, isPersistent: false).Wait();
                        return RedirectToAction("AuthorizedHome", "Home");
                    }
                    else
                    {
                        foreach (var error in passwordResult.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                        _signInManager.UserManager.DeleteAsync(newUser).Wait();
                    }
                }
                else
                {
                    foreach (var error in userResult.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(username, password, isPersistent: false, lockoutOnFailure: false).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("AuthorizedHome", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
            }
            return View();
        }
    }
}