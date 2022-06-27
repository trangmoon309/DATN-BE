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
using Volo.Abp.Domain.Entities;
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
        private readonly IUserTransactionRepository _transactionRepository;
        private readonly IVehicleRepository _vehicleRepository;

        public UserCartAppService(IUserCartRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IUserTransactionRepository transactionRepository,
            IVehicleRepository vehicleRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _transactionRepository = transactionRepository;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<PagedResultDto<UserCartResponse>> GetByUserPagedListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var transactionList = await _asyncQueryableExecuter.ToListAsync(_transactionRepository.GetList());
                var usingVehicleList = transactionList
                .Where(x => (x.RentalStatus == Enums.Enums.RentalStatus.USING) || (x.RentalStatus == Enums.Enums.RentalStatus.WAITING))
                .SelectMany(x => x.UserTransactionVehicles).ToList();

                var runOutVehicles = usingVehicleList.GroupBy(x => x.VehicleId, (vehicleId, list) => new
                UserTransactionVehicleGroupByVehicle
                {
                    VehicleId = vehicleId,
                    UserTransactionVehicles = list.ToList(),
                    IsVehicleRanOutOfAmount = list.Sum(x => x.Amount) >= list.FirstOrDefault().Vehicle.Amount
                }).ToList().Select(x => x.VehicleId);

                query = query.OrderByDescending(x => x.CreationTime);

                query = query.Where(x => x.UserId == userId);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<UserCart>, List<UserCartResponse>>(toList);
                items.ForEach(x =>
                {
                    if (runOutVehicles.Contains(x.VehicleId)) x.IsRanOut = true;
                    else x.IsRanOut = false;
                });

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
                var transactionList = await _asyncQueryableExecuter.ToListAsync(_transactionRepository.GetList());
                var usingVehicleList = transactionList
                .Where(x => (x.RentalStatus == Enums.Enums.RentalStatus.USING) || (x.RentalStatus == Enums.Enums.RentalStatus.WAITING))
                .SelectMany(x => x.UserTransactionVehicles).ToList();
                var vehicleList = await _vehicleRepository.GetListAsync();

                query = query.OrderByDescending(x => x.CreationTime);

                var updatedItems = new List<UserCart>();
                var deletedItems = new List<UserCart>();

                foreach(var item in query)
                {
                    var request = requests.Find(x => x.Id == item.Id);
                    if(request != null)
                    {
                        var vehicle = vehicleList.FirstOrDefault(y => y.Id == item.VehicleId);
                        var usingAmount = usingVehicleList.Where(y => y.VehicleId == vehicle.Id).Sum(y => y.Amount);
                        if (item.Quantity > (vehicle.Amount - usingAmount))
                        {
                            throw new UserFriendlyException("Update Faild: The Vehicle " + vehicle.Name + " has not enough amount!");
                        }

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

        public override async Task<UserCartResponse> CreateAsync(UserCartRequest input)
        {
            try
            {
                var toList = await _repository.GetListAsync();
                var existedItem = toList.FirstOrDefault(x => !x.IsDeleted && x.UserId == input.UserId && x.VehicleId == input.VehicleId);
                if (existedItem != null)
                {
                    existedItem.Quantity += input.Quantity;
                    await _repository.UpdateAsync(existedItem);
                    return ObjectMapper.Map<UserCart, UserCartResponse>(existedItem);
                }
                else
                {
                    return await base.CreateAsync(input);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
