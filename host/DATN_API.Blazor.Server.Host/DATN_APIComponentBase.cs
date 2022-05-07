using DATN_API.Localization;
using Volo.Abp.AspNetCore.Components;

namespace DATN_API.Blazor.Server.Host;

public abstract class DATN_APIComponentBase : AbpComponentBase
{
    protected DATN_APIComponentBase()
    {
        LocalizationResource = typeof(DATN_APIResource);
    }
}
