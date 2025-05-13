using DAL.DataBase;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

public class QuizQuestionDiscRepository : IQuizQuestionDiscRepository
{
	private readonly ParkerCharityContext _context;

	public QuizQuestionDiscRepository(ParkerCharityContext context)
	{
		_context = context;
	}

	public async Task<QuizQuestionDisc> GetByIdAsync(int id)
	{
		return await _context.QuizQuestionDiscs
							 .Include(q => q.QuizAnswers)
							 .FirstOrDefaultAsync(q => q.Id == id);
	}
	public async Task<QuizQuestionDisc> GetByQuestionNumberAsync(int questionnumber, int itemnumber)
	{
		return await _context.QuizQuestionDiscs.FirstOrDefaultAsync(x => x.QuestionNumber == questionnumber && x.ItemNumber == itemnumber);
	}
    public async Task<IEnumerable<QuizQuestionDisc>> GetAllAsync()
	{
		return await _context.QuizQuestionDiscs
							 .Include(q => q.QuizAnswers)
							 .ToListAsync();
	}

	public async Task AddAsync(QuizQuestionDisc quizQuestion)
	{
		await _context.QuizQuestionDiscs.AddAsync(quizQuestion);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(QuizQuestionDisc quizQuestion)
	{
		_context.QuizQuestionDiscs.Update(quizQuestion);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(int id)
	{
		var quizQuestion = await GetByIdAsync(id);
		if (quizQuestion != null)
		{
			_context.QuizQuestionDiscs.Remove(quizQuestion);
			await _context.SaveChangesAsync();
		}
	}
}
