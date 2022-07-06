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
    public class VehicleImage2AppService : CrudAppService<
            VehicleImage,
            VehicleImageResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            VehicleImageRequest,
            VehicleImageRequest>, IVehicleImage2AppService
    {
        private readonly IVehicleImageRepository _repository;
        public VehicleImage2AppService(IVehicleImageRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
