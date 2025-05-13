using Domain.Model;

namespace CharityTestCore.Repository.EPT
{
    public interface IEPTRepository
    {
        IEnumerable<EptQuiz> EptQuizText { get; }
        void AddEptQuestion(EptQuestionList item);
        void DelEptQuestion(EptQuestionList item);
        IEnumerable<EptQuestionList> EptQuestion { get; }
        void SaveChanges();
        public EptQuestionList? GetEptByUserId(string UserId);

    }
}
