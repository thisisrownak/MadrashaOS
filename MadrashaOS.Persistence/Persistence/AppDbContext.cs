using MadrashaOS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MadrashaOS.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Define your DbSets here. For example:
        public DbSet<Product> Products { get; set; }
    }
}
