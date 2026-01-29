using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Quote> Quotes => Set<Quote>();
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
