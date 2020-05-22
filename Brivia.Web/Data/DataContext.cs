using Brivia.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Brivia.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<QuestionEntity> Questions { get; set; }

        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuestionEntity>()
        .HasIndex(t => t.Question)
        .IsUnique();
        }
    }
}
