using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IUserTransactionRepository : IRepository<UserTransaction, Guid>
    {
        IQueryable<UserTransaction> GetList();

        IQueryable<UserTransaction> GetById(Guid id);

        Task<UserTransaction> UpdateMasterAsync(UserTransaction userTransaction);
    }
}
