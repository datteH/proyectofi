using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Proyecto.ETPS4.Grupo13.Repository;
using Proyecto.ETPS4.Grupo13.Entities.Common;

namespace Proyecto.ETPS4.Grupo13.WebApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json")
                        .Build();
            var assemblyName = typeof(RepositoryContext).Assembly.GetName().Name;
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                            .UseSqlServer(config.GetConnectionString(Constants.SqlConnection), b => b.MigrationsAssembly("Proyecto.ETPS4.Grupo13.WebApi"));

            return new RepositoryContext(builder.Options);
        }
    }
}
