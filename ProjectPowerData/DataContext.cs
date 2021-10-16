using ProjectPowerData.Folder.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectPowerData
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<BasicWorkoutInformation> BasicWorkoutInformation { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; }
        public DbSet<A2SHyperTrophyModel> A2SWorkoutExercises { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EFLab;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
