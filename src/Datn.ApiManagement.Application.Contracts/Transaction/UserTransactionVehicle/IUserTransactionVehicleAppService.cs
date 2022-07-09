using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IUserTransactionVehicleAppService : ICrudAppService<
            UserTransactionVehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserTransactionVehicleRequest,
            UserTransactionVehicleRequest>
    {
        Task<PagedResultDto<UserTransactionVehicleResponse>> GetByConditionPagedListAsync(SearchUserTransactionVehicleRequest request, PagedAndSortedResultRequestDto pageRequest);
    }
}
