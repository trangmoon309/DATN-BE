using DATN_API.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace DATN_API;

public abstract class DATN_APIController : AbpControllerBase
{
    protected DATN_APIController()
    {
        LocalizationResource = typeof(DATN_APIResource);
    }
}
