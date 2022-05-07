using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DATN_API.EntityFrameworkCore;

public class DATN_APIHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<DATN_APIHttpApiHostMigrationsDbContext>
{
    public DATN_APIHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<DATN_APIHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("DATN_API"));

        return new DATN_APIHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
