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
    public class VehicleLineRepository : EfCoreRepository<IApiManagementDbContext, VehicleLine, Guid>, IVehicleLineRepository
    {
        public VehicleLineRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
