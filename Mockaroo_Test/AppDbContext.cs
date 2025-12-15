using Microsoft.EntityFrameworkCore;

namespace Mockaroo_Test
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Club> Clubs { get; set; }
    }
}
