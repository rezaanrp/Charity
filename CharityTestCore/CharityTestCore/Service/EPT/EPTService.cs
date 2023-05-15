using CharityTestCore.Models;
using CharityTestCore.Repository;
using CharityTestCore.Repository.EPT;
using DAL.DataBase;

namespace CharityTestCore.Service.EPT
{
    public class EPTService:IEPTService
    {
  
        public int AddEptQuestion(int x_, string xName_, string xFamily_, string NationalCode_,
         string MobileNumber_, int? Age_, bool? HaveSkill_, bool? BeforeYouHaveJob_, bool? DoYouWantHaveJob_,
         byte S01_, byte S02_, byte S03_, byte S04_, byte S05_, byte S06_, byte S07_, byte S08_, byte S09_, byte S10_, byte S11_, byte S12_, byte S13_, byte S14_, byte S15_, byte S16_, byte S17_, byte S18_, byte S19_, byte S20_, byte S21_, byte S22_, byte S23_, byte S24_, byte S25_, byte S26_, byte S27_, byte S28_, byte S29_, byte S30_, byte S31_, byte S32_, byte S33_, byte S34_, byte S35_, byte S36_, byte S37_, byte S38_, byte S39_, byte S40_, byte S41_, byte S42_, byte S43_, byte S44_, byte S45_, byte S46_, byte S47_, byte S48_, byte S49_, byte S50_, byte S51_, byte S52_, byte S53_, byte S54_, byte S55_, byte S56_, byte S57_, byte S58_, byte S59_, byte S60_, byte S61_, byte S62_, byte S63_, byte S64_, byte S65_, byte S66_, byte S67_, byte S68_, byte S69_, byte S70_, byte S71_, byte S72_, byte S73_, byte S74_, byte S75_, byte S76_, byte S77_, byte S78_, byte S79_, byte S80_, byte S81_, byte S82_, byte S83_, byte S84_, byte S85_, byte S86_, byte S87_, byte S88_, byte S89_, byte S90_, byte S91_, byte S92_, byte S93_, byte S94_, byte S95_
       , IEPTRepository repository)
        {
            try
            {
                var EPTQuestion_ = new EptQuestionList
                {
                    xFamily = xFamily_,
                    xName = xName_,
                    NationalCode = NationalCode_,
                    MobileNumber = MobileNumber_,
                    Age = (int?)Age_,
                    HaveSkill = HaveSkill_,
                    BeforeYouHaveJob = BeforeYouHaveJob_,
                    DoYouWantHaveJob = DoYouWantHaveJob_,
                    S01 = (byte)(S01_ == 0 ? 1 : S01_),
                    S02 = (byte)(S02_ == 0 ? 1 : S02_),
                    S03 = (byte)(S03_ == 0 ? 1 : S03_),
                    S04 = (byte)(S04_ == 0 ? 1 : S04_),
                    S05 = (byte)(S05_ == 0 ? 1 : S05_),
                    S06 = (byte)(S06_ == 0 ? 1 : S06_),
                    S07 = (byte)(S07_ == 0 ? 1 : S07_),
                    S08 = (byte)(S08_ == 0 ? 1 : S08_),
                    S09 = (byte)(S09_ == 0 ? 1 : S09_),
                    S10 = (byte)(S10_ == 0 ? 1 : S10_),
                    S11 = (byte)(S11_ == 0 ? 1 : S11_),
                    S12 = (byte)(S12_ == 0 ? 1 : S12_),
                    S13 = (byte)(S13_ == 0 ? 1 : S13_),
                    S14 = (byte)(S14_ == 0 ? 1 : S14_),
                    S15 = (byte)(S15_ == 0 ? 1 : S15_),
                    S16 = (byte)(S16_ == 0 ? 1 : S16_),
                    S17 = (byte)(S17_ == 0 ? 1 : S17_),
                    S18 = (byte)(S18_ == 0 ? 1 : S18_),
                    S19 = (byte)(S19_ == 0 ? 1 : S19_),
                    S20 = (byte)(S20_ == 0 ? 1 : S20_),
                    S21 = (byte)(S21_ == 0 ? 1 : S21_),
                    S22 = (byte)(S22_ == 0 ? 1 : S22_),
                    S23 = (byte)(S23_ == 0 ? 1 : S23_),
                    S24 = (byte)(S24_ == 0 ? 1 : S24_),
                    S25 = (byte)(S25_ == 0 ? 1 : S25_),
                    S26 = (byte)(S26_ == 0 ? 1 : S26_),
                    S27 = (byte)(S27_ == 0 ? 1 : S27_),
                    S28 = (byte)(S28_ == 0 ? 1 : S28_),
                    S29 = (byte)(S29_ == 0 ? 1 : S29_),
                    S30 = (byte)(S30_ == 0 ? 1 : S30_),
                    S31 = (byte)(S31_ == 0 ? 1 : S31_),
                    S32 = (byte)(S32_ == 0 ? 1 : S32_),
                    S33 = (byte)(S33_ == 0 ? 1 : S33_),
                    S34 = (byte)(S34_ == 0 ? 1 : S34_),
                    S35 = (byte)(S35_ == 0 ? 1 : S35_),
                    S36 = (byte)(S36_ == 0 ? 1 : S36_),
                    S37 = (byte)(S37_ == 0 ? 1 : S37_),
                    S38 = (byte)(S38_ == 0 ? 1 : S38_),
                    S39 = (byte)(S39_ == 0 ? 1 : S39_),
                    S40 = (byte)(S40_ == 0 ? 1 : S40_),
                    S41 = (byte)(S41_ == 0 ? 1 : S41_),
                    S42 = (byte)(S42_ == 0 ? 1 : S42_),
                    S43 = (byte)(S43_ == 0 ? 1 : S43_),
                    S44 = (byte)(S44_ == 0 ? 1 : S44_),
                    S45 = (byte)(S45_ == 0 ? 1 : S45_),
                    S46 = (byte)(S46_ == 0 ? 1 : S46_),
                    S47 = (byte)(S47_ == 0 ? 1 : S47_),
                    S48 = (byte)(S48_ == 0 ? 1 : S48_),
                    S49 = (byte)(S49_ == 0 ? 1 : S49_),
                    S50 = (byte)(S50_ == 0 ? 1 : S50_),
                    S51 = (byte)(S51_ == 0 ? 1 : S51_),
                    S52 = (byte)(S52_ == 0 ? 1 : S52_),
                    S53 = (byte)(S53_ == 0 ? 1 : S53_),
                    S54 = (byte)(S54_ == 0 ? 1 : S54_),
                    S55 = (byte)(S55_ == 0 ? 1 : S55_),
                    S56 = (byte)(S56_ == 0 ? 1 : S56_),
                    S57 = (byte)(S57_ == 0 ? 1 : S57_),
                    S58 = (byte)(S58_ == 0 ? 1 : S58_),
                    S59 = (byte)(S59_ == 0 ? 1 : S59_),
                    S60 = (byte)(S60_ == 0 ? 1 : S60_),
                    S61 = (byte)(S61_ == 0 ? 1 : S61_),
                    S62 = (byte)(S62_ == 0 ? 1 : S62_),
                    S63 = (byte)(S63_ == 0 ? 1 : S63_),
                    S64 = (byte)(S64_ == 0 ? 1 : S64_),
                    S65 = (byte)(S65_ == 0 ? 1 : S65_),
                    S66 = (byte)(S66_ == 0 ? 1 : S66_),
                    S67 = (byte)(S67_ == 0 ? 1 : S67_),
                    S68 = (byte)(S68_ == 0 ? 1 : S68_),
                    S69 = (byte)(S69_ == 0 ? 1 : S69_),
                    S70 = (byte)(S70_ == 0 ? 1 : S70_),
                    S71 = (byte)(S71_ == 0 ? 1 : S71_),
                    S72 = (byte)(S72_ == 0 ? 1 : S72_),
                    S73 = (byte)(S73_ == 0 ? 1 : S73_),
                    S74 = (byte)(S74_ == 0 ? 1 : S74_),
                    S75 = (byte)(S75_ == 0 ? 1 : S75_),
                    S76 = (byte)(S76_ == 0 ? 1 : S76_),
                    S77 = (byte)(S77_ == 0 ? 1 : S77_),
                    S78 = (byte)(S78_ == 0 ? 1 : S78_),
                    S79 = (byte)(S79_ == 0 ? 1 : S79_),
                    S80 = (byte)(S80_ == 0 ? 1 : S80_),
                    S81 = (byte)(S81_ == 0 ? 1 : S81_),
                    S82 = (byte)(S82_ == 0 ? 1 : S82_),
                    S83 = (byte)(S83_ == 0 ? 1 : S83_),
                    S84 = (byte)(S84_ == 0 ? 1 : S84_),
                    S85 = (byte)(S85_ == 0 ? 1 : S85_),
                    S86 = (byte)(S86_ == 0 ? 1 : S86_),
                    S87 = (byte)(S87_ == 0 ? 1 : S87_),
                    S88 = (byte)(S88_ == 0 ? 1 : S88_),
                    S89 = (byte)(S89_ == 0 ? 1 : S89_),
                    S90 = (byte)(S90_ == 0 ? 1 : S90_),
                    S91 = (byte)(S91_ == 0 ? 1 : S91_),
                    S92 = (byte)(S92_ == 0 ? 1 : S92_),
                    S93 = (byte)(S93_ == 0 ? 1 : S93_),
                    S94 = (byte)(S94_ == 0 ? 1 : S94_),
                    S95 = (byte)(S95_ == 0 ? 1 : S95_)
                };
                repository.AddEptQuestion(EPTQuestion_);
                repository.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return -1;
            }
        }


        public EPTListPersonModel EptPersonList(int? id, IEPTRepository repository)
        {
            EPTListPersonModel EPTListPersonModel_ = new EPTListPersonModel();


            EPTListPersonModel_.Persons = repository.EptQuestion.OrderByDescending(x => x.Score).ToList();

            EptQuestionList? ep = repository.EptQuestion.FirstOrDefault(x => x.x_ == id);
            if (ep != null)
            {
                float ResultTest1 = ep.S01 + ep.S02 + ep.S03 + ep.S04 + ep.S05 + ep.S06 + ep.S07 + ep.S08 + ep.S09 + ep.S10 + ep.S11 + ep.S12 + ep.S13 + ep.S14 + ep.S15 + ep.S16 + ep.S17 + ep.S18;
                float ResultTest2 = ep.S19 + ep.S20 + ep.S21 + ep.S22 + ep.S23 + ep.S24 + ep.S25 + ep.S26 + ep.S27 + ep.S28 + ep.S29 + ep.S30 + ep.S31 + ep.S32 + ep.S33 + ep.S34 + ep.S35;
                float ResultTest3 = ep.S36 + ep.S37 + ep.S38 + ep.S39 + ep.S40 + ep.S41 + ep.S42 + ep.S43 + ep.S44 + ep.S45 + ep.S46 + ep.S47 + ep.S48 + ep.S49 + ep.S50;
                float ResultTest4 = ep.S51 + ep.S52 + ep.S53 + ep.S54 + ep.S55 + ep.S56 + ep.S57 + ep.S58 + ep.S59 + ep.S60 + ep.S61 + ep.S62 + ep.S63;
                float ResultTest5 = ep.S64 + ep.S65 + ep.S66 + ep.S67 + ep.S68 + ep.S69 + ep.S70 + ep.S71;
                float ResultTest6 = ep.S72 + ep.S73 + ep.S74 + ep.S75 + ep.S76 + ep.S77 + ep.S78 + ep.S79 + ep.S80 + ep.S81 + ep.S82;
                float ResultTest7 = ep.S83 + ep.S84 + ep.S85 + ep.S86 + ep.S87 + ep.S88 + ep.S89;
                float ResultTest8 = ep.S90 + ep.S91 + ep.S92 + ep.S93 + ep.S94 + ep.S95;
                float ResultTest9 = ep.S01 + ep.S02 + ep.S03 + ep.S04 + ep.S05 + ep.S06 + ep.S07 + ep.S08 + ep.S09 + ep.S10 + ep.S11 + ep.S12 + ep.S13 + ep.S14 + ep.S15 + ep.S16 + ep.S17 + ep.S18 + ep.S19 + ep.S20 + ep.S21 + ep.S22 + ep.S23 + ep.S24 + ep.S25 + ep.S26 + ep.S27 + ep.S28 + ep.S29 + ep.S30 + ep.S31 + ep.S32 + ep.S33 + ep.S34 + ep.S35 + ep.S36 + ep.S37 + ep.S38 + ep.S39 + ep.S40 + ep.S41 + ep.S42 + ep.S43 + ep.S44 + ep.S45 + ep.S46 + ep.S47 + ep.S48 + ep.S49 + ep.S50 + ep.S51 + ep.S52 + ep.S53 + ep.S54 + ep.S55 + ep.S56 + ep.S57 + ep.S58 + ep.S59 + ep.S60 + ep.S61 + ep.S62 + ep.S63 + ep.S64 + ep.S65 + ep.S66 + ep.S67 + ep.S68 + ep.S69 + ep.S70 + ep.S71 + ep.S72 + ep.S73 + ep.S74 + ep.S75 + ep.S76 + ep.S77 + ep.S78 + ep.S79 + ep.S80 + ep.S81 + ep.S82 + ep.S83 + ep.S84 + ep.S85 + ep.S86 + ep.S87 + ep.S88 + ep.S89 + ep.S90 + ep.S91 + ep.S92 + ep.S93 + ep.S94 + ep.S95;


                if ((int)ResultTest9 <= 236)
                    EPTListPersonModel_.ResultTestText = "نتیجه تست :بسیار ضعیف ";
                else if ((int)ResultTest9 >= 236 && (int)ResultTest9 < 265)
                    EPTListPersonModel_.ResultTestText = "نتیجه تست : ضعیف ";
                else if ((int)ResultTest9 >= 265 && (int)ResultTest9 < 295)
                    EPTListPersonModel_.ResultTestText = " نتیجه تست : متوسط";
                else if ((int)ResultTest9 >= 295 && (int)ResultTest9 < 324)
                    EPTListPersonModel_.ResultTestText = "نتیجه تست : قوی ";
                else if ((int)ResultTest9 >= 324)
                    EPTListPersonModel_.ResultTestText = "نتیجه تست : بسیار قوی";

                string ResultTest1Text = " ریسک پذیری متعادل ";
                string ResultTest2Text = " کانون کنترل ";
                string ResultTest3Text = " نياز به موفقيت  ";
                string ResultTest4Text = " سالمت فکري ";
                string ResultTest5Text = " عملگرايي ";
                string ResultTest6Text = " تحمل ابهام ";
                string ResultTest7Text = " رويا پردازي ";
                string ResultTest8Text = " چالش طلبي ";

                if ((int)ResultTest1 <= 43)
                    ResultTest1Text += "بسیار ضعیف";
                else if ((int)ResultTest1 >= 43 && (int)ResultTest1 < 51)
                    ResultTest1Text += "ضعیف";
                else if ((int)ResultTest1 >= 51 && (int)ResultTest1 < 57)
                    ResultTest1Text += "قوی";
                else if ((int)ResultTest1 >= 57)
                    ResultTest1Text += "بسیار قوی";


                if ((int)ResultTest2 <= 49)
                    ResultTest2Text += "بسیار ضعیف";
                else if ((int)ResultTest2 >= 49 && (int)ResultTest2 < 55)
                    ResultTest2Text += "ضعیف";
                else if ((int)ResultTest2 >= 55 && (int)ResultTest2 < 60)
                    ResultTest2Text += "قوی";
                else if ((int)ResultTest2 >= 60)
                    ResultTest2Text += "بسیار قوی";

                if ((int)ResultTest3 <= 44)
                    ResultTest3Text += "بسیار ضعیف";
                else if ((int)ResultTest3 >= 44 && (int)ResultTest3 < 48)
                    ResultTest3Text += "ضعیف";
                else if ((int)ResultTest3 >= 48 && (int)ResultTest3 < 53)
                    ResultTest3Text += "قوی";
                else if ((int)ResultTest3 >= 53)
                    ResultTest3Text += "بسیار قوی";


                if ((int)ResultTest4 <= 34)
                    ResultTest4Text += "بسیار ضعیف";
                else if ((int)ResultTest4 >= 34 && (int)ResultTest4 < 38)
                    ResultTest4Text += "ضعیف";
                else if ((int)ResultTest4 >= 38 && (int)ResultTest4 < 43)
                    ResultTest4Text += "قوی";
                else if ((int)ResultTest4 >= 52)
                    ResultTest4Text += "بسیار قوی";


                if ((int)ResultTest5 <= 25)
                    ResultTest5Text += "بسیار ضعیف";
                else if ((int)ResultTest5 >= 25 && (int)ResultTest5 < 28)
                    ResultTest5Text += "ضعیف";
                else if ((int)ResultTest5 >= 28 && (int)ResultTest5 < 30)
                    ResultTest5Text += "قوی";
                else if ((int)ResultTest5 >= 30)
                    ResultTest5Text += "بسیار قوی";

                if ((int)ResultTest6 <= 18)
                    ResultTest6Text += "بسیار ضعیف";
                else if ((int)ResultTest6 >= 18 && (int)ResultTest6 < 22)
                    ResultTest6Text += "ضعیف";
                else if ((int)ResultTest6 >= 22 && (int)ResultTest6 < 26)
                    ResultTest6Text += "قوی";
                else if ((int)ResultTest6 >= 26)
                    ResultTest6Text += "بسیار قوی";

                if ((int)ResultTest7 <= 19)
                    ResultTest7Text += "بسیار ضعیف";
                else if ((int)ResultTest7 >= 19 && (int)ResultTest7 < 21)
                    ResultTest7Text += "ضعیف";
                else if ((int)ResultTest7 >= 21 && (int)ResultTest7 < 23)
                    ResultTest7Text += "قوی";
                else if ((int)ResultTest7 >= 23)
                    ResultTest7Text += "بسیار قوی";

                if ((int)ResultTest8 <= 16)
                    ResultTest8Text += "بسیار ضعیف";
                else if ((int)ResultTest8 >= 16 && (int)ResultTest8 < 19)
                    ResultTest8Text += "ضعیف";
                else if ((int)ResultTest8 >= 19 && (int)ResultTest8 < 21)
                    ResultTest8Text += "قوی";
                else if ((int)ResultTest8 >= 21)
                    ResultTest8Text += "بسیار قوی";

                ResultTest1 = ResultTest1 == 0 ? 1 : ((ResultTest1 - 18) / 54) * 100;
                ResultTest2 = ResultTest2 == 0 ? 1 : ((ResultTest2 - 17) / 51) * 100;
                ResultTest3 = ResultTest3 == 0 ? 1 : ((ResultTest3 - 15) / 45) * 100;
                ResultTest4 = ResultTest4 == 0 ? 1 : ((ResultTest4 - 13) / 39) * 100;
                ResultTest5 = ResultTest5 == 0 ? 1 : ((ResultTest5 - 8) / 24) * 100;
                ResultTest6 = ResultTest6 == 0 ? 1 : ((ResultTest6 - 11) / 33) * 100;
                ResultTest7 = ResultTest7 == 0 ? 1 : ((ResultTest7 - 7) / 21) * 100;
                ResultTest8 = ResultTest8 == 0 ? 1 : ((ResultTest8 - 6) / 18) * 100;
                ResultTest9 = ResultTest9 == 0 ? 1 : ((ResultTest9 - 95) / 285) * 100;

                EPTListPersonModel_.ResultTest1 = (int)ResultTest1;
                EPTListPersonModel_.ResultTest2 = (int)ResultTest2;
                EPTListPersonModel_.ResultTest3 = (int)ResultTest3;
                EPTListPersonModel_.ResultTest4 = (int)ResultTest4;
                EPTListPersonModel_.ResultTest5 = (int)ResultTest5;
                EPTListPersonModel_.ResultTest6 = (int)ResultTest6;
                EPTListPersonModel_.ResultTest7 = (int)ResultTest7;
                EPTListPersonModel_.ResultTest8 = (int)ResultTest8;
                EPTListPersonModel_.ResultTest9 = (int)ResultTest9;


                EPTListPersonModel_.ResultTest1Text = ResultTest1Text;
                EPTListPersonModel_.ResultTest2Text = ResultTest2Text;
                EPTListPersonModel_.ResultTest3Text = ResultTest3Text;
                EPTListPersonModel_.ResultTest4Text = ResultTest4Text;
                EPTListPersonModel_.ResultTest5Text = ResultTest5Text;
                EPTListPersonModel_.ResultTest6Text = ResultTest6Text;
                EPTListPersonModel_.ResultTest7Text = ResultTest7Text;
                EPTListPersonModel_.ResultTest8Text = ResultTest8Text;

            }
            else
            {
                EPTListPersonModel_.ResultTestText = "$$";

            }

            return EPTListPersonModel_;

        }
        public EptQuestionList? EptPersonById(int? id, IEPTRepository repository)
        {
            return repository.EptQuestion.FirstOrDefault(x => x.x_ == id);

        }
        public bool EptPersonDeleteById(int? ept, IEPTRepository repository)
        {
            try
            {
                var per = repository.EptQuestion.FirstOrDefault(x => x.x_ == ept);

                repository.DelEptQuestion(per);
                repository.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;


            }

        }
        public List<EPTQuizTextModel> EptQuizTextList( IEPTRepository repository)
        {
            List<EPTQuizTextModel> EPT = new List<EPTQuizTextModel>();
            IEnumerable<EptQuiz> EptQuizText_ = repository.EptQuizText;
            var EptQuizTextList_ = EptQuizText_.ToList();
            foreach (var item in EptQuizTextList_)
            {
                EPT.Add(new EPTQuizTextModel
                {
                    Question = item.Question,
                    Answer1 = item.Answer1,
                    Answer2 = item.Answer2,
                    Answer3 = item.Answer3,
                    Answer4 = item.Answer4
                });
            }
            return EPT;
        }
    }
}
