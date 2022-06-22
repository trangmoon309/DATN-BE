using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IVehicleRepository : IRepository<Vehicle, Guid>
    {
        IQueryable<Vehicle> SearchKeyWord(IQueryable<Vehicle> query, string keyWord);

        IQueryable<Vehicle> GetList();

        Task<Vehicle> UpdateMasterAsync(Vehicle vehicle);

        IQueryable<Vehicle> GetById(Guid id);

        void CreateMultiple(List<Vehicle> list);
    }
}
