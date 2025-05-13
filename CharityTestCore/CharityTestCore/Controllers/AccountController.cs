using CharityTestCore.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using CharityTestCore.Service.UserManagment;

namespace CharityTestCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        public AccountController(IUserService _userService) 
        {
            userService = _userService;
        }
      public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Login")]
        public IActionResult Login()
        {
            ViewBag.Title = "صفحه ورود";

            return View();
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }
            var user = userService.Authenticate(loginModel.UserName, loginModel.Password);
            if (user != null)
            {
                var claim = new List<Claim>()
{
    new Claim(ClaimTypes.Name, user.UserName.ToString()),
    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
    new Claim(ClaimTypes.SerialNumber, user.Id.ToString()),
    new Claim(ClaimTypes.Role, user.Role),

    new Claim("FirstName", user.Name ?? ""),
    new Claim("LastName", user.Family ?? "")
};

                var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties
                {
                    IsPersistent = true
                };

                HttpContext.SignInAsync( principal, properties);
                if(user.Role == "admin")
                return RedirectToAction("Index","Dashboard");
                else if(user.Role == "superadmin")
                {
                    return RedirectToAction("Admin", "Dashboard");

                }
                else
                {
                    return RedirectToAction("UserProfile", "Dashboard");

                }
            }
            else
            {
                ViewBag.ErrorMessage = "نام کاربری یا پسورد درست نمی باشد";
			   // ModelState.AddModelError("Email", "چنین کاربری یافت نشد");
			}
            return View();
        }

        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Home");
        }
        [Authorize]
        public IActionResult ChangePassword()
        {

            return View();

        }
        [Authorize]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordInformation model)
        {

            if (!ModelState.IsValid)
                return View(model);
            bool result = userService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword);
            if (result == true)
            {
                ViewBag.SuccessfulMessage = "رمز با موفقیت تغییر کرد";
                return View(model);
            }

            ViewBag.ErrorMessage = "رمز قبلی اشتباه است";
            return View(model);
        }
    }
}
