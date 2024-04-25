using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions options):base(options){}

        public DbSet<Product> Products { get; set; }
    }
}