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
    public class UserFavoriteVehicleAppService : CrudAppService<
            UserFavoriteVehicle,
            UserFavoriteVehicleResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserFavoriteVehicleRequest,
            UserFavoriteVehicleRequest>, IUserFavoriteVehicleAppService
    {
        private readonly IUserFavoriteVehicleRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public UserFavoriteVehicleAppService(IUserFavoriteVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<PagedResultDto<UserFavoriteVehicleResponse>> GetByUserPagedListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();

                query = query.OrderByDescending(x => x.CreationTime);

                query = query.Where(x => x.UserId == userId);

                var toList = await _asyncQueryableExecuter.ToListAsync(query.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount));
                var items = ObjectMapper.Map<List<UserFavoriteVehicle>, List<UserFavoriteVehicleResponse>>(toList);
                var total = query.Count();

                return new PagedResultDto<UserFavoriteVehicleResponse>(total, items);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
