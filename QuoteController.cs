using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("/api/quote")]
public class QuoteController(AppDbContext _db) : ControllerBase
{

    [HttpGet]
    public async Task<ActionResult<Quote>> GetQuote()
    {
        int qoutesLength = await _db.Quotes.CountAsync();
        int randomId = Random.Shared.Next(1, qoutesLength);

        Quote? quote = await _db.Quotes.FirstOrDefaultAsync((q) => q.Id == randomId);


        if (quote is null)
        {
            return NotFound();
        }

        return Ok(quote);
    }

    [HttpGet("all")]
    public async Task<ActionResult<List<Quote>>> GetAllQuotes()
    {

        return Ok(await _db.Quotes.ToListAsync());
    }

}