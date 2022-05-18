using Datn.ApiManagement.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;

namespace Datn.ApiManagement;

[RemoteService]
//[Authorize]
//[ErpAuthorizationFilter]
[IgnoreAntiforgeryToken]
public abstract class ApiManagementController : AbpControllerBase
{
    protected ApiManagementController()
    {
        LocalizationResource = typeof(ApiManagementResource);
    }
}
