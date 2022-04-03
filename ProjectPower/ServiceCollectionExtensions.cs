using Microsoft.Extensions.DependencyInjection;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPower.Areas.WorkoutCreation.Services;
using ProjectPowerData;

namespace ProjectPower
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterUserAccountServiceServices(this IServiceCollection collection)
        {
            collection.AddScoped<IUserAccountService, UserAccountService>();
        }

        public static void RegisterWorkoutManagementService(this IServiceCollection collection)
        {
            collection.AddScoped<IWorkoutManagementService, WorkoutManagementService>();

        }
        public static void AddDataContext(this IServiceCollection collection)
        {
            collection.AddDbContext<DataContext>();

        }
    }
}
