namespace Domain.Model
{
    public class QuizQuestionDisc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int QuestionNumber { get; set; }
        public int ItemNumber { get; set; }
        public ICollection<QuizAnswernDisc> QuizAnswers { get; set; } // ارتباط یک به چند
    }

}
