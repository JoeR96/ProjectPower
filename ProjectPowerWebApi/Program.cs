using ProjectPower.Areas.UserAccounts.Services.Interfaces;
using ProjectPowerData;

namespace ProjectPowerWebApi
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetService<DataContext>();
                var passwordHasher = services.GetService<IPasswordHasherService>();
                DatabaseSeed.Seed(context, passwordHasher);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseUrls("localhost:44317")
                    webBuilder.UseStartup<Startup>();

                });
    }
}
