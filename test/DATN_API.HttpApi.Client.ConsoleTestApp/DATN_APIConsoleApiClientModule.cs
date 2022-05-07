using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace DATN_API;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(DATN_APIHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class DATN_APIConsoleApiClientModule : AbpModule
{

}
