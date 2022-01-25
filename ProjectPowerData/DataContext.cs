using ProjectPowerData.Folder.Models;
using Microsoft.EntityFrameworkCore;
namespace ProjectPowerData
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<BasicWorkoutInformation> BasicWorkoutInformation { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=ProjectPower;");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<A2SHyperTrophy>()
                         .ToTable("BasicWorkoutInformation")
                        .Property(p => p.TrainingMax)
                        .HasPrecision(9, 4);


            modelBuilder.Entity<A2SHyperTrophy>()
                        .ToTable("BasicWorkoutInformation")
                        .Property(p => p.Intensity)
                        .HasPrecision(9, 4);

            modelBuilder.Entity<BasicWorkoutInformation>()
                .ToTable("BasicWorkoutInformation")
                .HasDiscriminator<string>("Template")
                .HasValue<A2SHyperTrophy>("A2SHypertrophy")
                .HasValue<A2SSetsThenReps>("A2SRepsThenSets");


        }
    }
}
    
