using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace DATN_API;

[DependsOn(
    typeof(DATN_APIApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class DATN_APIHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(DATN_APIApplicationContractsModule).Assembly,
            DATN_APIRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<DATN_APIHttpApiClientModule>();
        });

    }
}
