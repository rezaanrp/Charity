using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using CharityTestCore.Service.UserManagment;
using DAL.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;

namespace CharityTestCore.Controllers
{
    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [Authorize(Roles = "admin")]
        public IActionResult Index()
        {
            var userlist = new List<User>();
            using (var context  = new ParkerCharityContext())
            {
                userlist = context.Users.ToList();

            }
            return View(userlist);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Edit()
        {

            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.UserListModel userListModel )
        {
            if (_userService.IsExistUserName(userListModel.UserName))
            {
                ViewBag.ErrorMessage = "نام کاربری قبلا در سیستم ثبت شده است";
                return View();
            }
            if (_userService.IsExistNationalNumber(userListModel.NationalNumber))
            {
                ViewBag.ErrorMessage = "کد ملی قبلا در سیستم ثبت شده  ";

                return View();

            }
            if (_userService.IsExistMobile(userListModel.MobileNumber))
            {
                ViewBag.ErrorMessage = "تلفن همراه  قبلا در سیستم ثبت شده است";

                return View();

            }

            _userService.AddUser(userListModel.UserName.ToLower(),
                userListModel.Password,
                userListModel.Name,
                userListModel.Family,
                "user",
                userListModel.NationalNumber,userListModel.MobileNumber
               );
            return RedirectToAction("Index","Home");
        }
    }
}
