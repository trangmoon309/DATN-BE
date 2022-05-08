using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Datn.ApiManagement.MongoDB;

public static class ApiManagementMongoDbContextExtensions
{
    public static void ConfigureApiManagement(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
