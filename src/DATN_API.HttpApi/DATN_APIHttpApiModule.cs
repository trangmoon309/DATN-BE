using Localization.Resources.AbpUi;
using DATN_API.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace DATN_API;

[DependsOn(
    typeof(DATN_APIApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class DATN_APIHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(DATN_APIHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<DATN_APIResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
