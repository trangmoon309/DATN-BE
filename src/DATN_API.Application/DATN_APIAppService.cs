using DATN_API.Localization;
using Volo.Abp.Application.Services;

namespace DATN_API;

public abstract class DATN_APIAppService : ApplicationService
{
    protected DATN_APIAppService()
    {
        LocalizationResource = typeof(DATN_APIResource);
        ObjectMapperContext = typeof(DATN_APIApplicationModule);
    }
}
