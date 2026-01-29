using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("/api/quote")]
public class QuoteController(AppDbContext _db) : ControllerBase
{

    // GET RANDOM QUOTE
    [HttpGet]
    public async Task<ActionResult<Quote>> GetQuote()
    {
        if (!await _db.Quotes.AnyAsync())
        {
            return NotFound();
        }

        int qoutesLength = await _db.Quotes.CountAsync();
        int randomId = Random.Shared.Next(1, qoutesLength);

        Quote? quote = await _db.Quotes.FirstOrDefaultAsync((q) => q.Id == randomId);

        return Ok(quote);
    }

    // GET ALL QUOTES
    [HttpGet("all")]
    public async Task<ActionResult<List<Quote>>> GetAllQuotes()
    {

        return Ok(await _db.Quotes.ToListAsync());
    }


    // GET QUOTE BY ID
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Quote>> GetByIdQuote(int id)
    {
        Quote? quote = await _db.Quotes.FirstOrDefaultAsync((q) => q.Id == id);

        if (quote is null)
        {
            return NotFound();
        }

        return Ok(quote);
    }

    // SEARCH QUOTEs
    [HttpPost("search")]
    public async Task<ActionResult<List<Quote>>> SearchQuotes(string s)
    {

        var result = await _db.Quotes.Where(b => EF.Functions.Like(b.Text, $"%{s}%")).ToListAsync();

        return Ok(result);
    }

}

