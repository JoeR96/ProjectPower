using ProjectPowerData.Folder.Models;
using Microsoft.EntityFrameworkCore;
namespace ProjectPowerData
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<BasicWorkoutInformation> BasicWorkoutInformation { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; }
        public DbSet<A2SHyperTrophy> A2SWorkoutExercises { get; set; }
        public DbSet<A2SRepsThenSets> A2SWorkoutTemplate { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ProjectPower;");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<A2SHyperTrophy>()
                        .Property(p => p.TrainingMax)
                        .HasPrecision(9, 4);


            modelBuilder.Entity<A2SHyperTrophy>()
                        .Property(p => p.Intensity)
                        .HasPrecision(9, 4);

            modelBuilder.Entity<BasicWorkoutInformation>()
                .HasDiscriminator<string>("Template")
                .HasValue<BasicWorkoutInformation>("BasicWorkoutInformation")
                .HasValue<A2SHyperTrophy>("A2SHyperTrophy")
                .HasValue<A2SRepsThenSets>("A2SRepsThenSets");

        }
    }
}
    
