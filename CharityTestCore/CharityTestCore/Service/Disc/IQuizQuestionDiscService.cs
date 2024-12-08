using DAL.DataBase;

public interface IQuizQuestionDiscService
{
	Task<QuizQuestionDisc> GetByIdAsync(int id);
	Task<IEnumerable<QuizQuestionDisc>> GetAllAsync();
	Task AddAsync(QuizQuestionDisc quizQuestion);
	Task UpdateAsync(QuizQuestionDisc quizQuestion);
	Task DeleteAsync(int id);
}
