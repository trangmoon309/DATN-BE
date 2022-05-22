using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Datn.ApiManagement.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

public class UserFavoriteVehicleRepository : EfCoreRepository<IApiManagementDbContext, UserFavoriteVehicle, Guid>, IUserFavoriteVehicleRepository
{
    public UserFavoriteVehicleRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public IQueryable<UserFavoriteVehicle> GetList()
    {
        return GetQueryable().Include(x => x.Vehicle);
    }
}
