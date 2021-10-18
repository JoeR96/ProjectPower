
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ProjectPower.Areas.A2S_Program.Helpers;

namespace ProjectPowerWebApi
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
