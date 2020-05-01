using Microsoft.EntityFrameworkCore;
using Webmvc.Models;

namespace Webmvc.Databases.Context
{
    public class WebMvcContext : DbContext
    {
        public WebMvcContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Assuring that Category Name is Unique on Our Database
            builder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            base.OnModelCreating(builder);
        }

        public DbSet<Category> Categories { get; set; }
    }
}