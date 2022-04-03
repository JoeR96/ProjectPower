using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectPowerData.Folder.Models;
namespace ProjectPowerData
{
    public class DataContext : DbContext
    {
        public DataContext() : base() { }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<User> UserAccounts { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=45.86.209.218; Database=ProjectPower; User Id=SA;Password=Zelfdwnq9512!;");

            //optionsBuilder.UseSqlServer("Server=projectpowerwebapidbserver.database.windows.net; Database=ProjectPowerWebApi_db;User Id=bigdave;Password=Zelfdwnq9512!;");
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

            modelBuilder.Entity<Exercise>()
                .ToTable("BasicWorkoutInformation")
                .HasDiscriminator<string>("Template")
                .HasValue<A2SHyperTrophy>("A2SHypertrophy")
                .HasValue<A2SSetsThenReps>("A2SRepsThenSets");

            modelBuilder.Entity<UserRole>().HasKey(ur => new { ur.UserId, ur.RoleId });

        }
    }
}

