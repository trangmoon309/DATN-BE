using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IVehicleTypeAppService : ICrudAppService<
            VehicleTypeResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleTypeRequest,
            UpdateVehicleTypeRequest>
    {
        Task<PagedResultDto<VehicleTypeResponse>> GetPagedListAsync(string keyWord, PagedAndSortedResultRequestDto pageRequest);
    }
}
