using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IVehicleTypeRepository : IRepository<VehicleType, Guid>
    {
        IQueryable<VehicleType> SearchKeyWord(IQueryable<VehicleType> query, string keyWord);

        IQueryable<VehicleType> GetList();

        IQueryable<VehicleType> GetById(Guid id);

        Task<VehicleType> UpdateMasterAsync(VehicleType vehicleType);
    }
}
