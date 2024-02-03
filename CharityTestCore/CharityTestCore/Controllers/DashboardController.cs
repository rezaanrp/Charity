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
        public IActionResult Index()
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View();
        }
		[HttpPost]
		public JsonResult load_data_users2(int id)
		{
			int totalRecord = 0;
			int filterRecord = 0;

			var draw = Request.Form["draw"].FirstOrDefault();


			var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();


			var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();


			var searchValue = Request.Form["search[value]"].FirstOrDefault();


			int pageSize = Convert.ToInt32(Request.Form["length"].FirstOrDefault() ?? "0");


			int skip = Convert.ToInt32(Request.Form["start"].FirstOrDefault() ?? "0");



			var data = _userService.GetAllUser();


			totalRecord = data.Count();

			if (!string.IsNullOrEmpty(searchValue))
			{
				data = data.Where(y => y.NationalNumber.Contains(searchValue)).ToList();

			}

			filterRecord = data.Count();

			var empList = data.Skip(skip).Take(pageSize).ToList();

			var returnObj = new { draw = draw, recordsTotal = totalRecord, recordsFiltered = filterRecord, data = empList };
			return Json(returnObj);

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

        public IActionResult Ept(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(eptservice.EptPersonList(id));
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
