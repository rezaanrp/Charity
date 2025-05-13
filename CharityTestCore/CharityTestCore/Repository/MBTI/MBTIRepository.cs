using DAL.DataBase;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

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
        public void Update(MBTIAnswerList entity)
        {
            context.MBTIAnswerList.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges(); // اگر نخواهید جداگانه Save صدا بزنید
        }
        public void AddMBTIAnswerList(MBTIAnswerList item)
        {
            context.MBTIAnswerList.Add(item);
        }
        public void DelMBTIQuestion(MBTIAnswerList item)
        {
            var t = context.MBTIAnswerList.Find(item.Id);
            if (t != null)
            {
              t.IsDelete = true;
            }
            context.SaveChanges();

        }

        public MBTIAnswerList? GetByUserId(Guid UserId)
        {
            return context.MBTIAnswerList.FirstOrDefault(x => x.UserId == UserId);

        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
