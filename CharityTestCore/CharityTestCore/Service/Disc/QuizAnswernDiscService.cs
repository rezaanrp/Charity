using DAL.DataBase;

public class QuizAnswernDiscService : IQuizAnswernDiscService
{
	private readonly IQuizAnswernDiscRepository _quizAnswernDiscRepository;

	public QuizAnswernDiscService(IQuizAnswernDiscRepository quizAnswernDiscRepository)
	{
		_quizAnswernDiscRepository = quizAnswernDiscRepository;
	}

	public async Task<QuizAnswernDisc> GetByIdAsync(int id)
	{
		return await _quizAnswernDiscRepository.GetByIdAsync(id);
	}

	public async Task<IEnumerable<QuizAnswernDisc>> GetByQuizQuestionDiscIdAsync(int quizQuestionDiscId)
	{
		return await _quizAnswernDiscRepository.GetByQuizQuestionDiscIdAsync(quizQuestionDiscId);
	}

	public async Task AddAsync(QuizAnswernDisc quizAnswer)
	{
		await _quizAnswernDiscRepository.AddAsync(quizAnswer);
	}

	public async Task UpdateAsync(QuizAnswernDisc quizAnswer)
	{
		await _quizAnswernDiscRepository.UpdateAsync(quizAnswer);
	}

	public async Task DeleteAsync(int id)
	{
		await _quizAnswernDiscRepository.DeleteAsync(id);
	}
}
