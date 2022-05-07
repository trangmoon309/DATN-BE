using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace DATN_API.EntityFrameworkCore;

[ConnectionStringName(DATN_APIDbProperties.ConnectionStringName)]
public interface IDATN_APIDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
