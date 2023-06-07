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
        public IActionResult Index(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(eptservice.EptPersonList(id, eptrepository));
        }

        [Authorize]
        public IActionResult EPTDelete(Guid? id)
        {

           var ep = eptservice.EptPersonById(id, eptrepository);
            EPTQuestion ept = new EPTQuestion()
            {

            };
            ept.Name = ep.Name;
            ept.Family = ep.Family;
            ept.Id = ep.Id;
            return View(ept);

        }
        [Authorize]
        public IActionResult EPTIsDelete(Guid? id)
        {
            eptservice.EptPersonDeleteById(id, eptrepository);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("Index", null);
        }
        [Authorize]
        public IActionResult MBTI(Guid? id)
        {
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return View(mBTIService.MBTIPersonList(id,mBTIRepository));
        }
        [Authorize]
        public IActionResult MBTIDelete(Guid? id)
        {

            var ep = mBTIService.MBTIPersonById(id,mBTIRepository);
            MBTIQuestionListModel ept = new MBTIQuestionListModel()
            {

            };
            ept.Name = ep.Name;
            ept.Family = ep.Family;
            ept.Id = ep.Id;
            return View(ept);

        }
        [Authorize]
        public IActionResult MBTIIsDelete(Guid? id)
        {
            mBTIService.MBTIPersonDeleteById(id, mBTIRepository);
            ViewBag.UsserNameAndFamily = "مدیر سیستم ";

            return RedirectToAction("MBTI", null);
        }
    }
}
