using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IVehicleLineRepository : IRepository<VehicleLine, Guid>
    {
        IQueryable<VehicleLine> SearchKeyWord(IQueryable<VehicleLine> query, string keyWord);

        IQueryable<VehicleLine> GetList();

        IQueryable<VehicleLine> GetById(Guid id);

        Task CreateMultiple(List<VehicleLine> list);
    }
}
