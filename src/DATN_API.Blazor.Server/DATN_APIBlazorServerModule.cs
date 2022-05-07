using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace DATN_API.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(DATN_APIBlazorModule)
    )]
public class DATN_APIBlazorServerModule : AbpModule
{

}
