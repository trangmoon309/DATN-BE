using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
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
            VehicleTypeRequest>, IVehicleTypeAppService
    {
        private readonly IVehicleTypeRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public VehicleTypeAppService(IVehicleTypeRepository repository, 
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }
    }
}
