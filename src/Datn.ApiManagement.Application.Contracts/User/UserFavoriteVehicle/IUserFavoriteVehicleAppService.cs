using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IUserFavoriteVehicleAppService : ICrudAppService<
            UserFavoriteVehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserFavoriteVehicleRequest,
            UserFavoriteVehicleRequest>
    {
    }
}
