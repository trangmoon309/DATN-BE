using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
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
    }
}
