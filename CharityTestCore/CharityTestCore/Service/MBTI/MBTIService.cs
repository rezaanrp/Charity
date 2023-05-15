using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.MBTI;
using DAL.DataBase;

namespace CharityTestCore.Service.MBTI
{
    public class MBTIService:IMBTIService
    {
        public MBTIQuestionListPersonModel MBTIPersonList(int? id, IMBTIRepository mBTIRepository)
        {
            MBTIQuestionListPersonModel MBTIQuestionListPersonModel_ = new MBTIQuestionListPersonModel();


            MBTIQuestionListPersonModel_.Persons = mBTIRepository.MBTIAnswerList.ToList();

            MBTIAnswerList? ep = mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.x_ == id);
            if (ep != null)
            {
                int ReAnswerultTeAnswert1 = ep.Answer1 + ep.Answer2 + ep.Answer3 + ep.Answer4 + ep.Answer5 + ep.Answer6 + ep.Answer7 + ep.Answer8 + ep.Answer9 + ep.Answer10;
                int ReAnswerultTeAnswert2 = ep.Answer11 + ep.Answer12 + ep.Answer13 + ep.Answer14 + ep.Answer15 + ep.Answer16 + ep.Answer17 + ep.Answer18 + ep.Answer19 + ep.Answer20;
                int ReAnswerultTeAnswert3 = ep.Answer21 + ep.Answer22 + ep.Answer23 + ep.Answer24 + ep.Answer25 + ep.Answer26 + ep.Answer27 + ep.Answer28 + ep.Answer29 + ep.Answer30;
                int ReAnswerultTeAnswert4 = ep.Answer31 + ep.Answer32 + ep.Answer33 + ep.Answer34 + ep.Answer35 + ep.Answer36 + ep.Answer37 + ep.Answer38 + ep.Answer39 + ep.Answer40;
                int ReAnswerultTeAnswert5 = ep.Answer41 + ep.Answer42 + ep.Answer43 + ep.Answer44 + ep.Answer45 + ep.Answer46 + ep.Answer47 + ep.Answer48 + ep.Answer49 + ep.Answer50;
                int ReAnswerultTeAnswert6 = ep.Answer51 + ep.Answer52 + ep.Answer53 + ep.Answer54 + ep.Answer55 + ep.Answer56 + ep.Answer57 + ep.Answer58 + ep.Answer59 + ep.Answer60;
                int ReAnswerultTeAnswert7 = ep.Answer61 + ep.Answer62 + ep.Answer63 + ep.Answer64 + ep.Answer65 + ep.Answer66 + ep.Answer67 + ep.Answer68 + ep.Answer69 + ep.Answer70;
                int ReAnswerultTeAnswert8 = ep.Answer71 + ep.Answer72 + ep.Answer73 + ep.Answer74 + ep.Answer75 + ep.Answer76 + ep.Answer77 + ep.Answer78 + ep.Answer79 + ep.Answer80;
                string s1 = ReAnswerultTeAnswert1 > ReAnswerultTeAnswert2 ? "E" : "I";
                string s2 = ReAnswerultTeAnswert3 > ReAnswerultTeAnswert4 ? "S" : "N";
                string s3 = ReAnswerultTeAnswert5 > ReAnswerultTeAnswert6 ? "T" : "F";
                string s4 = ReAnswerultTeAnswert7 > ReAnswerultTeAnswert8 ? "J" : "P";
                string ReAnswerultTeAnswert9 = s1 + s2 + s3 + s4;
                var ep_T = mBTIRepository.MBTIQuestionList.FirstOrDefault(x => x.Question == ReAnswerultTeAnswert9);

                //string ResultTest1Text = "  برون گرایی ";
                //string ResultTest2Text = "  درون گرایی ";
                //string ResultTest3Text = "  حسی  ";
                //string ResultTest4Text = "  شمی ";
                //string ResultTest5Text = "  فکری ";
                //string ResultTest6Text = "  احساسی ";
                //string ResultTest7Text = "  داوری کننده";
                //string ResultTest8Text = "  ادراکی ";

                MBTIQuestionListPersonModel_.ResultTest1 = ReAnswerultTeAnswert1;
                MBTIQuestionListPersonModel_.ResultTest2 = ReAnswerultTeAnswert2;
                MBTIQuestionListPersonModel_.ResultTest3 = ReAnswerultTeAnswert3;
                MBTIQuestionListPersonModel_.ResultTest4 = ReAnswerultTeAnswert4;
                MBTIQuestionListPersonModel_.ResultTest5 = ReAnswerultTeAnswert5;
                MBTIQuestionListPersonModel_.ResultTest6 = ReAnswerultTeAnswert6;
                MBTIQuestionListPersonModel_.ResultTest7 = ReAnswerultTeAnswert7;
                MBTIQuestionListPersonModel_.ResultTest8 = ReAnswerultTeAnswert8;
                MBTIQuestionListPersonModel_.NameAndFamily = ep.xName + " " + ep.xFamily;
                MBTIQuestionListPersonModel_.ResultTestHtml = ep_T.Answer2;
                MBTIQuestionListPersonModel_.ResultTestTotal = ReAnswerultTeAnswert9;
            }
            else
                MBTIQuestionListPersonModel_.ResultTestTotal = "$$";


            return MBTIQuestionListPersonModel_;

        }
        public MBTIAnswerList? MBTIPersonById(int? id, IMBTIRepository mBTIRepository)
        {
            return mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.x_ == id);

        }
        public bool MBTIPersonDeleteById(int? ept, IMBTIRepository mBTIRepository)
        {
            try
            {
                var per = mBTIRepository.MBTIAnswerList.FirstOrDefault(x => x.x_ == ept);
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
        public int AddMBTIQuestionList(string xName, string xFamily, string NationalCode, string MobileNumber, int? Age, byte Answer1, byte Answer2, byte Answer3, byte Answer4, byte Answer5, byte Answer6, byte Answer7, byte Answer8, byte Answer9, byte Answer10, byte Answer11, byte Answer12, byte Answer13, byte Answer14, byte Answer15, byte Answer16, byte Answer17, byte Answer18, byte Answer19, byte Answer20, byte Answer21, byte Answer22, byte Answer23, byte Answer24, byte Answer25, byte Answer26, byte Answer27, byte Answer28, byte Answer29, byte Answer30, byte Answer31, byte Answer32, byte Answer33, byte Answer34, byte Answer35, byte Answer36, byte Answer37, byte Answer38, byte Answer39, byte Answer40, byte Answer41, byte Answer42, byte Answer43, byte Answer44, byte Answer45, byte Answer46, byte Answer47, byte Answer48, byte Answer49, byte Answer50, byte Answer51, byte Answer52, byte Answer53, byte Answer54, byte Answer55, byte Answer56, byte Answer57, byte Answer58, byte Answer59, byte Answer60, byte Answer61, byte Answer62, byte Answer63, byte Answer64, byte Answer65, byte Answer66, byte Answer67, byte Answer68, byte Answer69, byte Answer70, byte Answer71, byte Answer72, byte Answer73, byte Answer74, byte Answer75, byte Answer76, byte Answer77, byte Answer78, byte Answer79, byte Answer80,IMBTIRepository  mBTIRepository)
        {
            try
            {
                var MBTIAnswerList_ = new MBTIAnswerList
                {
                    xName = xName,
                    xFamily = xFamily,
                    Age = Age,
                    NationalCode = NationalCode,
                    MobileNumber = MobileNumber,
                    RegisterDate = DateTime.Now,
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

    }
}
