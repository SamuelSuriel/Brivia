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

        public DbSet<UserEntity> UserEntities { get; set; }

        //public DbSet<GameEntity> GameEntities { get; set; }

        //public DbSet<GameDetailEntity> GameDetailEntities { get; set; }

        //public DbSet<HistoricalEntity> HistoricalEntities { get; set; }


    }
}
