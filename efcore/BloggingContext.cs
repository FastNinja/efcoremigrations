using Microsoft.EntityFrameworkCore;

namespace efcore
{
    public class BloggingContext : DbContext
    {
        private readonly string _connectionString;
 
        public BloggingContext()
        {
            // used only EF migration comands
            _connectionString = "does not matter";
        }

        public BloggingContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }

        public void MigrateSchema(){
            this.Database.Migrate();
        }
    }
}