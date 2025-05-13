using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using CharityTestCore.Service.UserManagment;
using DAL.DataBase;
using Domain.Model;
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
        [Authorize(Roles = "admin,superadmin")]
        public IActionResult Index()
        {
            var userlist = new List<User>();
            using (var context  = new ParkerCharityContext())
            {
                userlist = context.Users.ToList();

            }
            return View(userlist);
        }
        [Authorize(Roles = "admin,superadmin")]
        public IActionResult Edit(string id)
        {
            var m = _userService.GetByIdUserListModel(id);
            return View(m);
        }
		[HttpPost]

		public IActionResult Edit(Models.UserListModel userListModel)
		{
            if( _userService.EditUser(userListModel))
            {
				return RedirectToAction("Index", "Dashboard");
			}
			else 
            {
				ViewBag.ErrorMessage = "خطا در ثبت";
				return View(userListModel); 
            }
		}
		public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.UserListModel userListModel )
        {
            if (_userService.CountUserName(userListModel.UserName) > 0)
            {
                ViewBag.ErrorMessage = "نام کاربری قبلا در سیستم ثبت شده است";
                return View();
            }
            if (_userService.CountNationalNumber(userListModel.NationalNumber) > 0)
            {
                ViewBag.ErrorMessage = "کد ملی قبلا در سیستم ثبت شده  ";
                return View();

            }
            if (_userService.CountMobile(userListModel.MobileNumber) > 0)
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
