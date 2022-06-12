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
            UpdateUserCartRequest>, IUserCartAppService
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

        public async Task<List<UserCartResponse>> UpdateMultipleByUserId(Guid userId, List<UpdateUserCartRequest> requests)
        {
            try
            {
                var query = _repository.GetListByUserId(userId);

                query = query.OrderByDescending(x => x.CreationTime);

                var updatedItems = new List<UserCart>();
                var deletedItems = new List<UserCart>();

                foreach(var item in query)
                {
                    var request = requests.Find(x => x.Id == item.Id);
                    if(request != null)
                    {
                        item.Quantity = request.Quantity;
                        updatedItems.Add(item);
                    }
                    else
                    {
                        deletedItems.Add(item);
                    }
                }

                if(updatedItems.Any()) await _repository.UpdateMultiple(updatedItems);
                if (deletedItems.Any()) await _repository.DeleteMultiple(deletedItems);

                return ObjectMapper.Map<List<UserCart>, List<UserCartResponse>>(updatedItems);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
