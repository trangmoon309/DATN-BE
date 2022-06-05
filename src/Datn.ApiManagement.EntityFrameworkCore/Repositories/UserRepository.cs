
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
    public class UserRepository : EfCoreRepository<ApiManagementIdentityDbContext, User, Guid>, IUserRepository
    {
        public UserRepository(IDbContextProvider<ApiManagementIdentityDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public IQueryable<User> SearchKeyWord(string keyWord)
        {
            if (keyWord.IsNullOrEmpty())
            {
                return DbContext.AbpUsers;
            }
            else
            {
                return DbContext.AbpUsers.Where(x => (x.Name.ToLower().Contains(keyWord.ToLower())
                    || x.Surname.ToLower().Contains(keyWord.ToLower())) && !x.IsDeleted);
            }
        }

        public async Task<IQueryable<User>> GetList()
        {
            var x = await GetQueryableAsync();
            return x;//.Include(x => x.UserRoles).ThenInclude(x => x.Role);
        }

        public async Task<IQueryable<User>> GetById(Guid id)
        {
            var x = await GetQueryableAsync();
            return x.Where(x => !x.IsDeleted && x.Id.Equals(id))
                    //.Include(x => x.UserRoles).ThenInclude(x => x.Role)
                    .AsNoTracking();
        }
    }
}
