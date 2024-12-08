using CharityTestCore.Models;
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

	public async Task<IEnumerable<QuizQuestionDiscViewModel>> GetAllAsync()
	{

		var m = await _quizQuestionDiscRepository.GetAllAsync();
		var model = new List<QuizQuestionDiscViewModel>();

        foreach (var item in m)
		{
			var mi = new QuizQuestionDiscViewModel()
			{
				Id = item.Id,
				Name = item.Name,
				Category = item.Category,
				QuestionNumber = item.QuestionNumber,	
			};
            model.Add(mi);	

        }
		return model;

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
