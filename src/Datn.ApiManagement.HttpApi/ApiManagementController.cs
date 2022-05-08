using Datn.ApiManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Datn.ApiManagement;

public abstract class ApiManagementController : AbpControllerBase
{
    protected ApiManagementController()
    {
        LocalizationResource = typeof(ApiManagementResource);
    }
}
