using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public interface IApiManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
