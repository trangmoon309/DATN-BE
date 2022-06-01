using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IVehicleImageRepository : IRepository<VehicleImage, Guid>
    {
        Task CreateMultiple(List<VehicleImage> vehicleImages);
    }
}
