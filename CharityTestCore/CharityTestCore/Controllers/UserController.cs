using CharityTestCore.Repository;
using CharityTestCore.Repository.UserManagment;
using CharityTestCore.Service.UserManagment;
using DAL.DataBase;
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
        public IActionResult Index()
        {
            var userlist = new List<User>();
            using (var context  = new ParkerCharityContext())
            {
                userlist = context.Users.ToList();

            }
            return View(userlist);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.UserListModel userListModel )
        {

            _userService.AddUser(userListModel.UserName,
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
