using CharityTestCore.Models;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.MBTI;
using DAL.DataBase;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
    public class DashboardController : Controller

    {
        private readonly IEPTService eptservice;
        private readonly IEPTRepository eptrepository;

        private readonly IMBTIService mBTIService;
        private readonly IMBTIRepository mBTIRepository;
        public DashboardController(IEPTService _eptservice,
            IEPTRepository _eptrepository , IMBTIService _mBTIService, IMBTIRepository _mBTIRepository)
        {
            eptservice = _eptservice;
            eptrepository = _eptrepository;

            mBTIService = _mBTIService;
            mBTIRepository = _mBTIRepository;

        }
        [Authorize]
        public IActionResult Index(int? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(eptservice.EptPersonList(id, eptrepository));
        }

        [Authorize]
        public IActionResult EPTDelete(int? id)
        {

           var ep = eptservice.EptPersonById(id, eptrepository);
            EPTQuestion ept = new EPTQuestion()
            {

            };
            ept.Name = ep.xName;
            ept.Family = ep.xFamily;
            ept.x_ = ep.x_;
            return View(ept);

        }
        [Authorize]
        public IActionResult EPTIsDelete(int? id)
        {
            eptservice.EptPersonDeleteById(id, eptrepository);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("Index", null);
        }
        [Authorize]
        public IActionResult MBTI(int? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(mBTIService.MBTIPersonList(id,mBTIRepository));
        }
        [Authorize]
        public IActionResult MBTIDelete(int? id)
        {

            var ep = mBTIService.MBTIPersonById(id,mBTIRepository);
            MBTIQuestionListModel ept = new MBTIQuestionListModel()
            {

            };
            ept.xName = ep.xName;
            ept.xFamily = ep.xFamily;
            ept.x_ = ep.x_;
            return View(ept);

        }
        [Authorize]
        public IActionResult MBTIIsDelete(int? id)
        {
            mBTIService.MBTIPersonDeleteById(id, mBTIRepository);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("MBTI", null);
        }
    }
}
