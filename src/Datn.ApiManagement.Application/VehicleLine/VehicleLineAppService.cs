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
    }
}
