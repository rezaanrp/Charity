using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.EPT;
using CharityTestCore.Service;
using CharityTestCore.Service.EPT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
	public class EPTTestController : BaseController
	{
		protected IEPTService eptservice;
		public EPTTestController(IEPTService _eptservice)
		{
			eptservice = _eptservice;
		}
		// GET: EPTTest
		[Authorize]
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		[Authorize]

		public IActionResult RegisterEptQuestion()
		{
			ViewBag.Title = "آزمون  ";

			//ViewBag.EPTQuiz = new CharityTestCoreService().EptQuizTextList();
			return View(new EPTQuestion());
		}
		[HttpPost]
		[Authorize]

		public IActionResult RegisterEptQuestion(EPTQuestion ePTQuestion)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			var result = 0;

			result = eptservice.AddEptQuestion(OnGetUserId(), ePTQuestion.HaveSkill, ePTQuestion.BeforeYouHaveJob, ePTQuestion.DoYouWantHaveJob,
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
			   );

			if (result == -1)
			{
				ViewBag.ErrorMessage = "در ذخیره سازی کاربر مشکلی رخ داده است. لطفا مجددا تلاش نمایید";
				return View();
			}
			else
				///ePTQuestion.NationalCode;
				return View("AnswerEptQuestion");


		}

		[HttpGet]
		public IActionResult RegisterEptQuestionV2()
		{

            if (eptservice.GetEptByUserId(OnGetUserId()) != null)
            {
				return RedirectToAction("UserProfile","Dashboard");
            }
            ViewBag.Title = "آزمون  ";

			//ViewBag.EPTQuiz = new CharityTestCoreService().EptQuizTextList();
			return View();
		}
		public class UserModel
		{
			public int Id { get; set; }
			public byte Name { get; set; }
		}
		[HttpPost]
		public IActionResult RegisterEptQuestionV2(List<UserModel> listofusers)
		{
            if (eptservice.GetEptByUserId(OnGetUserId()) != null)
            {
                return RedirectToAction("UserProfile", "Dashboard");
            }
            var result = eptservice.AddEptQuestion(OnGetUserId(), true, true, true,
				   listofusers[1].Name,
				   listofusers[2].Name,
				   listofusers[3].Name,
				   listofusers[4].Name,
				   listofusers[5].Name,
				   listofusers[6].Name,
				   listofusers[7].Name,
				   listofusers[8].Name,
				   listofusers[9].Name,
				   listofusers[10].Name,
				   listofusers[11].Name,
				   listofusers[12].Name,
				   listofusers[13].Name,
				   listofusers[14].Name,
				   listofusers[15].Name,
				   listofusers[16].Name,
				   listofusers[17].Name,
				   listofusers[18].Name,
				   listofusers[19].Name,
				   listofusers[20].Name,
				   listofusers[21].Name,
				   listofusers[22].Name,
				   listofusers[23].Name,
				   listofusers[24].Name,
				   listofusers[25].Name,
				   listofusers[26].Name,
				   listofusers[27].Name,
				   listofusers[28].Name,
				   listofusers[29].Name,
				   listofusers[30].Name,
				   listofusers[31].Name,
				   listofusers[32].Name,
				   listofusers[33].Name,
				   listofusers[34].Name,
				   listofusers[35].Name,
				   listofusers[36].Name,
				   listofusers[37].Name,
				   listofusers[38].Name,
				   listofusers[39].Name,
				   listofusers[40].Name,
				   listofusers[41].Name,
				   listofusers[42].Name,
				   listofusers[43].Name,
				   listofusers[44].Name,
				   listofusers[45].Name,
				   listofusers[46].Name,
				   listofusers[47].Name,
				   listofusers[48].Name,
				   listofusers[49].Name,
				   listofusers[50].Name,
				   listofusers[51].Name,
				   listofusers[52].Name,
				   listofusers[53].Name,
				   listofusers[54].Name,
				   listofusers[55].Name,
				   listofusers[56].Name,
				   listofusers[57].Name,
				   listofusers[58].Name,
				   listofusers[59].Name,
				   listofusers[60].Name,
				   listofusers[61].Name,
				   listofusers[62].Name,
				   listofusers[63].Name,
				   listofusers[64].Name,
				   listofusers[65].Name,
				   listofusers[66].Name,
				   listofusers[67].Name,
				   listofusers[68].Name,
				   listofusers[69].Name,
				   listofusers[70].Name,
				   listofusers[71].Name,
				   listofusers[72].Name,
				   listofusers[73].Name,
				   listofusers[74].Name,
				   listofusers[75].Name,
				   listofusers[76].Name,
				   listofusers[77].Name,
				   listofusers[78].Name,
				   listofusers[79].Name,
				   listofusers[80].Name,
				   listofusers[81].Name,
				   listofusers[82].Name,
				   listofusers[83].Name,
				   listofusers[84].Name,
				   listofusers[85].Name,
				   listofusers[86].Name,
				   listofusers[87].Name,
				   listofusers[88].Name,
				   listofusers[89].Name,
				   listofusers[90].Name,
				   listofusers[91].Name,
				   listofusers[92].Name,
				   listofusers[93].Name,
				   listofusers[94].Name,
				   listofusers[95].Name

				 );

			return Json(new
			{
                result = true
			});
		}
		public IActionResult AnswerEptQuestion()
		{
			return View();
		}
	}
}
