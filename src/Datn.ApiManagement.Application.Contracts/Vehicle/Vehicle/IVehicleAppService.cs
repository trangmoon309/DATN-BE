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
        Task<PagedResultDto<VehicleResponse>> GetPagedListAsync(SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest);

        Task<VehicleResponse> CreateWithImagesAsync(VehicleRequest input, List<IFormFile> images);

        Task<VehicleResponse> UpdateWithImagesAsync(Guid id, UpdateVehicleRequest input, List<IFormFile> images);
    }
}
