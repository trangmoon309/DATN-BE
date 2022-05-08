using Volo.Abp.Modularity;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(ApiManagementApplicationModule),
    typeof(ApiManagementDomainTestModule)
    )]
public class ApiManagementApplicationTestModule : AbpModule
{

}
