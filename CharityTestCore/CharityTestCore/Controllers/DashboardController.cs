using CharityTestCore.Models;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.MBTI;
using CharityTestCore.Service.UserManagment;
using DAL.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
    [Authorize]
    public class DashboardController : BaseController

    {
        private readonly IEPTService eptservice;
        private readonly IMBTIService mBTIService;
        private readonly IUserService _userService;
        public DashboardController(IEPTService _eptservice,IMBTIService _mBTIService,IUserService userService)
        {
            eptservice = _eptservice;
            mBTIService = _mBTIService;
            _userService = userService;
        }
        [Authorize(Roles ="admin")]
        public IActionResult Index(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(eptservice.EptPersonList(id));
        }
        public IActionResult UserProfile(Guid? id)
        {

            string idd = OnGetUserId();
            ViewBag.UserNameAndFamily = _userService.GetProfile(idd).FullName;
            return View();
        }


        public IActionResult EPTDelete(Guid? id)
        {

           var ep = eptservice.EptPersonById(id);
            EPTQuestion ept = new EPTQuestion()
            {

            };

            //ept.Name = ep.Name;
            //ept.Family = ep.Family;
            //ept.Name = "";
            //ept.Family = "";
            ept.Id = ep.Id;
            return View(ept);

        }
     
        public IActionResult EPTIsDelete(Guid? id)
        {
            eptservice.EptPersonDeleteById(id);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("Index", null);
        }
      
        public IActionResult MBTI(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(mBTIService.MBTIPersonList(id   ));
        }
       
        public IActionResult MBTIDelete(Guid? id)
        {

            var ep = mBTIService.MBTIPersonById(id  );
            MBTIQuestionListModel ept = new MBTIQuestionListModel()
            {

            };

            ept.Id = ep.Id;
            return View(ept);

        }
      
        public IActionResult MBTIIsDelete(Guid? id)
        {
            mBTIService.MBTIPersonDeleteById(id);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("MBTI", null);
        }
    }
}
