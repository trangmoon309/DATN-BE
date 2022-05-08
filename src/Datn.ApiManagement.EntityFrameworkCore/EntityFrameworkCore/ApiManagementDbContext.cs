using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public class ApiManagementDbContext : AbpDbContext<ApiManagementDbContext>, IApiManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public ApiManagementDbContext(DbContextOptions<ApiManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureApiManagement();
    }
}
