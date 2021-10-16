using ProjectPowerDAL.Folder.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectPowerDAL
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }

        public DbSet<WorkoutExerciseInformation> StockItems { get; set; }

        public DbSet<UserAccount> Units { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EFLab;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
