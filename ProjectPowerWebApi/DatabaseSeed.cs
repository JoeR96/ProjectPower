using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;

namespace ProjectPowerWebApi
{
    public class DatabaseSeed
    {
        public static void Seed(DataContext context, IPasswordHasherService passwordHasher)
        {
            //context.Database.EnsureCreated();
        }
    }
}
