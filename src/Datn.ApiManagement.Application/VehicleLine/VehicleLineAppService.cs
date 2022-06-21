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
    public class VehicleLineAppService : CrudAppService<
            VehicleLine,
            VehicleLineResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleLineRequest,
            VehicleLineRequest>, IVehicleLineAppService
    {
        private readonly IVehicleLineRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public VehicleLineAppService(IVehicleLineRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }
        public async Task<PagedResultDto<VehicleLineResponse>> GetPagedListAsync(string keyWord, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                if (keyWord != null) query = _repository.SearchKeyWord(query, keyWord);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<VehicleLine>, List<VehicleLineResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<VehicleLineResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override async Task<VehicleLineResponse> CreateAsync(VehicleLineRequest input)
        {
            try
            {
                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);

                var entity = base.MapToEntity(input);
                EntityHelper.TrySetId(entity, GuidGenerator.Create);
                entity.Code = CodeAutoGenerationHelper.GetNextCode<VehicleLine>(toList, "VL", 4);

                await _repository.InsertAsync(entity);
                var result = ObjectMapper.Map<VehicleLine, VehicleLineResponse>(entity);
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
