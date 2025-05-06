using DAL.DataBase;

namespace CharityTestCore.Models
{
    public class QuizAnswernDiscViewModel
    {
        public int Id { get; set; }
        public int QuizQuestionDiscId { get; set; }
        public decimal Score { get; set; }
        public string UserId { get; set; }

        public QuizQuestionDisc QuizQuestion { get; set; } // ارتباط با QuizQuestionDisc
    }
}
