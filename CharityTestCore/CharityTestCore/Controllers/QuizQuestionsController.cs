using CharityTestCore.Models;
using Domain.DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CharityTestCore.Controllers
{
	public class QuizQuestionsController : Controller
	{
		private readonly QuizQuestionDiscService _quizQuestionDiscService;
		private readonly QuizAnswernDiscService _quizAnswernDiscService;

		public QuizQuestionsController(QuizQuestionDiscService quizQuestionDiscService, QuizAnswernDiscService  quizAnswernDiscService)
        {
			_quizQuestionDiscService = quizQuestionDiscService;
            _quizAnswernDiscService = quizAnswernDiscService;

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
        public  async Task<IActionResult> SaveFormData([FromBody] List<QuestionResponse> responses)
        {

			int dominance = 0;
			int inducement = 0;
			int submission = 0;
			int compliance = 0;

			foreach (QuestionResponse response in responses) 
			{
                int q = response.QuestionId;
                int bi = int.Parse(response.BestDescription);
                int wi = int.Parse(response.WorstDescription);

                var r1 = await _quizQuestionDiscService.GetByQuestionNumberAsync(q, bi);
                var r2 = await _quizQuestionDiscService.GetByQuestionNumberAsync(q, wi);
                if (r1 != null && r2 != null)
                {
                    if (r1.Category == "D")
                        dominance++;
                    else if (r1.Category == "I")
                        inducement++;
                    else if (r1.Category == "S")
                        submission++;
                    else if (r1.Category == "C")
                        compliance++;

                    if (r2.Category == "D")
                        dominance--;
                    else if (r2.Category == "I")
                        inducement--;
                    else if (r2.Category == "S")
                        submission--;
                    else if (r2.Category == "C")
                        compliance--;
                }
            }


            //List<QuizAnswernDiscViewModel> models = new List<QuizAnswernDiscViewModel>();
            //QuizAnswernDiscViewModel quiz = new QuizAnswernDiscViewModel();

            return Ok(new { success = true, message = "Data saved successfully" });
        }

        // مدل مربوط به داده‌های ورودی
        public class QuestionResponse
        {
            public int QuestionId { get; set; }
            public string BestDescription { get; set; }
            public string WorstDescription { get; set; }
        }
        public class ClacResponse
        {
            public int dominance { get; set; }
            public int inducement { get; set; }
            public int submission { get; set; }
            public int compliance { get; set; }
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
