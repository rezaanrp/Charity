using DAL.DataBase;

public interface IQuizQuestionDiscRepository
{
	Task<QuizQuestionDisc> GetByIdAsync(int id);
	Task<QuizQuestionDisc> GetByQuestionNumberAsync(int questionnumber, int itemnumber);


    Task<IEnumerable<QuizQuestionDisc>> GetAllAsync();
	Task AddAsync(QuizQuestionDisc quizQuestion);
	Task UpdateAsync(QuizQuestionDisc quizQuestion);
	Task DeleteAsync(int id);
}
