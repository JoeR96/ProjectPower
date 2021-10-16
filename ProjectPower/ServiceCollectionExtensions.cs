﻿using Microsoft.Extensions.DependencyInjection;
using ProjectPower.Areas.A2S_Program.Service;
using ProjectPower.Areas.A2S_Program.Service.Interfaces;
using ProjectPower.Areas.UserAccounts.Services;
using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;

namespace ProjectPower
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterUserAcctionServices(this IServiceCollection collection)
        {
            collection.AddScoped<IUserAccountService, UserAccountService>();
        }

        public static void RegisterBasicWorkoutInformation(this IServiceCollection collection)
        {
            collection.AddScoped<IBasicWorkoutInformationService, BasicWorkoutInformationService>();
        }

        public static void RegisterA2SWorkout(this IServiceCollection collection)
        {
            collection.AddScoped<IA2SWorkoutService, A2SWorkoutService>();
        }
        public static void AddDataContext(this IServiceCollection collection)
        {
            collection.AddDbContext<DataContext>();
        }
    }
}
