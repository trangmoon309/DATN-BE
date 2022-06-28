using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IRecommendationAppService : IApplicationService
    {
        Task<PagedResultDto<VehicleResponse>> GetVehicleTypeDetailRecommended(Guid userId, SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest);

        string TrackChange();
    }
}
