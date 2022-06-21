using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Mock
{
    public interface IMockAppService : IApplicationService
    {
        Task<List<VehicleTypeResponse>> MockVehicleTypes();

        Task<List<VehicleLineResponse>> MockVehicleLines();

        Task<List<VehicleResponse>> MockVehicles();
    }
}
