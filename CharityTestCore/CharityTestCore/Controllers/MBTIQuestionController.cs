using CharityTestCore.Models;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Service;
using CharityTestCore.Service.MBTI;
using DAL.DataBase;
using DAL.Migrations;
using Microsoft.AspNetCore.Mvc;

namespace CharityTestCore.Controllers
{
    public class MBTIQuestionController : Controller
    {
        IMBTIRepository _mBTIRepository;
        IMBTIService    _mBTIService;
        public MBTIQuestionController(IMBTIRepository mBTIRepository,IMBTIService mBTIService) 
        {
            _mBTIRepository = mBTIRepository;
                _mBTIService = mBTIService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "آزمون شخصیت";

            return View(new MBTIQuestionListModel());

        }
        [HttpPost]
        public IActionResult Index(MBTIAnswerList M_)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                result = _mBTIService.AddMBTIQuestionList( M_.xName, M_.xFamily, M_.NationalCode, M_.MobileNumber,M_.Age,
                    M_.Answer1, M_.Answer2, M_.Answer3, M_.Answer4, M_.Answer5, M_.Answer6, M_.Answer7, M_.Answer8, M_.Answer9, M_.Answer10, M_.Answer11, M_.Answer12, M_.Answer13, M_.Answer14, M_.Answer15, M_.Answer16, M_.Answer17, M_.Answer18, M_.Answer19, M_.Answer20, M_.Answer21, M_.Answer22, M_.Answer23, M_.Answer24, M_.Answer25, M_.Answer26, M_.Answer27, M_.Answer28, M_.Answer29, M_.Answer30, M_.Answer31, M_.Answer32, M_.Answer33, M_.Answer34, M_.Answer35, M_.Answer36, M_.Answer37, M_.Answer38, M_.Answer39, M_.Answer40, M_.Answer41, M_.Answer42, M_.Answer43, M_.Answer44, M_.Answer45, M_.Answer46, M_.Answer47, M_.Answer48, M_.Answer49, M_.Answer50, M_.Answer51, M_.Answer52, M_.Answer53, M_.Answer54, M_.Answer55, M_.Answer56, M_.Answer57, M_.Answer58, M_.Answer59, M_.Answer60, M_.Answer61, M_.Answer62, M_.Answer63, M_.Answer64, M_.Answer65, M_.Answer66, M_.Answer67, M_.Answer68, M_.Answer69, M_.Answer70, M_.Answer71, M_.Answer72, M_.Answer73, M_.Answer74, M_.Answer75, M_.Answer76, M_.Answer77, M_.Answer78, M_.Answer79, M_.Answer80
                    ,_mBTIRepository   );
                 
                if (result == -1)
                {
                    ViewBag.ErrorMessage = "در ذخیره سازی کاربر مشکلی رخ داده است. لطفا مجددا تلاش نمایید";
                    return View();
                }
                else
                    ///ePTQuestion.NationalCode;
                    return View("AnswerMBTIQuestion");
            }
            else
                return View();

        }
        public IActionResult AnswerMBTIQuestion()
        {
            ViewBag.Title = "آزمون شخصیت";

            return View();
        }

    }
}
