using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Serilog;
using System.IO;

namespace RealEstate.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            new WebHostBuilder()
                .UseKestrel()
                .UseIISIntegration()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureLogging((context, builder) =>
                {
                    var logger = new LoggerConfiguration()
                        .ReadFrom
                        .ConfigurationSection(context.Configuration.GetSection("Logging"))
                        .CreateLogger();

                    builder.AddSerilog(logger, true);
                })
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(context.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", false, true)
                        .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", true, true)
                        .AddEnvironmentVariables();
                })
                .UseStartup<Startup>();
    }
}
