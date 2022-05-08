using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(ApiManagementApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class ApiManagementHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(ApiManagementApplicationContractsModule).Assembly,
            ApiManagementRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<ApiManagementHttpApiClientModule>();
        });

    }
}
