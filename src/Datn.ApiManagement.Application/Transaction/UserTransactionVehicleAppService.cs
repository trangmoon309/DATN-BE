using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using Datn.ApiManagement.Services;
using PBL6.Hreo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Linq;

namespace Datn.ApiManagement.Transaction
{
    public class UserTransactionVehicleAppService : CrudAppService<
            UserTransactionVehicle,
            UserTransactionVehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserTransactionVehicleRequest,
            UserTransactionVehicleRequest>, IUserTransactionVehicleAppService
    {
        private readonly IUserTransactionVehicleRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        private readonly IUserRepository _userRepository;

        public UserTransactionVehicleAppService(IUserTransactionVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IUserRepository userRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _userRepository = userRepository;
        }

        public async Task<PagedResultDto<UserTransactionVehicleResponse>> GetByConditionPagedListAsync(SearchUserTransactionVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var users = await _asyncQueryableExecuter.ToListAsync(_userRepository.SearchKeyWord(request.KeyWord));
                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);

                query = query.OrderByDescending(x => x.CreationTime);

                if (request.UserId.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.UserId == request.UserId.Value);
                }

                if (request.SearchDate.HasValue)
                {
                    query = query.Where(x => (x.UserTransaction.ReceivedVehicleDate.Date <= request.SearchDate.Value.Date 
                                           && x.UserTransaction.ReturnedVehicleDate.Value.Date <= request.SearchDate.Value.Date));
                }

                query = query.OrderByDescending(x => x.UserTransaction.ReceivedVehicleDate.Date);
                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                toList = toList.OrderByDescending(x => x.CreationTime).ToList();

                var items = ObjectMapper.Map<List<UserTransactionVehicle>, List<UserTransactionVehicleResponse>>(toList);
                var total = query.Count();

                items.ForEach(x =>
                {
                    var tran = toList.Find(y => y.Id == x.Id);
                    x.User = userReponses.Find(y => y.Id == tran.UserTransaction.UserId);
                });

                return new PagedResultDto<UserTransactionVehicleResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
