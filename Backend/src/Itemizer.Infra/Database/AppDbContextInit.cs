namespace Itemizer.Infrastructure.Database;

public class AppDbContextInit(AppDbContext context, ILoggerFactory logger)
{
    private readonly AppDbContext _context = context;
    private readonly ILogger _logger = logger.CreateLogger<AppDbContext>();

    public async Task InitializeAsync()
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception exception)
        {
            _logger.LogError("Error occurred during migrations {exception}", exception);
            throw;
        }
    }

    public async Task SeedItem()
    {
        await _context.SaveChangesAsync();
        throw new NotImplementedException();
    }
}
