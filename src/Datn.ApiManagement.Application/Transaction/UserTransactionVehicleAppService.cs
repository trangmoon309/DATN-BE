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
        private readonly IUserTransactionRepository _transactionRepository;

        public UserTransactionVehicleAppService(IUserTransactionVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IUserRepository userRepository, 
            IUserTransactionRepository transactionRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _userRepository = userRepository;
            _transactionRepository = transactionRepository;
        }

        public async Task<PagedResultDto<UserTransactionVehicleResponse>> GetByConditionPagedListAsync(SearchUserTransactionVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var transactions = await _transactionRepository.GetListAsync();
                var users = await _asyncQueryableExecuter.ToListAsync(_userRepository.SearchKeyWord(request.KeyWord));
                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);

                query = query.OrderByDescending(x => x.CreationTime);

                if (request.UserId.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.UserId == request.UserId.Value);
                }

                if (request.CostStatus.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.CostStatus == request.CostStatus.Value);
                }

                if (request.RentalStatus.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.RentalStatus == request.RentalStatus.Value);
                }

                if (request.ReceiveDate.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.ReceivedVehicleDate.Date == request.ReceiveDate.Value.Date);
                }

                if (request.RetunrnDate.HasValue)
                {
                    query = query.Where(x => x.UserTransaction.ReturnedVehicleDate.HasValue && x.UserTransaction.ReturnedVehicleDate.Value.Date == request.RetunrnDate.Value.Date);
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
                    x.Transaction = ObjectMapper.Map<UserTransaction, UserTransactionResponse>(transactions.FirstOrDefault(y => y.Id == x.UserTransactionId));
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
