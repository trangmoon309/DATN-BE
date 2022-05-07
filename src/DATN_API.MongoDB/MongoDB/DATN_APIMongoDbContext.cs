using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace DATN_API.MongoDB;

[ConnectionStringName(DATN_APIDbProperties.ConnectionStringName)]
public class DATN_APIMongoDbContext : AbpMongoDbContext, IDATN_APIMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureDATN_API();
    }
}
