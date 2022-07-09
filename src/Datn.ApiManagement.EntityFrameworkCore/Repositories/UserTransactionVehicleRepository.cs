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

public class UserTransactionVehicleRepository : EfCoreRepository<IApiManagementDbContext, UserTransactionVehicle, Guid>, IUserTransactionVehicleRepository
{
    public UserTransactionVehicleRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    public IQueryable<UserTransactionVehicle> GetList()
    {
        return GetQueryable()
            .Where(x => !x.IsDeleted)
            .Include(x => x.UserTransaction)
            .Include(x => x.Vehicle);
    }
}
