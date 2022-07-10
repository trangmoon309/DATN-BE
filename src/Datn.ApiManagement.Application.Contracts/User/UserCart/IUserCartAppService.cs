using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IUserCartAppService : ICrudAppService<
            UserCartResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserCartRequest,
            UpdateUserCartRequest>
    {
        Task<PagedResultDto<UserCartResponse>> GetByUserPagedListAsync(Guid userId, DateTime? rentDate, PagedAndSortedResultRequestDto pageRequest);

        Task<List<UserCartResponse>> UpdateMultipleByUserId(Guid userId, List<UpdateUserCartRequest> requests);
    }
}
