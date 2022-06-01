using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Datn.ApiManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

public class VehicleImageRepository : EfCoreRepository<IApiManagementDbContext, VehicleImage, Guid>, IVehicleImageRepository
{
    public VehicleImageRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public async Task CreateMultiple(List<VehicleImage> vehicleImages)
    {
        await DbContext.VehicleImages.AddRangeAsync(vehicleImages);

        await DbContext.SaveChangesAsync();
    }
}
