using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace DATN_API.Blazor.WebAssembly;

[DependsOn(
    typeof(DATN_APIBlazorModule),
    typeof(DATN_APIHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class DATN_APIBlazorWebAssemblyModule : AbpModule
{

}
