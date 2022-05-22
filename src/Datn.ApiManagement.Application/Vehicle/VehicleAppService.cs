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

        public VehicleAppService(IVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter, 
            IVehicleImageAppService vehiceImageAppService) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _vehiceImageAppService = vehiceImageAppService;
        }

        public async Task<PagedResultDto<VehicleResponse>> GetPagedListAsync(SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                if (request.KeyWord != null) query = _repository.SearchKeyWord(query, request.KeyWord);

                if(request.VehicleTypeId != null) query = query.Where(x => x.VehicleTypeId == request.VehicleTypeId);

                if (request.VehicleLineId != null) query = query.Where(x => x.VehicleLineId == request.VehicleLineId);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<Vehicle>, List<VehicleResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<VehicleResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public async Task<VehicleResponse> CreateWithImagesAsync(VehicleRequest input, List<IFormFile> images)
        {
            try
            {
                var vehicelImages = await _vehiceImageAppService.SaveVehicleImageAsync(images);

                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                var entity = base.MapToEntity(input);

                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<Vehicle>(toList, "V", 2);

                foreach (var item in entity.VehicleProperties)
                {
                    EntityHelper.TrySetId(item, GuidGenerator.Create);
                    item.VehicleId = entity.Id;
                }

                foreach(var item in vehicelImages)
                {
                    var x = new VehicleImage()
                    {
                        VehicleId = entity.Id,
                        FileInformationId = item.Id
                    };
                    EntityHelper.TrySetId(x, GuidGenerator.Create);

                    entity.VehicleImages.Add(x);
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

        public async Task<VehicleResponse> UpdateWithImagesAsync(Guid id, UpdateVehicleRequest input, List<IFormFile> images)
        {
            var entity = await _asyncQueryableExecuter.FirstOrDefaultAsync(_repository.GetById(id));
            MapToEntity(input, entity);

            entity.VehicleProperties.ForEach(x =>
            {
                x.VehicleId = id;
                if (x.Id == null) EntityHelper.TrySetId(x, GuidGenerator.Create);
            });

            if (images != null && images.Count > 0)
            {
                var vehicelImages = await _vehiceImageAppService.SaveVehicleImageAsync(images);

                foreach (var item in vehicelImages)
                {
                    var x = new VehicleImage()
                    {
                        VehicleId = entity.Id,
                        FileInformationId = item.Id
                    };
                    EntityHelper.TrySetId(x, GuidGenerator.Create);

                    entity.VehicleImages.Add(x);
                }
            }

            await _repository.UpdateMasterAsync(entity);

            return ObjectMapper.Map<Vehicle, VehicleResponse>(entity);
        }
    }
}
