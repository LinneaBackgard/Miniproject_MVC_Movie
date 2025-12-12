using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Miniproject_MVC_Movie.Models;

namespace Miniproject_MVC_Movie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Sätt precision för Rating (max 3 siffror totalt, 1 decimal, t.ex. 9.5 eller 10.0)
            builder.Entity<Movie>()
                .Property(m => m.Rating)
                .HasPrecision(3, 1);
        }
    }
}
