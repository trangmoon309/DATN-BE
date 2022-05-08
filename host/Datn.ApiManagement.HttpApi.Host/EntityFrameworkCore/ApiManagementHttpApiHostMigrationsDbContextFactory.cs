using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Datn.ApiManagement.EntityFrameworkCore;

public class ApiManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ApiManagementHttpApiHostMigrationsDbContext>
{
    public ApiManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ApiManagementHttpApiHostMigrationsDbContext>()
            .UseNpgsql(configuration.GetConnectionString("ApiManagement"));

        return new ApiManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
