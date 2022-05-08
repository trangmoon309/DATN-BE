using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ApiManagementHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class ApiManagementConsoleApiClientModule : AbpModule
{

}
