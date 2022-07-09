using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IVehicleAppService : ICrudAppService<
            VehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleRequest,
            UpdateVehicleRequest>
    {
        Task<PagedResultDto<VehicleResponse>> GetListByCondition(SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest);

        Task<VehicleResponse> CreatesAsync(VehicleRequest input);

        Task<List<VehicleImageResponse>> CreatVehicleImagesAsync(Guid vehicleId, List<IFormFile> images);

        Task<VehicleResponse> UpdatesAsync(Guid id, UpdateVehicleRequest input);

        Task<VehicleResponse> GetVehicleByDateAsync(Guid id, DateTime date);
    }
}
