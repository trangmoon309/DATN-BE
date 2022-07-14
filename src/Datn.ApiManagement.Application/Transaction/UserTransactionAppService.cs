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
            UpdateUserTransactionRequest>, IUserTransactionAppService
    {
        private readonly IUserTransactionRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        private readonly IUserRepository _userRepository;
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IUserCartRepository _userCartRepository;

        public UserTransactionAppService(IUserTransactionRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IUserRepository userRepository,
            IVehicleRepository vehicleRepository, 
            IUserCartRepository userCartRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _userRepository = userRepository;
            _vehicleRepository = vehicleRepository;
            _userCartRepository = userCartRepository;
        }

        public async Task<PagedResultDto<UserTransactionResponse>> GetByUserPagedListAsync(SearchUserTransactionRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var users = await _asyncQueryableExecuter.ToListAsync(_userRepository.SearchKeyWord(request.KeyWord));
                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);

                query = query.OrderByDescending(x => x.CreationTime);

                if (request.UserId.HasValue)
                {
                    query = query.Where(x => x.UserId == request.UserId.Value);
                }

                if (request.SearchDate.HasValue)
                {
                    query = query.Where(x => x.CreationTime.Date == request.SearchDate.Value.Date );
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

        public override async Task<UserTransactionResponse> CreateAsync(UserTransactionRequest input)
        {
            try
            {
                var query = _repository.GetList();
                var vehicleList = await _vehicleRepository.GetListAsync();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var usingVehicleList = toList
                    .Where(x => (x.RentalStatus == Enums.Enums.RentalStatus.USING) || (x.RentalStatus == Enums.Enums.RentalStatus.WAITING))
                    .SelectMany(x => x.UserTransactionVehicles).ToList();

                var entity = base.MapToEntity(input);
                double depositCosted = 0;
                double totalCost = 0;

                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<UserTransaction>(toList, "TS", 4);

                foreach (var item in entity.UserTransactionVehicles)
                {
                    EntityHelper.TrySetId(item, GuidGenerator.Create);
                    item.UserTransactionId = entity.Id;
                    var vehicle = vehicleList.FirstOrDefault(x => x.Id == item.VehicleId);

                    if (vehicle != null)
                    {
                        var usingAmount = usingVehicleList.Where(x => x.VehicleId == vehicle.Id).Sum(x => x.Amount);
                        if (item.Amount > (vehicle.Amount - usingAmount))
                        {
                            throw new UserFriendlyException("Create Faild: The Vehicle " + vehicle.Name + " has not enough amount!");
                        }

                        depositCosted += vehicle.DepositPrice;
                        totalCost += vehicle.RentalPrice;
                    }
                }

                entity.DepositCosted = depositCosted* entity.TotalDays;
                entity.TotalCost = totalCost * entity.TotalDays;
                entity.ReturnedVehicleDate = entity.ReceivedVehicleDate.AddDays(entity.TotalDays);

                await _repository.InsertAsync(entity);
                await _userCartRepository.DeleteMultipleByUserId(entity.UserId);
                var result = ObjectMapper.Map<UserTransaction, UserTransactionResponse>(entity);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override async Task<UserTransactionResponse> UpdateAsync(Guid id, UpdateUserTransactionRequest input)
        {
            try
            {
                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var users = await _asyncQueryableExecuter.ToListAsync(_userRepository.GetList().Result);
                var vehicleList = await _vehicleRepository.GetListAsync();
                var usingVehicleList = toList
                    .Where(x => (x.RentalStatus == Enums.Enums.RentalStatus.USING) || (x.RentalStatus == Enums.Enums.RentalStatus.WAITING))
                    .SelectMany(x => x.UserTransactionVehicles).ToList();

                var userReponses = ObjectMapper.Map<List<User>, List<UserResponse>>(users);
                var entity = toList.FirstOrDefault(x => x.Id == id);

                MapToEntity(input, entity);

                entity.UserTransactionVehicles.ForEach(x =>
                {
                    var vehicle = vehicleList.FirstOrDefault(y => y.Id == x.VehicleId);
                    var usingAmount = usingVehicleList.Where(y => y.VehicleId == vehicle.Id).Sum(y => y.Amount);
                    if (x.Amount > (vehicle.Amount - usingAmount))
                    {
                        throw new UserFriendlyException("Update Faild: The Vehicle " + vehicle.Name + " has not enough amount!");
                    }
                });

                var result = await _repository.UpdateMasterAsync(entity);

                var response = ObjectMapper.Map<UserTransaction, UserTransactionResponse>(result);
                response.User = userReponses.Find(y => y.Id == result.UserId);

                return response;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<SummaryInfors> SummaryInfors()
        {
            try
            {
                var result = new SummaryInfors();
                var transactions = await _repository.GetListAsync();

                var currentTransaction = transactions.Where(x => x.CostStatus == Enums.Enums.CostStatus.PAYED
                && x.PayingDate.HasValue
                && x.PayingDate.Value.Date.Month == DateTime.Now.Month);

                var previousTransactione = transactions.Where(x => x.CostStatus == Enums.Enums.CostStatus.PAYED
                && x.PayingDate.HasValue
                && x.PayingDate.Value.Date.Month == (DateTime.Now.Month - 1));

                result.AverageIncome = currentTransaction.Count() > 0 ? currentTransaction.Sum(x => x.TotalCost) / currentTransaction.Count() : 0;
                result.AverageIncomeDifference = previousTransactione.Count() > 0 ? result.AverageIncome - (previousTransactione.Sum(x => x.TotalCost) / previousTransactione.Count()) : 0;

                result.QualityReview = currentTransaction.Count() >0 ? currentTransaction.Sum(x => x.ReviewServiceQuality) / currentTransaction.Count() : 0;
                result.QualityReviewDifference = previousTransactione.Count() > 0 ? result.AverageIncome - (previousTransactione.Sum(x => x.ReviewServiceQuality) / previousTransactione.Count()) : 0;

                var currentCancelTransaction = transactions.Where(x => x.RentalStatus == Enums.Enums.RentalStatus.CANCEL
                && x.ReceivedVehicleDate.Date.Month == DateTime.Now.Month);

                var previousCancelTransaction = transactions.Where(x => x.RentalStatus == Enums.Enums.RentalStatus.CANCEL
                && x.ReceivedVehicleDate.Date.Month == DateTime.Now.Month - 1);

                result.TransactionCancel = currentCancelTransaction.Count();
                result.TransactionCancelDifference = previousCancelTransaction.Count();

                result.SuccessTransactions = ObjectMapper.Map<List<UserTransaction>, List<UserTransactionResponse>>(transactions.Where(x => x.RentalStatus == Enums.Enums.RentalStatus.RETURNED).ToList());
                result.CanceledTransactions = ObjectMapper.Map<List<UserTransaction>, List<UserTransactionResponse>>(transactions.Where(x => x.RentalStatus == Enums.Enums.RentalStatus.CANCEL).ToList());
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}