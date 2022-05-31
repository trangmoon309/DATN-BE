using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IUserTransactionAppService : ICrudAppService<
            UserTransactionResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserTransactionRequest,
            UserTransactionRequest>
    {
        Task<PagedResultDto<UserTransactionResponse>> GetByUserPagedListAsync(Guid? userId, PagedAndSortedResultRequestDto pageRequest);
    }
}
