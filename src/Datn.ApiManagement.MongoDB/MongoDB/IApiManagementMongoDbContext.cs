using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Datn.ApiManagement.MongoDB;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public interface IApiManagementMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
