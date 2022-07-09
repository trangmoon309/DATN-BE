using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Volo.Abp.Domain.Repositories;
namespace Datn.ApiManagement.Repositories
{
    public interface IUserTransactionVehicleRepository : IRepository<UserTransactionVehicle, Guid>
    {
        IQueryable<UserTransactionVehicle> GetList();
    }
}
