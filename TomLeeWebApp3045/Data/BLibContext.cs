using Microsoft.EntityFrameworkCore;
using TomLeeWebApp3045.Models;

namespace TomLeeWebApp3045.Data
{
    public class BLibContext : DbContext
    {
        public BLibContext(DbContextOptions<BLibContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BLib>().HasData(
                new BLib
                {
                    Id = 1,
                    Name = "Welcome to the BLib!",
                    Category = "Uncategorized",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new BLib
                {
                    Id = 2,
                    Name = "The Time Machine",
                    Category = "Science Fiction",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new BLib
                {
                    Id = 3,
                    Name = "Narrative of the Life of Frederick Douglass",
                    Category = "History",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new BLib
                {
                    Id = 4,
                    Name = "Color Images from Mars Rovers",
                    Category = "Technology",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new BLib
                {
                    Id = 5,
                    Name = "The Notebooks of Leonardo da Vinci",
                    Category = "Art",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new BLib
                {
                    Id = 6,
                    Name = "Moby Dick",
                    Category = "Literature",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
        }

        public DbSet<BLib> UserLib { get; set; }
    }
}