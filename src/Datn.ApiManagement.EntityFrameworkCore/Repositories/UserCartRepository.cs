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

public class UserCartRepository : EfCoreRepository<IApiManagementDbContext, UserCart, Guid>, IUserCartRepository
{
    public UserCartRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public IQueryable<UserCart> GetList()
    {
        return GetQueryable()
            .Where(x => !x.IsDeleted)
            .Include(x => x.Vehicle)
            .ThenInclude(x => x.VehicleImages);
    }

    public IQueryable<UserCart> GetListByUserId(Guid userId)
    {
        return GetQueryable()
            .Where(x => x.UserId == userId && !x.IsDeleted)
            .Include(x => x.Vehicle)
            .ThenInclude(x => x.VehicleImages);
    }

    public async Task UpdateMultiple(List<UserCart> userCarts)
    {
        DbContext.UserCarts.UpdateRange(userCarts);

        await DbContext.SaveChangesAsync();
    }

    public async Task DeleteMultiple(List<UserCart> userCarts)
    {
        DbContext.UserCarts.RemoveRange(userCarts);

        await DbContext.SaveChangesAsync();
    }
}
