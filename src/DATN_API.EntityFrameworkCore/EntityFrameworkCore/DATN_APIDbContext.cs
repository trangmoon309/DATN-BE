using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DATN_API.EntityFrameworkCore;

[ConnectionStringName(DATN_APIDbProperties.ConnectionStringName)]
public class DATN_APIDbContext : AbpDbContext<DATN_APIDbContext>, IDATN_APIDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DATN_APIDbContext(DbContextOptions<DATN_APIDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureDATN_API();
    }
}
