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

public class UserTransactionRepository : EfCoreRepository<IApiManagementDbContext, UserTransaction, Guid>, IUserTransactionRepository
{
    public UserTransactionRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
    public IQueryable<UserTransaction> GetList()
    {
        return GetQueryable().Include(x => x.UserTransactionVehicles);
    }

    public IQueryable<UserTransaction> GetById(Guid id)
    {
        return GetQueryable().Where(x => !x.IsDeleted && x.Id == id).Include(x => x.UserTransactionVehicles);
    }

}
