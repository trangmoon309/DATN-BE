using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IRecommendationAppService : IApplicationService
    {
        Task<List<VehicleResponse>> GetVehicleTypeDetailRecommended(Guid userId);

        string TrackChange();
    }
}
