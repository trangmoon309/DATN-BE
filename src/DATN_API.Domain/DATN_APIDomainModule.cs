using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace DATN_API;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(DATN_APIDomainSharedModule)
)]
public class DATN_APIDomainModule : AbpModule
{

}
