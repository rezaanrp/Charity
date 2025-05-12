using CharityTestCore.Models;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.MBTI;
using CharityTestCore.Service.UserManagment;
using DAL.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        [Authorize(Roles ="admin,superadmin")]
        public IActionResult Index()
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View();
        }
        [Authorize(Roles = "superadmin")]
        public IActionResult Admin()
        {
            ViewBag.UsserNameAndFamily = "سوپر سیستم ";

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "superadmin")]
        public JsonResult load_data_superadmin(int id)
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
        [HttpPost]
        [Authorize(Roles = "admin,superadmin")]
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
            var mbtiType = Request.Form["mbtiType"].FirstOrDefault();

            var data = _userService.GetAllByQuizUser();

            if (!string.IsNullOrEmpty(mbtiType))
            {
                data = data.Where(y => y.MbtiResult == mbtiType).ToList();
            }

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
            Guid userId = OnGetUserGuid(); // فرض بر اینکه Guid برمی‌گردونه
            string userIds = OnGetUserId(); // فرض بر اینکه Guid برمی‌گردونه

            var model_mbti = mBTIService.GetByUserId(userId);
            var model_ept = eptservice.GetEptByUserId(userIds);

            ViewBag.HasMBTI = model_mbti != null;
            ViewBag.HasEPT = model_ept != null;

            var profile = _userService.GetProfile(userIds); // فرض بر اینکه ورودی Guid می‌گیره
            ViewBag.FullName = profile?.FullName ?? "کاربر محترم";
            ViewBag.LastLogin = profile?.LastLoginDateFarsi;
            ViewBag.JoinDate = profile?.CreatedDateFarsi;
            var profilePercent = CalculateProfileCompletion(profile, model_mbti != null, model_ept != null);
            ViewBag.ProfilePercent = profilePercent;

            return View();
        }
        public int CalculateProfileCompletion(UserProfileModel user, bool HasMBTI, bool HasEPT)
        {
            int totalFields = 8;
            int completedFields = 0;

            if (!string.IsNullOrWhiteSpace(user.Name)) completedFields++;
            if (!string.IsNullOrWhiteSpace(user.Family)) completedFields++;
            if (!string.IsNullOrWhiteSpace(user.NationalNumber)) completedFields++;
            if (!string.IsNullOrWhiteSpace(user.MobileNumber)) completedFields++;
            if (!string.IsNullOrWhiteSpace(user.UserName)) completedFields++;
            if (!string.IsNullOrWhiteSpace(user.Role)) completedFields++;
            if (HasMBTI) completedFields++;
            if (HasEPT) completedFields++;

            return (int)((completedFields / (double)totalFields) * 100);
        }

        public IActionResult MyProfile()
        {
            Guid userId = OnGetUserGuid(); // فرض بر اینکه Guid برمی‌گردونه
            string userIds = OnGetUserId(); // فرض بر اینکه Guid برمی‌گردونه
            var profile = _userService.GetProfile(userIds); // فرض بر اینکه ورودی Guid می‌گیره
            ViewData["IsReadOnly"] = false;
            return View(profile);
        }
        [HttpPost]
        public async Task<IActionResult> SaveMyProfile(UserProfileModel model)
        {
            if (!ModelState.IsValid)
                return View("MyProfile", model);

            var userId = OnGetUserGuid();

            var result = await _userService.UpdateProfileAsync(model, userId);

            if (!result)
            {
                ModelState.AddModelError("", "خطا در ذخیره اطلاعات.");
                return View("MyProfile", model);
            }

            TempData["SuccessMessage"] = "پروفایل با موفقیت ذخیره شد.";
            return RedirectToAction("UserProfile");
        }
        //public IActionResult EPTDelete(Guid? id)
        //{

        //   var ep = eptservice.EptPersonById(id);
        //    EPTQuestion ept = new EPTQuestion()
        //    {

        //    };

        //    //ept.Name = ep.Name;
        //    //ept.Family = ep.Family;
        //    //ept.Name = "";
        //    //ept.Family = "";
        //    ept.Id = ep.Id;
        //    return View(ept);

        //}
        [Authorize(Roles ="admin,superadmin")]
        public IActionResult EPTIsDelete(Guid? id)
        {
            eptservice.EptPersonDeleteById(id);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("Index", null);
        }
        [Authorize(Roles ="admin,superadmin")]
        public IActionResult MBTI(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";
            ViewBag.Title = "MBTI";
            var mm = mBTIService.MBTIPersonList(id);
            if(mm != null && id != null)
            {
                var us = _userService.GetById(id.ToString());

                if (us != null)
                {
                   mm.NameAndFamily = us.FullName;
                }
            }
            return View(mm);
        }
        [Authorize(Roles = "admin,superadmin")]
        public IActionResult Ept(Guid? id)
        {
            ViewBag.Title = "Ept";

            ViewBag.UsserNameAndFamily = "مدیر سیستم ";
            if(id != null)
                ViewBag.FullName = _userService.GetById(id.ToString()).FullName;

            return View(eptservice.EptPersonList(id));
        }
        [Authorize(Roles = "admin,superadmin")]
        public IActionResult MBTIDelete(Guid? id)
        {

            var ep = mBTIService.MBTIPersonById(id  );
            MBTIQuestionListModel ept = new MBTIQuestionListModel()
            {

            };

            ept.Id = ep.Id;
            return View(ept);

        }

        [Authorize(Roles = "superadmin")]
        public JsonResult userdelete(Guid id)
        {
                var ep = _userService.DeleteUser(id.ToString());
            return Json(ep);
        }



        [Authorize(Roles ="admin,superadmin")]
        public IActionResult MBTIIsDelete(Guid? id)
        {
            mBTIService.MBTIPersonDeleteById(id);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("MBTI", null);
        }
    }
}
