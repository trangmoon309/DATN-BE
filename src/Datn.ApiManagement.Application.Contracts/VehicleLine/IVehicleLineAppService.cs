using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IVehicleLineAppService : ICrudAppService<
            VehicleLineResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleLineRequest,
            VehicleLineRequest>
    {
        Task<PagedResultDto<VehicleLineResponse>> GetPagedListAsync(string keyWord, PagedAndSortedResultRequestDto pageRequest);
    }
}
