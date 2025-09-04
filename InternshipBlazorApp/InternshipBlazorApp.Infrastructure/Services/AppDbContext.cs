using Microsoft.EntityFrameworkCore;

namespace InternshipBlazorApp.Infrastructure.Services;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions options): base(options)
    {
    }
}