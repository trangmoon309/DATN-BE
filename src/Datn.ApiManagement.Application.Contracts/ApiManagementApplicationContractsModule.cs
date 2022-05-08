using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(ApiManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ApiManagementApplicationContractsModule : AbpModule
{

}
