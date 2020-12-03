using Microsoft.EntityFrameworkCore;

namespace BlazorServerSideDbContextIssue
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo { Id = 1, Title = "Test" },
                new Todo { Id = 2, Title = "Test2" },
                new Todo { Id = 3, Title = "Test3" }
            );
        }
    }
}