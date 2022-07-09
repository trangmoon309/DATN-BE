using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Helpers;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using Microsoft.AspNetCore.Http;
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
    public class VehicleAppService : CrudAppService<
            Vehicle,
            VehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleRequest,
            UpdateVehicleRequest>, IVehicleAppService
    {
        private readonly IVehicleRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        private readonly IVehicleImageAppService _vehiceImageAppService;
        private readonly IVehicleImageRepository _vehiceImageRepository;
        private readonly IUserTransactionRepository _transactionRepository;
        public VehicleAppService(IVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IVehicleImageAppService vehiceImageAppService,
            IVehicleImageRepository vehiceImageRepository, 
            IUserTransactionRepository transactionRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _vehiceImageAppService = vehiceImageAppService;
            _vehiceImageRepository = vehiceImageRepository;
            _transactionRepository = transactionRepository;
        }

        public async Task<PagedResultDto<VehicleResponse>> GetListByCondition(SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var transactionList = await _asyncQueryableExecuter.ToListAsync(_transactionRepository.GetList());
                var usingVehicleList = transactionList.Where(x => x.RentalStatus < Enums.Enums.RentalStatus.RETURNED );

                if (request.SearchDate.HasValue)
                {
                    usingVehicleList = usingVehicleList.Where(x => x.ReceivedVehicleDate.Date <= request.SearchDate.Value.Date &&
                                                                   x.ReturnedVehicleDate.Value.Date >= request.SearchDate.Value.Date);
                }

                var runOutVehicles = usingVehicleList.SelectMany(x => x.UserTransactionVehicles).GroupBy(x => x.VehicleId, (vehicleId, list) => new
                UserTransactionVehicleGroupByVehicle
                {
                    VehicleId = vehicleId,
                    UserTransactionVehicles = list.ToList(),
                    IsVehicleRanOutOfAmount = list.Sum(x => x.Amount) >= list.FirstOrDefault().Vehicle.Amount,
                    UsingAmount = list.Sum(x => x.Amount)
                }).ToList();

                var runOutVehicleIds = runOutVehicles.Where(y => y.IsVehicleRanOutOfAmount == true).Select(y => y.VehicleId);

                query = query.Where(x => !runOutVehicleIds.Contains(x.Id)).OrderByDescending(x => x.CreationTime);

                if (!request.KeyWord.IsNullOrEmpty()) query = _repository.SearchKeyWord(query, request.KeyWord);

                if (request.VehicleTypeId.HasValue) query = query.Where(x => x.VehicleTypeId == request.VehicleTypeId.Value);

                if (request.VehicleLineId.HasValue) query = query.Where(x => x.VehicleLineId == request.VehicleLineId.Value);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<Vehicle>, List<VehicleResponse>>(toList);
                items.ForEach(x =>
                {
                    var runOut = runOutVehicles.FirstOrDefault(y => y.VehicleId == x.Id);
                    if (runOut != null)
                    {
                        x.RemainAmount = x.Amount - runOut.UsingAmount;
                    }
                    else
                    {
                        x.RemainAmount = x.Amount;
                    }
                });
                var total = query.Count();

                return new PagedResultDto<VehicleResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<VehicleResponse> CreatesAsync(VehicleRequest input)
        {
            try
            {

                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var entity = base.MapToEntity(input);

                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<Vehicle>(toList, "V", 5);

                foreach (var item in entity.VehicleProperties)
                {
                    EntityHelper.TrySetId(item, GuidGenerator.Create);
                    item.VehicleId = entity.Id;
                }

                await _repository.InsertAsync(entity);
                var result = ObjectMapper.Map<Vehicle, VehicleResponse>(entity);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<VehicleImageResponse>> CreatVehicleImagesAsync(Guid vehicleId, List<IFormFile> images)
        {
            try
            {
                var vehicelImages = await _vehiceImageAppService.SaveVehicleImageAsync(images);
                var entities = new List<VehicleImage>();
                foreach (var item in vehicelImages)
                {
                    var x = new VehicleImage()
                    {
                        VehicleId = vehicleId,
                        FileInformationId = item.Id
                    };
                    EntityHelper.TrySetId(x, GuidGenerator.Create);
                    entities.Add(x);
                }

                await _vehiceImageRepository.CreateMultiple(entities);

                return ObjectMapper.Map<List<VehicleImage>, List<VehicleImageResponse>>(entities);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<VehicleResponse> UpdatesAsync(Guid id, UpdateVehicleRequest input)
        {
            var entity = await _asyncQueryableExecuter.FirstOrDefaultAsync(_repository.GetById(id));
            MapToEntity(input, entity);

            entity.VehicleProperties.ForEach(x =>
            {
                x.VehicleId = id;
                if (x.Id == null || x.Id == Guid.Empty) EntityHelper.TrySetId(x, GuidGenerator.Create);
            });

            entity.VehicleImages.Clear();

            await _repository.UpdateMasterAsync(entity);

            return ObjectMapper.Map<Vehicle, VehicleResponse>(entity);
        }

        public override async Task<VehicleResponse> GetAsync(Guid id)
        {
            var query = _repository.GetById(id);
            var item = await _asyncQueryableExecuter.FirstOrDefaultAsync(query);
            return ObjectMapper.Map<Vehicle, VehicleResponse>(item);
        }

        public async Task<VehicleResponse> GetVehicleByDateAsync(Guid id, DateTime date)
        {
            var query = _repository.GetById(id);
            var item = await _asyncQueryableExecuter.FirstOrDefaultAsync(query);
            var transactionList = await _asyncQueryableExecuter.ToListAsync(_transactionRepository.GetList());
            var usingVehicleList = transactionList.Where(x => x.RentalStatus < Enums.Enums.RentalStatus.RETURNED).ToList();

            usingVehicleList = usingVehicleList.Where(x => x.ReceivedVehicleDate.Date <= date.Date &&
                                                               x.ReturnedVehicleDate.Value.Date >= date.Date).ToList();

            var runOutVehicles = usingVehicleList.SelectMany(x => x.UserTransactionVehicles).Where(x => x.VehicleId == id).ToList();
            var usingAmount = runOutVehicles.Sum(x => x.Amount);

            var result = ObjectMapper.Map<Vehicle, VehicleResponse>(item);
            result.RemainAmount = result.Amount - usingAmount;

            return result;
        }
    }
}
