using CharityTestCore.Models;
using DAL.DataBase;

namespace CharityTestCore.Repository.EPT
{
    public class EPTRepository: IEPTRepository
    {
        private ParkerCharityContext context = new ParkerCharityContext();
        public IEnumerable<EptQuiz> EptQuizText
        {
            get { return context.EptQuiz; }

        }
        public void AddEptQuestion(EptQuestionList item)
        {
            context.EptQuestion.Add(item);
        }
        public void DelEptQuestion(EptQuestionList item)
        {
            item.IsDelete = true;
            context.SaveChanges();

        }
        public EptQuestionList? GetEptByUserId(string UserId)
        {
            return  context.EptQuestion.FirstOrDefault(x => x.UserId_ ==  UserId);

        }
        public IEnumerable<EptQuestionList> EptQuestion
        {
            get { return context.EptQuestion; }
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
