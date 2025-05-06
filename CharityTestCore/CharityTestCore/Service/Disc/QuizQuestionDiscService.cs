using CharityTestCore.Models;
using DAL.DataBase;

public class QuizQuestionDiscService : IQuizQuestionDiscService
{
	private readonly IQuizQuestionDiscRepository _quizQuestionDiscRepository;

	public QuizQuestionDiscService(IQuizQuestionDiscRepository quizQuestionDiscRepository)
	{
		_quizQuestionDiscRepository = quizQuestionDiscRepository;
	}

	public async Task<QuizQuestionDiscViewModel> GetByIdAsync(int id)
	{
		var result = await _quizQuestionDiscRepository.GetByIdAsync(id);
		var model = new QuizQuestionDiscViewModel()
		{
			Id = result.Id,
			ItemNumber = result.ItemNumber,
			QuestionNumber = result.QuestionNumber,
			Name = result.Name,
			Category = result.Category,

		};
		return model;
	}
    public async Task<QuizQuestionDiscViewModel> GetByQuestionNumberAsync(int questionnumber, int itemnumber)
    {
        var result = await _quizQuestionDiscRepository.GetByQuestionNumberAsync(questionnumber, itemnumber);
        var model = new QuizQuestionDiscViewModel()
        {
            Id = result.Id,
            ItemNumber = result.ItemNumber,
            QuestionNumber = result.QuestionNumber,
            Name = result.Name,
            Category = result.Category,

        };
        return model;
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
