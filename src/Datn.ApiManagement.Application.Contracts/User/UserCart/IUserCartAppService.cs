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
            UserCartRequest>
    {
        Task<PagedResultDto<UserCartResponse>> GetByUserPagedListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest);
    }
}
