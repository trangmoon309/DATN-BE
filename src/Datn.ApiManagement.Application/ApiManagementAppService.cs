using Datn.ApiManagement.Localization;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement;

public abstract class ApiManagementAppService : ApplicationService
{
    protected ApiManagementAppService()
    {
        LocalizationResource = typeof(ApiManagementResource);
        ObjectMapperContext = typeof(ApiManagementApplicationModule);
    }
}
