using Volo.Abp.Modularity;

namespace DATN_API;

[DependsOn(
    typeof(DATN_APIApplicationModule),
    typeof(DATN_APIDomainTestModule)
    )]
public class DATN_APIApplicationTestModule : AbpModule
{

}
