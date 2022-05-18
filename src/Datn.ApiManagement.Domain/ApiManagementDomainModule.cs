using Volo.Abp.Domain;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(ApiManagementDomainSharedModule))]
public class ApiManagementDomainModule : AbpModule
{

}
