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
    public class UserCartAppService : CrudAppService<
            UserCart,
            UserCartResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserCartRequest,
            UserCartRequest>, IUserCartAppService
    {
        private readonly IUserCartRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public UserCartAppService(IUserCartRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<PagedResultDto<UserCartResponse>> GetByUserPagedListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                query = query.Where(x => x.UserId == userId);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<UserCart>, List<UserCartResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<UserCartResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
