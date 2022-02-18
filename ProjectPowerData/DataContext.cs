using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectPowerData.Folder.Models;
namespace ProjectPowerData
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<BasicWorkoutInformation> BasicWorkoutInformation { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=projectpowerwebapidbserver.database.windows.net; Database=ProjectPowerWebApi_db;User Id=bigdave;Password=Zelfdwnq9512!;");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
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

