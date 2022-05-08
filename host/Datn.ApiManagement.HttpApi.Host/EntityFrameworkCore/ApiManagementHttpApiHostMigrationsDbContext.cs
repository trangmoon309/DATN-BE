using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore;

public class ApiManagementHttpApiHostMigrationsDbContext : AbpDbContext<ApiManagementHttpApiHostMigrationsDbContext>
{
    public ApiManagementHttpApiHostMigrationsDbContext(DbContextOptions<ApiManagementHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureApiManagement();
    }
}
