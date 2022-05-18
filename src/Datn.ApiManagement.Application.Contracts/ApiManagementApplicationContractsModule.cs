using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;
using Volo.Abp.Identity;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(ApiManagementDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class ApiManagementApplicationContractsModule : AbpModule
{

}
