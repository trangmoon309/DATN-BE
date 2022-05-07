using Volo.Abp;
using Volo.Abp.MongoDB;

namespace DATN_API.MongoDB;

public static class DATN_APIMongoDbContextExtensions
{
    public static void ConfigureDATN_API(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
