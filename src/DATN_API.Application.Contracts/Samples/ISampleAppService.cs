using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace DATN_API.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
