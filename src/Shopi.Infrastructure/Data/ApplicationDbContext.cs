using Microsoft.EntityFrameworkCore;

namespace Shopi.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    private readonly DbContextOptions<ApplicationDbContext> options;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer();
    }
}