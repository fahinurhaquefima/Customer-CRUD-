using CMS.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CMS.WebApp.DatabaseContext;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : DbContext(dbContext)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

}
