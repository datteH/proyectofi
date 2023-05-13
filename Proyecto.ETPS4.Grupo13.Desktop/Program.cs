using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Proyecto.ETPS4.Grupo13.Service.Extensions;

namespace Proyecto.ETPS4.Grupo13.Desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var host = Host.CreateDefaultBuilder()
                           .ConfigureAppConfiguration((context, builder) =>
                           {
                               builder.AddJsonFile("appsettings.json", optional: true);
                           }).ConfigureServices((context, services) =>
                           {
                               services.AddScoped<Login>();
                               services.ConfigureSqlContext(context.Configuration);
                               services.AddAuthentication();
                               services.ConfigureRepositoryManager();
                               services.ConfigureServiceManager();
                               services.ConfigureIdentity();
                               services.AddHttpContextAccessor();
                               services.AddSingleton<UserSession>();
                               services.AddAutoMapper(typeof(MapperProfiles));
                           }).Build();
            await host.StartAsync();

            var services = host.Services;
            IHostApplicationLifetime lifetime = services.GetRequiredService<IHostApplicationLifetime>();

            using (IServiceScope scope = host.Services.CreateScope())
            {
                var login = scope.ServiceProvider.GetRequiredService<Login>();
                Application.Run(login);
            }

            lifetime.StopApplication();
            await host.WaitForShutdownAsync();
        }
    }
}