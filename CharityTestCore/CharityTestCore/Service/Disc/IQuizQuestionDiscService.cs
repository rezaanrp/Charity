using CharityTestCore.Models;
using Domain.Model;

public interface IQuizQuestionDiscService
{
	Task<QuizQuestionDiscViewModel> GetByIdAsync(int id);
	Task<QuizQuestionDiscViewModel> GetByQuestionNumberAsync(int questionnumber, int itemnumber);


    Task<IEnumerable<QuizQuestionDiscViewModel>> GetAllAsync();
	Task AddAsync(QuizQuestionDisc quizQuestion);
	Task UpdateAsync(QuizQuestionDisc quizQuestion);
	Task DeleteAsync(int id);
}
