using CharityTestCore.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using CharityTestCore.Service.UserManagment;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Service.EPT;
using CharityTestCore.Repository.UserManagment;

namespace CharityTestCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService userService;
        private readonly IUserRepository userRepository;
        public AccountController(IUserService _userService,IUserRepository _userRepository) 
        {
            userService = _userService;
            userRepository = _userRepository;
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
            var user = userService.Authenticate(loginModel.UserName, loginModel.Password, userRepository);
            if (user != null)
            {
                var claim = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,user.UserName ),
                    new Claim(ClaimTypes.SerialNumber,user.Id.ToString())
                };
                var identity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties
                {
                   // IsPersistent = login.RememberMe
                };

                HttpContext.SignInAsync(principal, properties);
                return RedirectToAction("Index","Dashboard");
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
            bool result = userService.ChangePassword(User.Identity.Name, model.OldPassword, model.NewPassword, userRepository);
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
