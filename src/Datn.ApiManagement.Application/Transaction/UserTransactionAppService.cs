using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace Datn.ApiManagement.Services
{
    [RemoteService(IsMetadataEnabled = false)]
    public class UserTransactionAppService : CrudAppService<
            UserTransaction,
            UserTransactionResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserTransactionRequest,
            UserTransactionRequest>, IUserTransactionAppService
    {
        private readonly IUserTransactionRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public UserTransactionAppService(IUserTransactionRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<PagedResultDto<UserTransactionResponse>> GetByUserPagedListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                query = query.Where(x => x.UserId == userId);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<UserTransaction>, List<UserTransactionResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<UserTransactionResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}