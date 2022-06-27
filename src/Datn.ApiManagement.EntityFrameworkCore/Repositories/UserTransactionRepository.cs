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
        return GetQueryable()
            .Where(x => !x.IsDeleted)
            .Include(x => x.UserTransactionVehicles).ThenInclude(x => x.Vehicle);
    }

    public IQueryable<UserTransaction> GetById(Guid id)
    {
        return GetQueryable()
            .Where(x => !x.IsDeleted && x.Id == id)
            .Include(x => x.UserTransactionVehicles).ThenInclude(x => x.Vehicle)
            .AsNoTracking();
    }

    public async Task<UserTransaction> UpdateMasterAsync(UserTransaction userTransaction)
    {
        var existingParent = await DbContext.UserTransactions
            .Where(p => !p.IsDeleted && p.Id == userTransaction.Id)
            .Include(x => x.UserTransactionVehicles)
            .FirstOrDefaultAsync();

        if (existingParent != null)
        {
            // Update parent
            ///// Vehicle Properties
            DbContext.Entry(existingParent).CurrentValues.SetValues(existingParent);

            // Delete children
            foreach (var existingChild in existingParent.UserTransactionVehicles.ToList())
            {
                if (!userTransaction.UserTransactionVehicles.Any(c => c.Id == existingChild.Id))
                {
                    DbContext.UserTransactionVehicles.Remove(existingChild);
                }

                if (!userTransaction.UserTransactionVehicles.Any(c => c.Id == existingChild.Id))
                {
                    DbContext.UserTransactionVehicles.Remove(existingChild);
                }
            }

            // Update and Insert children
            foreach (var childModel in userTransaction.UserTransactionVehicles)
            {
                var existingChild = existingParent.UserTransactionVehicles
                                    .Where(c => c.Id == childModel.Id)
                                    .SingleOrDefault();

                // Update child
                if (existingChild != null)
                {
                    DbContext.Entry(existingChild).CurrentValues.SetValues(childModel);
                }
                else
                {
                    existingParent.UserTransactionVehicles.Add(childModel);
                }
            }
        }
        DbContext.SaveChanges();

        return existingParent;
    }

}
