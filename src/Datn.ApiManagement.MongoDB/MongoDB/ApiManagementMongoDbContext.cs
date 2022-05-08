using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Datn.ApiManagement.MongoDB;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public class ApiManagementMongoDbContext : AbpMongoDbContext, IApiManagementMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureApiManagement();
    }
}
