using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectPowerWebApi
{
    public class DatabaseSeed
    {
        public static void Seed(DataContext context, IPasswordHasherService passwordHasher)
        {
            context.Database.EnsureCreated();
        }
    }
}
