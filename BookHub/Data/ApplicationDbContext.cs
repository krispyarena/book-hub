using BookHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BookHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Sci-Fi", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Histpry", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Drama", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Story", DisplayOrder = 5 }
                );
        }
    }
}
