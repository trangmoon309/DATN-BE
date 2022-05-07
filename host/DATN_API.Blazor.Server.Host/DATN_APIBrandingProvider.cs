using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace DATN_API.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class DATN_APIBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "DATN_API";
}
