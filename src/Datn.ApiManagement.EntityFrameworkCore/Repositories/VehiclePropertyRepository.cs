using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.Repositories
{
    public class VehiclePropertyRepository : EfCoreRepository<IApiManagementDbContext, VehicleProperty, Guid>, IVehiclePropertyRepository
    {
        public VehiclePropertyRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public IQueryable<VehicleProperty> GetList()
        {
            return GetQueryable()
                .Include(x => x.Vehicle)
                .Include(x => x.VehicleTypeDetail);
        }
    }
}
