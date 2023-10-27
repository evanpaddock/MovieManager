using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieManager.Models;

namespace MovieManager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MovieManager.Models.Movie>? Movie { get; set; }
        public DbSet<MovieManager.Models.Actor>? Actor { get; set; }
        public DbSet<MovieManager.Models.ActorMovie>? ActorMovie { get; set; }
    }
}