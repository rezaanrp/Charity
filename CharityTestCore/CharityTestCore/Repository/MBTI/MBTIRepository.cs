using DAL.DataBase;

namespace CharityTestCore.Repository.MBTI
{
    public class MBTIRepository: IMBTIRepository
    {
        private ParkerCharityContext context = new ParkerCharityContext();

        public IEnumerable<MBTIQuestionList> MBTIQuestionList
        {
            get { return context.MBTIQuestionList; }

        }
        public IEnumerable<MBTIAnswerList> MBTIAnswerList
        {
            get { return context.MBTIAnswerList; }

        }
        public void AddMBTIAnswerList(MBTIAnswerList item)
        {
            context.MBTIAnswerList.Add(item);
        }
        public void DelMBTIQuestion(MBTIAnswerList item)
        {
            context.MBTIAnswerList.Remove(item);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
