using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.Repositories
{
    public class VehicleLineRepository : EfCoreRepository<IApiManagementDbContext, VehicleLine, Guid>, IVehicleLineRepository
    {
        public VehicleLineRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
        public IQueryable<VehicleLine> SearchKeyWord(IQueryable<VehicleLine> query, string keyWord)
        {
            query = query.Where(x => (x.Name.ToLower().Contains(keyWord.ToLower())
                                || x.Code.ToLower().Contains(keyWord.ToLower())) && !x.IsDeleted);
            return query;
        }

        public IQueryable<VehicleLine> GetList()
        {
            return GetQueryable();
        }

        public IQueryable<VehicleLine> GetById(Guid id)
        {
            return GetQueryable().Where(x => !x.IsDeleted && x.Id == id);
        }
    }
}
