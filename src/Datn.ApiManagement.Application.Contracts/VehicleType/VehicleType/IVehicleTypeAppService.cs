using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IVehicleTypeAppService : ICrudAppService<
            VehicleTypeResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleTypeRequest,
            VehicleTypeRequest>
    {
    }
}
