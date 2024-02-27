using CharityTestCore.Models;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Service;
using CharityTestCore.Service.EPT;
using CharityTestCore.Service.MBTI;
using DAL.DataBase;
using Microsoft.AspNetCore.Mvc;
using static CharityTestCore.Controllers.EPTTestController;

namespace CharityTestCore.Controllers
{
    public class MBTIQuestionController : BaseController
    {
       
        IMBTIService    _mBTIService;
        public MBTIQuestionController(IMBTIService mBTIService) 
        {
                _mBTIService = mBTIService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Title = "آزمون شخصیت";
            return View(new MBTIQuestionListModel());

        }
        [HttpPost]
        public IActionResult Index(MBTIQuestionListModel M_)
        {
            if(OnGetUserId() == string.Empty)
                return View();
            var result = 0;
            if (ModelState.IsValid)
            {
                result = _mBTIService.AddMBTIQuestionList(OnGetUserId() ,
                    M_.Answer1, M_.Answer2, M_.Answer3, M_.Answer4, M_.Answer5, M_.Answer6, M_.Answer7, M_.Answer8, M_.Answer9, M_.Answer10, M_.Answer11, M_.Answer12, M_.Answer13, M_.Answer14, M_.Answer15, M_.Answer16, M_.Answer17, M_.Answer18, M_.Answer19, M_.Answer20, M_.Answer21, M_.Answer22, M_.Answer23, M_.Answer24, M_.Answer25, M_.Answer26, M_.Answer27, M_.Answer28, M_.Answer29, M_.Answer30, M_.Answer31, M_.Answer32, M_.Answer33, M_.Answer34, M_.Answer35, M_.Answer36, M_.Answer37, M_.Answer38, M_.Answer39, M_.Answer40, M_.Answer41, M_.Answer42, M_.Answer43, M_.Answer44, M_.Answer45, M_.Answer46, M_.Answer47, M_.Answer48, M_.Answer49, M_.Answer50, M_.Answer51, M_.Answer52, M_.Answer53, M_.Answer54, M_.Answer55, M_.Answer56, M_.Answer57, M_.Answer58, M_.Answer59, M_.Answer60, M_.Answer61, M_.Answer62, M_.Answer63, M_.Answer64, M_.Answer65, M_.Answer66, M_.Answer67, M_.Answer68, M_.Answer69, M_.Answer70, M_.Answer71, M_.Answer72, M_.Answer73, M_.Answer74, M_.Answer75, M_.Answer76, M_.Answer77, M_.Answer78, M_.Answer79, M_.Answer80
                       );
                 
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
        [HttpGet]
        public IActionResult Quiz()
        {
            if (_mBTIService.GetByUserId(OnGetUserId()) != null)
            {
                return RedirectToAction("UserProfile", "Dashboard");
            }
            ViewBag.Title = "آزمون شخصیت";
            return View();

        }
        public class UserModel
        {
            public int Id { get; set; }
            public byte Name { get; set; }
        }
        [HttpPost]
        public IActionResult Quiz(List<UserModel> listofusers)
        {

            if (_mBTIService.GetByUserId(OnGetUserId()) != null)
            {
                return RedirectToAction("UserProfile", "Dashboard");
            }
            var result = _mBTIService.AddMBTIQuestionList(OnGetUserId(),
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
                                listofusers[80].Name

                       );
            return Json(new
            {
                result = true
            });

        }

    }
}
