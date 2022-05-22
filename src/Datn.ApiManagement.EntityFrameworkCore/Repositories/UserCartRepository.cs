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
        return GetQueryable().Include(x => x.Vehicle);
    }
}
