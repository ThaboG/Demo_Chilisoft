using Demo.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UserService = Demo.Service.Logic.UserService;

namespace Demo.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserService userService;
        public AccountController(UserService userService)
        {
            this.userService = userService;
        }
        public async Task<ActionResult> Login(string ReturnUrl = null)
        {
            HttpContext.Session.Clear();
            ReturnUrl = "Users";
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View(new Login() { ReturnUrl = ReturnUrl });
            //return View(new DAL.DTO.Login() { ReturnUrl = ReturnUrl, Username = "rhyno.linde@spar.co.za", Password  = "0", IsRememberMe = true }  );
        }

        // POST: Account/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(Login login)
        {
            try
            {


                var Res = userService.Login(login.Username, login.Password);

                HttpContext.SetUserType(Res);

                var claims2 = new List<Claim>
                {
                    new Claim("user", Res.IsAdmin ? $"{Res.UserAdminRel?.Admin?.Firstname} {Res.UserAdminRel?.Admin?.Lastname}" 
                    : Res.IsEmployee ? $"{Res.UserEmployeeRel?.Employee?.Firstname} {Res.UserEmployeeRel?.Employee?.Lastname}" 
                    : $"{Res.GeneralUserRel?.GeneralUser?.Firstname} {Res.GeneralUserRel?.GeneralUser?.Lastname}" ),
                    new Claim("role", "Member"),
                    new Claim("UserID", Res.ID.ToString())
                };
                var claimsIdentity = new ClaimsIdentity(claims2, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                    RedirectUri = this.Request.Host.Value
                };

                await HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                return RedirectToAction("Index", "Books");

            }
            catch (Exception Exc)
            {
                ModelState.AddModelError(string.Empty, Exc.Message);
                return View(login);
            }
        }

        public ActionResult Denied()
        {
            return View(new Login());
        }
    }
}
