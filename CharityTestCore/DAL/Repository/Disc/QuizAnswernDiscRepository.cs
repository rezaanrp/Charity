using Domain.DataBase;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

public class QuizAnswernDiscRepository : IQuizAnswernDiscRepository
{
	private readonly ParkerCharityContext _context;

	public QuizAnswernDiscRepository(ParkerCharityContext context)
	{
		_context = context;
	}

	public async Task<QuizAnswernDisc> GetByIdAsync(int id)
	{
		return await _context.QuizAnswernDiscs
							 .FirstOrDefaultAsync(q => q.Id == id);
	}

	public async Task<IEnumerable<QuizAnswernDisc>> GetByQuizQuestionDiscIdAsync(int quizQuestionDiscId)
	{
		return await _context.QuizAnswernDiscs
							 .Where(q => q.QuizQuestionDiscId == quizQuestionDiscId)
							 .ToListAsync();
	}

	public async Task AddAsync(QuizAnswernDisc quizAnswer)
	{
		await _context.QuizAnswernDiscs.AddAsync(quizAnswer);
		await _context.SaveChangesAsync();
	}

	public async Task UpdateAsync(QuizAnswernDisc quizAnswer)
	{
		_context.QuizAnswernDiscs.Update(quizAnswer);
		await _context.SaveChangesAsync();
	}

	public async Task DeleteAsync(int id)
	{
		var quizAnswer = await GetByIdAsync(id);
		if (quizAnswer != null)
		{
			_context.QuizAnswernDiscs.Remove(quizAnswer);
			await _context.SaveChangesAsync();
		}
	}
}
