using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Helpers;
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
    public class VehicleTypeAppService : CrudAppService<
            VehicleType,
            VehicleTypeResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleTypeRequest,
            UpdateVehicleTypeRequest>, IVehicleTypeAppService
    {
        private readonly IVehicleTypeRepository _repository;
        private readonly IVehiclePropertyRepository _propertyRepository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleTypeAppService(IVehicleTypeRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter,
            IVehiclePropertyRepository propertyRepository, 
            IVehicleRepository vehicleRepository) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _propertyRepository = propertyRepository;
            _vehicleRepository = vehicleRepository;
        }

        public async Task<PagedResultDto<VehicleTypeResponse>> GetPagedListAsync(string keyWord, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                if (keyWord != null) query = _repository.SearchKeyWord(query, keyWord);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<VehicleType>, List<VehicleTypeResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<VehicleTypeResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override async Task<VehicleTypeResponse> CreateAsync(VehicleTypeRequest input)
        {
            try
            {
                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var entity = base.MapToEntity(input);

                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<VehicleType>(toList, "VT", 4);

                foreach (var item in entity.VehicleTypeDetails)
                {
                    EntityHelper.TrySetId(item, GuidGenerator.Create);
                    item.VehicleTypeId = entity.Id;
                }

                await _repository.InsertAsync(entity);
                var result = ObjectMapper.Map<VehicleType, VehicleTypeResponse>(entity);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override async Task DeleteAsync(Guid id)
        {
            var entity = await _asyncQueryableExecuter.FirstOrDefaultAsync(_repository.GetById(id));
            var vehicles = await _asyncQueryableExecuter.ToListAsync(_vehicleRepository.GetList());
            var props = vehicles.SelectMany(x => x.VehicleProperties).ToList();

            if (vehicles.FirstOrDefault(x => x.VehicleTypeId == id) != null)
            {
                throw new UserFriendlyException("Deleted Faild: This Vehicle Type is being used!");
            }

            if (entity == null)
            {
                if(entity.VehicleTypeDetails.Any())
                {
                    foreach (var item in entity.VehicleTypeDetails)
                    {
                        if(props.Any(x => x.VehicleTypeDetailId == item.Id && !x.Vehicle.IsDeleted))
                        {
                            throw new Exception("Fail to delete: Property: " + item.Name + " is currently used.");
                        }
                    }
                }
            }
            await base.DeleteAsync(id);
        }

        public override async Task<VehicleTypeResponse> UpdateAsync(Guid id, UpdateVehicleTypeRequest input)
        {
            try
            {
                var entity = await _asyncQueryableExecuter.FirstOrDefaultAsync(_repository.GetById(id));
                var vehicles = await _asyncQueryableExecuter.ToListAsync(_vehicleRepository.GetList());

                MapToEntity(input, entity);

                entity.VehicleTypeDetails.ForEach(x =>
                {
                    x.VehicleTypeId = id;
                    if (x.Id == null || x.Id == Guid.Empty) EntityHelper.TrySetId(x, GuidGenerator.Create);
                });

                await _repository.UpdateMasterAsync(entity, vehicles);

                return ObjectMapper.Map<VehicleType, VehicleTypeResponse>(entity);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
