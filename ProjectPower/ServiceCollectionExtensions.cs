using Microsoft.Extensions.DependencyInjection;
using ProjectPower.Areas.A2S_Program.Service;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPower.Areas.WorkoutCreation.Services;
using ProjectPowerData;

namespace ProjectPower
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterUserAcctionServices(this IServiceCollection collection)
        {
            collection.AddScoped<IUserAccountService, UserAccountService>();
        }

        public static void RegisterA2SWorkout(this IServiceCollection collection)
        {
            collection.AddScoped<IA2SWorkoutService, A2SWorkoutService>();
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
