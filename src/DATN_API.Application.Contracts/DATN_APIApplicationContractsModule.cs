using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace DATN_API;

[DependsOn(
    typeof(DATN_APIDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class DATN_APIApplicationContractsModule : AbpModule
{

}
