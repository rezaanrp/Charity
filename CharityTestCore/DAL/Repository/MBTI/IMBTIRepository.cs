using Domain.Model;

namespace CharityTestCore.Repository.MBTI
{
    public interface IMBTIRepository
    {

        IEnumerable<MBTIQuestionList> MBTIQuestionList { get; }

        IEnumerable<MBTIAnswerList> MBTIAnswerList { get; }

        void AddMBTIAnswerList(MBTIAnswerList item);

        void DelMBTIQuestion(MBTIAnswerList item);

        void SaveChanges();
         MBTIAnswerList? GetByUserId(Guid UserId);
        void Update(MBTIAnswerList entity);
    }
}
