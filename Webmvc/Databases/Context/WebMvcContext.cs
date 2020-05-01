using Microsoft.EntityFrameworkCore;
using Webmvc.Models;

namespace Webmvc.Databases.Context
{
    public class WebMvcContext : DbContext
    {
        public WebMvcContext(DbContextOptions options) : base(options)
        {
        }

        public WebMvcContext() : base()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Assuring that Category name is unique on database
            builder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            // Assuring that Product name is unique on database
            builder.Entity<Product>()
                .HasIndex(p => p.Name)
                .IsUnique();

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}