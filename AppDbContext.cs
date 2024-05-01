using Microsoft.EntityFrameworkCore;

namespace BookAPI
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Models.Book> Books { get; set; }
    }
}