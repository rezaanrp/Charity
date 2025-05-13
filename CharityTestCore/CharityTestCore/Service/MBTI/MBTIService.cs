using CharityTestCore.Models;
using CharityTestCore.Repository.MBTI;
using CharityTestCore.Repository.UserManagment;
using Domain.Model;
using NuGet.Protocol.Core.Types;

namespace CharityTestCore.Service.MBTI
{
    public class MBTIService : IMBTIService
    {
          private readonly IMBTIRepository mBTIRepository;
          private readonly IUserRepository  _userRepository;

        public MBTIService( IMBTIRepository mBTIRepository, IUserRepository userRepository)
        {

            this.mBTIRepository = mBTIRepository;
            _userRepository = userRepository;
        }

        public MBTIAnswerList? MBTIPersonById(Guid? id)
        {
            return mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.Id == id);

        }
        public bool MBTIPersonDeleteById(Guid? ept)
        {
            try
            {
                var per = mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.UserId == ept);
                if (per != null)
                {
                    mBTIRepository.DelMBTIQuestion(per);
                    mBTIRepository.SaveChanges();
                    return true;

                }
                else
                    return false;

            }
            catch (Exception e)
            {
                return false;


            }

        }
        public MBTIQuestionListPersonModel MBTIPersonList(Guid? id)
        {
            var model = new MBTIQuestionListPersonModel();

            if (id == null)
            {
                model.ResultTestTotal = "شناسه نامعتبر است";
                return model;
            }

            var answer = mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.UserId == id);
            if (answer == null)
            {
                model.ResultTestTotal = "آزمون ثبت نشده";
                return model;
            }

            // استخراج پاسخ‌ها از Answer1 تا Answer80
            var props = typeof(MBTIAnswerList).GetProperties()
                .Where(p => p.Name.StartsWith("Answer"))
                .OrderBy(p => int.Parse(p.Name.Replace("Answer", "")))
                .ToList();

            byte[] answers = new byte[80];
            for (int i = 0; i < 80; i++)
            {
                var value = props[i].GetValue(answer);
                answers[i] = value != null ? Convert.ToByte(value) : (byte)0;
            }

            // محاسبه تیپ شخصیت و نمرات
            var (mbtiType, results) = CalculateMBTI(answers);
            answer.Result = mbtiType;

            mBTIRepository.Update(answer);

            // دریافت توضیحات تیپ
            var typeInfo = mBTIRepository.MBTIQuestionList.FirstOrDefault(x => x.Question == mbtiType);

            // پر کردن مدل خروجی
            model.ResultTest1 = results[0];
            model.ResultTest2 = results[1];
            model.ResultTest3 = results[2];
            model.ResultTest4 = results[3];
            model.ResultTest5 = results[4];
            model.ResultTest6 = results[5];
            model.ResultTest7 = results[6];
            model.ResultTest8 = results[7];
            model.ResultTestTotal = mbtiType;
            model.ResultTestHtml = typeInfo?.Answer2 ?? "";
            model.NameAndFamily = ""; // در صورت نیاز از جای دیگر پر شود

            return model;
        }
        /// <summary>
        /// محاسبه کامل تیپ شخصیت MBTI و امتیاز هر محور
        /// </summary>
        public  (string Type, int[] Scores) CalculateMBTI(byte[] answers)
        {
            if (answers == null || answers.Length != 80)
                return ("?", new int[8]);

            int[] results = new int[8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 10; j++)
                    results[i] += answers[i * 10 + j];

            string s1 = results[0] > results[1] ? "E" : "I";
            string s2 = results[2] > results[3] ? "S" : "N";
            string s3 = results[4] > results[5] ? "T" : "F";
            string s4 = results[6] > results[7] ? "J" : "P";

            return (s1 + s2 + s3 + s4, results);
        }
        public string CalculateMBTIType(byte[] answers)
        {
            if (answers == null || answers.Length != 80)
                return "?";

            int[] results = new int[8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    results[i] += answers[i * 10 + j];
                }
            }

            string s1 = results[0] > results[1] ? "E" : "I";
            string s2 = results[2] > results[3] ? "S" : "N";
            string s3 = results[4] > results[5] ? "T" : "F";
            string s4 = results[6] > results[7] ? "J" : "P";

            return s1 + s2 + s3 + s4;
        }

        public int AddMBTIQuestionList(Guid userId, byte[] answers)
        {
            if (answers.Length != 80) return -1;

            try
            {
                // محاسبه تیپ شخصیت

                var mbtiType = CalculateMBTIType(answers); // خروجی مثل "INTJ"

                // ساخت شیء پاسخ
                var mbtiAnswer = new MBTIAnswerList { UserId = userId, Result = mbtiType };

                // مقداردهی تمام Answer1 تا Answer80 با Reflection
                var props = typeof(MBTIAnswerList).GetProperties()
                             .Where(p => p.Name.StartsWith("Answer"))
                             .OrderBy(p => int.Parse(p.Name.Replace("Answer", "")))
                             .ToList();

                for (int i = 0; i < 80; i++)
                {
                    props[i].SetValue(mbtiAnswer, answers[i]);
                }

                // ذخیره در دیتابیس
                mBTIRepository.AddMBTIAnswerList(mbtiAnswer);
                mBTIRepository.SaveChanges();
                return 1;
            }
            catch
            {
                return -1;
            }
        }
        //حذف
        public int AddMBTIQuestionList(Guid UserId, byte Answer1, byte Answer2, byte Answer3, byte Answer4, byte Answer5, byte Answer6, byte Answer7, byte Answer8, byte Answer9, byte Answer10, byte Answer11, byte Answer12, byte Answer13, byte Answer14, byte Answer15, byte Answer16, byte Answer17, byte Answer18, byte Answer19, byte Answer20, byte Answer21, byte Answer22, byte Answer23, byte Answer24, byte Answer25, byte Answer26, byte Answer27, byte Answer28, byte Answer29, byte Answer30, byte Answer31, byte Answer32, byte Answer33, byte Answer34, byte Answer35, byte Answer36, byte Answer37, byte Answer38, byte Answer39, byte Answer40, byte Answer41, byte Answer42, byte Answer43, byte Answer44, byte Answer45, byte Answer46, byte Answer47, byte Answer48, byte Answer49, byte Answer50, byte Answer51, byte Answer52, byte Answer53, byte Answer54, byte Answer55, byte Answer56, byte Answer57, byte Answer58, byte Answer59, byte Answer60, byte Answer61, byte Answer62, byte Answer63, byte Answer64, byte Answer65, byte Answer66, byte Answer67, byte Answer68, byte Answer69, byte Answer70, byte Answer71, byte Answer72, byte Answer73, byte Answer74, byte Answer75, byte Answer76, byte Answer77, byte Answer78, byte Answer79, byte Answer80)
        {
            try
            {
                var MBTIAnswerList_ = new MBTIAnswerList
                {
            UserId = UserId,
                    Answer1 = Answer1,
                    Answer2 = Answer2,
                    Answer3 = Answer3,
                    Answer4 = Answer4,
                    Answer5 = Answer5,
                    Answer6 = Answer6,
                    Answer7 = Answer7,
                    Answer8 = Answer8,
                    Answer9 = Answer9,
                    Answer10 = Answer10,
                    Answer11 = Answer11,
                    Answer12 = Answer12,
                    Answer13 = Answer13,
                    Answer14 = Answer14,
                    Answer15 = Answer15,
                    Answer16 = Answer16,
                    Answer17 = Answer17,
                    Answer18 = Answer18,
                    Answer19 = Answer19,
                    Answer20 = Answer20,
                    Answer21 = Answer21,
                    Answer22 = Answer22,
                    Answer23 = Answer23,
                    Answer24 = Answer24,
                    Answer25 = Answer25,
                    Answer26 = Answer26,
                    Answer27 = Answer27,
                    Answer28 = Answer28,
                    Answer29 = Answer29,
                    Answer30 = Answer30,
                    Answer31 = Answer31,
                    Answer32 = Answer32,
                    Answer33 = Answer33,
                    Answer34 = Answer34,
                    Answer35 = Answer35,
                    Answer36 = Answer36,
                    Answer37 = Answer37,
                    Answer38 = Answer38,
                    Answer39 = Answer39,
                    Answer40 = Answer40,
                    Answer41 = Answer41,
                    Answer42 = Answer42,
                    Answer43 = Answer43,
                    Answer44 = Answer44,
                    Answer45 = Answer45,
                    Answer46 = Answer46,
                    Answer47 = Answer47,
                    Answer48 = Answer48,
                    Answer49 = Answer49,
                    Answer50 = Answer50,
                    Answer51 = Answer51,
                    Answer52 = Answer52,
                    Answer53 = Answer53,
                    Answer54 = Answer54,
                    Answer55 = Answer55,
                    Answer56 = Answer56,
                    Answer57 = Answer57,
                    Answer58 = Answer58,
                    Answer59 = Answer59,
                    Answer60 = Answer60,
                    Answer61 = Answer61,
                    Answer62 = Answer62,
                    Answer63 = Answer63,
                    Answer64 = Answer64,
                    Answer65 = Answer65,
                    Answer66 = Answer66,
                    Answer67 = Answer67,
                    Answer68 = Answer68,
                    Answer69 = Answer69,
                    Answer70 = Answer70,
                    Answer71 = Answer71,
                    Answer72 = Answer72,
                    Answer73 = Answer73,
                    Answer74 = Answer74,
                    Answer75 = Answer75,
                    Answer76 = Answer76,
                    Answer77 = Answer77,
                    Answer78 = Answer78,
                    Answer79 = Answer79,
                    Answer80 = Answer80
                };
                mBTIRepository.AddMBTIAnswerList(MBTIAnswerList_);
                mBTIRepository.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public MBTIAnswerList? GetByUserId(Guid UserId)
        {
            return mBTIRepository.GetByUserId(UserId);
        }
    }
}
