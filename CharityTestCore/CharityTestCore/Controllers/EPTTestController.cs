using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Service;
using CharityTestCore.Service.EPT;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
    public class EPTTestController : Controller
    {
        protected IEPTService eptservice;
        protected IEPTRepository eptrepository;
        public EPTTestController(IEPTService _eptservice, IEPTRepository _eptrepository)
        {
            eptservice = _eptservice;
            eptrepository = _eptrepository;
        }
        // GET: EPTTest
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegisterEptQuestion()
        {
            ViewBag.Title = "آزمون  ";

            //ViewBag.EPTQuiz = new CharityTestCoreService().EptQuizTextList();
            return View(new EPTQuestion());
        }
        [HttpPost]
        public IActionResult RegisterEptQuestion(EPTQuestion ePTQuestion)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                result = eptservice.AddEptQuestion(1, ePTQuestion.Name, ePTQuestion.Family, ePTQuestion.NationalCode,
                ePTQuestion.MobileNumber, ePTQuestion.Age, ePTQuestion.HaveSkill, ePTQuestion.BeforeYouHaveJob, ePTQuestion.DoYouWantHaveJob,
                ePTQuestion.S01,
                ePTQuestion.S02,
                ePTQuestion.S03,
                ePTQuestion.S04,
                ePTQuestion.S05,
                ePTQuestion.S06,
                ePTQuestion.S07,
                ePTQuestion.S08,
                ePTQuestion.S09,
                ePTQuestion.S10,
                ePTQuestion.S11,
                ePTQuestion.S12,
                ePTQuestion.S13,
                ePTQuestion.S14,
                ePTQuestion.S15,
                ePTQuestion.S16,
                ePTQuestion.S17,
                ePTQuestion.S18,
                ePTQuestion.S19,
                ePTQuestion.S20,
                ePTQuestion.S21,
                ePTQuestion.S22,
                ePTQuestion.S23,
                ePTQuestion.S24,
                ePTQuestion.S25,
                ePTQuestion.S26,
                ePTQuestion.S27,
                ePTQuestion.S28,
                ePTQuestion.S29,
                ePTQuestion.S30,
                ePTQuestion.S31,
                ePTQuestion.S32,
                ePTQuestion.S33,
                ePTQuestion.S34,
                ePTQuestion.S35,
                ePTQuestion.S36,
                ePTQuestion.S37,
                ePTQuestion.S38,
                ePTQuestion.S39,
                ePTQuestion.S40,
                ePTQuestion.S41,
                ePTQuestion.S42,
                ePTQuestion.S43,
                ePTQuestion.S44,
                ePTQuestion.S45,
                ePTQuestion.S46,
                ePTQuestion.S47,
                ePTQuestion.S48,
                ePTQuestion.S49,
                ePTQuestion.S50,
                ePTQuestion.S51,
                ePTQuestion.S52,
                ePTQuestion.S53,
                ePTQuestion.S54,
                ePTQuestion.S55,
                ePTQuestion.S56,
                ePTQuestion.S57,
                ePTQuestion.S58,
                ePTQuestion.S59,
                ePTQuestion.S60,
                ePTQuestion.S61,
                ePTQuestion.S62,
                ePTQuestion.S63,
                ePTQuestion.S64,
                ePTQuestion.S65,
                ePTQuestion.S66,
                ePTQuestion.S67,
                ePTQuestion.S68,
                ePTQuestion.S69,
                ePTQuestion.S70,
                ePTQuestion.S71,
                ePTQuestion.S72,
                ePTQuestion.S73,
                ePTQuestion.S74,
                ePTQuestion.S75,
                ePTQuestion.S76,
                ePTQuestion.S77,
                ePTQuestion.S78,
                ePTQuestion.S79,
                ePTQuestion.S80,
                ePTQuestion.S81,
                ePTQuestion.S82,
                ePTQuestion.S83,
                ePTQuestion.S84,
                ePTQuestion.S85,
                ePTQuestion.S86,
                ePTQuestion.S87,
                ePTQuestion.S88,
                ePTQuestion.S89,
                ePTQuestion.S90,
                ePTQuestion.S91,
                ePTQuestion.S92,
                ePTQuestion.S93,
                ePTQuestion.S94,
                ePTQuestion.S95
               , eptrepository);

                if (result == -1)
                {
                    ViewBag.ErrorMessage = "در ذخیره سازی کاربر مشکلی رخ داده است. لطفا مجددا تلاش نمایید";
                    return View();
                }
                else
                    ///ePTQuestion.NationalCode;
                    return View("AnswerEptQuestion");
            }
            else
                return View();

        }
        public IActionResult AnswerEptQuestion()
        {
            return View();
        }
    }
}
