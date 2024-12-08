using DAL.DataBase;

public class QuizQuestionDiscService : IQuizQuestionDiscService
{
	private readonly IQuizQuestionDiscRepository _quizQuestionDiscRepository;

	public QuizQuestionDiscService(IQuizQuestionDiscRepository quizQuestionDiscRepository)
	{
		_quizQuestionDiscRepository = quizQuestionDiscRepository;
	}

	public async Task<QuizQuestionDisc> GetByIdAsync(int id)
	{
		return await _quizQuestionDiscRepository.GetByIdAsync(id);
	}

	public async Task<IEnumerable<QuizQuestionDisc>> GetAllAsync()
	{
		return await _quizQuestionDiscRepository.GetAllAsync();
	}

	public async Task AddAsync(QuizQuestionDisc quizQuestion)
	{
		await _quizQuestionDiscRepository.AddAsync(quizQuestion);
	}

	public async Task UpdateAsync(QuizQuestionDisc quizQuestion)
	{
		await _quizQuestionDiscRepository.UpdateAsync(quizQuestion);
	}

	public async Task DeleteAsync(int id)
	{
		await _quizQuestionDiscRepository.DeleteAsync(id);
	}
}
