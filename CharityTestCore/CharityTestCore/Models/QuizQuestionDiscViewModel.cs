using Domain.DataBase;
using System.ComponentModel.DataAnnotations;

namespace CharityTestCore.Models
{
    public class QuizQuestionDiscViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int QuestionNumber { get; set; }
        public int ItemNumber { get; set; }


    }
}
