using Volo.Abp.Bundling;

namespace DATN_API.Blazor.Host;

public class DATN_APIBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
