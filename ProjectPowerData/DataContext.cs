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

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EFLab;");
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
                .HasDiscriminator<int>("Discriminator")
                .HasValue<BasicWorkoutInformation>(0)
                .HasValue<A2SHyperTrophy>(1)
                .HasValue<A2SRepsThenSets>(2);
        }
    }
}
    
