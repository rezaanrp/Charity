using CharityTestCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityTestCore.Controllers
{
	public class QuizQuestionsController : Controller
	{
		private readonly QuizQuestionDiscService _quizQuestionDiscService;

		public QuizQuestionsController(QuizQuestionDiscService quizQuestionDiscService)
        {
			_quizQuestionDiscService = quizQuestionDiscService;

		}
		[HttpGet]
		public IActionResult Index()
		{
			ViewBag.Title = "آزمون شخصیت";
			return View();

		}
		[HttpPost]
		public IActionResult Index(MBTIQuestionListModel M_)
		{

				return View();

		}
		public IActionResult AnswerDiscQuestion()
		{
			ViewBag.Title = "آزمون Disc";

			return View();
		}
        [HttpPost]
        public IActionResult SaveFormData([FromBody] List<QuestionResponse> responses)
        {

            return Ok(new { success = true, message = "Data saved successfully" });
        }

        // مدل مربوط به داده‌های ورودی
        public class QuestionResponse
        {
            public int QuestionId { get; set; }
            public string BestDescription { get; set; }
            public string WorstDescription { get; set; }
        }

        [HttpGet]
		public async Task<IActionResult>  Quiz()
		{
            var model = await _quizQuestionDiscService.GetAllAsync();

            return View(model);

		}
		public class UserModel
		{
			public int Id { get; set; }
			public byte Name { get; set; }
		}
		[HttpPost]
		public IActionResult Quiz(List<UserModel> listofusers)
		{
			return View();


		}
	}
}
