using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IUserCartRepository : IRepository<UserCart, Guid>
    {
        IQueryable<UserCart> GetList();

        IQueryable<UserCart> GetListByUserId(Guid userId);

        Task UpdateMultiple(List<UserCart> userCarts);

        Task DeleteMultiple(List<UserCart> userCarts);
    }
}
