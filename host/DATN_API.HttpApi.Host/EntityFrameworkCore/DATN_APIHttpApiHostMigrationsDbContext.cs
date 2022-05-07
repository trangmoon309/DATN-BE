using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace DATN_API.EntityFrameworkCore;

public class DATN_APIHttpApiHostMigrationsDbContext : AbpDbContext<DATN_APIHttpApiHostMigrationsDbContext>
{
    public DATN_APIHttpApiHostMigrationsDbContext(DbContextOptions<DATN_APIHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureDATN_API();
    }
}
