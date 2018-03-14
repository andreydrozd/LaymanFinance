using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.EntityFrameworkCore;
using LaymanFinance.Models;
using SendGrid;

namespace LaymanFinance.Controllers
{
    public class AccountController : Controller
    {
        private SignInManager<ApplicationUser> _signInManager;
        private SendGridClient _sendGridClient;
        private LaymanFinanceContext _context;

        public AccountController(SignInManager<ApplicationUser> signInManager, SendGridClient sendGridClient, LaymanFinanceContext context)
        {
            _signInManager = signInManager;
            _sendGridClient = sendGridClient;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var applicationUser = await _context.Users.SingleOrDefaultAsync(x => x.Id == userId);
            return View(applicationUser);
        }

        // GET: Account/Edit
        public async Task<IActionResult> Edit()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var applicationUser = await _context.Users.SingleOrDefaultAsync(x => x.Id == userId);
            return View(applicationUser);
        }

        // POST: Account/Edit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var existingRecord = await _context.Users.SingleOrDefaultAsync(x => x.Id == userId);
                existingRecord.FirstName = applicationUser.FirstName;
                existingRecord.LastName = applicationUser.LastName;
                existingRecord.PhoneNumber = applicationUser.PhoneNumber;

                _context.Update(existingRecord);
                await _context.SaveChangesAsync();
              
                return RedirectToAction("Index");
            }
            return View(applicationUser);
        }


        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(string username, string password)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser newUser = new ApplicationUser { UserName = username, Email = username };

                var userResult = await _signInManager.UserManager.CreateAsync(newUser);

                if (userResult.Succeeded)
                {
                    var passwordResult = await _signInManager.UserManager.AddPasswordAsync(newUser, password);
                    if (passwordResult.Succeeded)
                    {
                        SendGrid.Helpers.Mail.SendGridMessage message = new SendGrid.Helpers.Mail.SendGridMessage();
                        message.AddTo(username);
                        message.Subject = "Welcome to Layman Finance!";
                        message.SetFrom("laymanadmin@codingtemple.com");
                        message.AddContent("text/plain", "Welcome to LaymanFinance, " + username + ". Get ready to take control of your finances.");
                        await _sendGridClient.SendEmailAsync(message);

                        await _signInManager.SignInAsync(newUser, isPersistent: false);
                        return RedirectToAction("Index", "Account");
                    }
                    else
                    {
                        foreach (var error in passwordResult.Errors)
                        {
                            ModelState.AddModelError(error.Code, error.Description);
                        }
                        await _signInManager.UserManager.DeleteAsync(newUser);
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
        public async Task<IActionResult> Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(username, password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return View();
                }
            }
            return View();
        }

        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ForgotPassword(string email)
        {

            var user = await _signInManager.UserManager.FindByEmailAsync(email);

            if(user != null)
            {
                string token = await _signInManager.UserManager.GeneratePasswordResetTokenAsync(user);
                token = System.Net.WebUtility.UrlEncode(token);
                string currentUrl = Request.GetDisplayUrl(); // This will get the URL for the current request.
                Uri uri = new Uri(currentUrl); // This will wrap the current url into a "URI" object so I can split it into parts.
                string resetUrl = uri.GetLeftPart(UriPartial.Authority); // This gives just the scheme and authority of the URI.
                resetUrl += "/account/resetpassword?id=" + token + "&email=" + email;

                SendGrid.Helpers.Mail.SendGridMessage message = new SendGrid.Helpers.Mail.SendGridMessage();
                message.AddTo(email);
                message.Subject = "Password reset instructions";
                message.SetFrom("laymanadmin@codingtemple.com");
                message.AddContent("text/plain", resetUrl);
                message.AddContent("text/html", string.Format("<a href='{0}'>{0}</a>", resetUrl));
                await _sendGridClient.SendEmailAsync(message);
            }
            return RedirectToAction("ResetSent");
        }

        [AllowAnonymous]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> ResetPassword (string token, string email, string password)
        {
            string originalToken = token;
            var user = await _signInManager.UserManager.FindByEmailAsync(email);
            if(user != null)
            {
                var result = await _signInManager.UserManager.ResetPasswordAsync(user, originalToken, password);
                if (result.Succeeded)
                {
                    RedirectToAction("Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View();
        }

        private bool ApplicationUserExists()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return _context.ApplicationUser.Any(x => x.Id == userId);
        }
    }
}