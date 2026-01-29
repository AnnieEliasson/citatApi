using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Lägg till den DbContext ni skapar för er databas här
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=app.db"));

//Låt detta vara kvar! Utan denna inställning kommer inte websidan att få access till API:et.
// Läs mer här: https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    //db.Database.EnsureDeleted();
    db.Database.EnsureCreated();


    List<string> quotes = File.ReadAllLines("Data/quotes.txt").ToList();

    if (!db.Quotes.Any())
    {
        db.Quotes.AddRange(
            quotes.Select(q => new Quote { Text = q })
        );

        db.SaveChanges();
    }
}

// Denna hör ihop med CORS-inställningen ovan
app.UseCors();

//Ni ska inte skriva era endpoints här i Program.cs utan i separata controllers, så använd denna:
app.MapControllers();

app.Run();


public class Quote
{
    public int Id { get; set; }
    public required string Text { get; set; }
}