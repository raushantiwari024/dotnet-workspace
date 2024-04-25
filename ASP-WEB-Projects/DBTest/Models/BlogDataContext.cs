using Microsoft.EntityFrameworkCore;

namespace DBTest.Models
{
    public class BlogDataContext : DbContext
    {
        static readonly string connectionString = "server=localhost;port=3306;database=dotdbexit;user=root;password=Android@test1";

        public DbSet<Author> Authors { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}