using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using NgAPI.Models;

namespace AngularAuthYtAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>().ToTable("users");
        }
    }
}
