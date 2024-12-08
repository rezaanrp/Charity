using DAL.DataBase;

public interface IQuizAnswernDiscService
{
	Task<QuizAnswernDisc> GetByIdAsync(int id);
	Task<IEnumerable<QuizAnswernDisc>> GetByQuizQuestionDiscIdAsync(int quizQuestionDiscId);
	Task AddAsync(QuizAnswernDisc quizAnswer);
	Task UpdateAsync(QuizAnswernDisc quizAnswer);
	Task DeleteAsync(int id);
}
