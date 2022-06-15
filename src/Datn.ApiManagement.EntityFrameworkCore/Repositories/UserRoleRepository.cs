
using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace PBL6.Hreo.Repository
{
    public class UserRoleRepository : EfCoreRepository<ApiManagementIdentityDbContext, UserRole, string>, IUserRoleRepository
    {
        public UserRoleRepository(IDbContextProvider<ApiManagementIdentityDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public IQueryable<UserRole> GetList()
        {
            return GetQueryable().Include(x => x.Role);
        }
    }
}
