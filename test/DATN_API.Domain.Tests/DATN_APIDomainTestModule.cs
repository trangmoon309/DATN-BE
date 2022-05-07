using DATN_API.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace DATN_API;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(DATN_APIEntityFrameworkCoreTestModule)
    )]
public class DATN_APIDomainTestModule : AbpModule
{

}
