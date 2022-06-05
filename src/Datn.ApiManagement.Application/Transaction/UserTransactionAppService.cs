using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Helpers;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using PBL6.Hreo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Entities;
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
        private readonly IUserRepository _userRepository;
        private readonly IVehicleRepository _vehicleRepository;

        public UserTransactionAppService(IUserTransactionRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IUserRepository userRepository, 
            IVehicleRepository vehicleRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _userRepository = userRepository;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<PagedResultDto<UserTransactionResponse>> GetByUserPagedListAsync(SearchUserTransactionRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var users = await _asyncQueryableExecuter.ToListAsync( _userRepository.SearchKeyWord(request.KeyWord));
                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);

                query = query.OrderByDescending(x => x.CreationTime);

                if (request.UserId.HasValue)
                {
                    query = query.Where(x => x.UserId == request.UserId.Value);
                }

                if (!request.KeyWord.IsNullOrEmpty())
                {
                    query = query.Where(x => userReponses.Select(y => y.Id).Contains(x.UserId));
                }

                if (request.CostStatus.HasValue)
                {
                    query = query.Where(x => x.CostStatus == request.CostStatus.Value);
                }

                if (request.RentalStatus.HasValue)
                {
                    query = query.Where(x => x.RentalStatus == request.RentalStatus.Value);
                }

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                toList = toList.OrderByDescending(x => x.CreationTime).ToList();

                var items = ObjectMapper.Map<List<UserTransaction>, List<UserTransactionResponse>>(toList);
                var total = query.Count();

                items.ForEach(x =>
                {
                    x.User = userReponses.Find(y => y.Id == x.UserId);
                });

                return new PagedResultDto<UserTransactionResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override async Task<UserTransactionResponse> GetAsync(Guid id)
        {
            try
            {
                var users = await _asyncQueryableExecuter.ToListAsync(_userRepository.GetList().Result);
                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);
                var query = _repository.GetById(id);
                var item = await _asyncQueryableExecuter.FirstOrDefaultAsync(query, x => x.Id == id);

                var result = ObjectMapper.Map<UserTransaction, UserTransactionResponse>(item);

                result.User = userReponses.Find(y => y.Id == result.UserId);
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserTransactionResponse> CreatesAsync(UserTransactionRequest input)
        {
            try
            {
                var query = _repository.GetList();
                var vehicleList = _vehicleRepository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var entity = base.MapToEntity(input);
                double depositCosted = 0;

                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<UserTransaction>(toList, "TS", 4);

                foreach (var item in entity.UserTransactionVehicles)
                {
                    EntityHelper.TrySetId(item, GuidGenerator.Create);
                    item.VehicleId = entity.Id;
                    var vehicle = vehicleList.FirstOrDefault(x => x.Id == item.VehicleId);
                    if (vehicle != null) depositCosted += vehicle.DepositPrice;
                }

                entity.DepositCosted = depositCosted;
                await _repository.InsertAsync(entity);
                var result = ObjectMapper.Map<UserTransaction, UserTransactionResponse>(entity);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}