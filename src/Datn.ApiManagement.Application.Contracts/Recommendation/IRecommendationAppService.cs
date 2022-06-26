using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IRecommendationAppService : IApplicationService
    {
        string GetItemRecommended(Guid userId);

        string TrackChange();
    }
}
