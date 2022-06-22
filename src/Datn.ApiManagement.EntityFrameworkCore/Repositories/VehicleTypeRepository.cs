using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.Repositories
{
    public class VehicleTypeRepository : EfCoreRepository<IApiManagementDbContext, VehicleType, Guid>, IVehicleTypeRepository
    {
        public VehicleTypeRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public IQueryable<VehicleType> SearchKeyWord(IQueryable<VehicleType> query, string keyWord)
        {
            query = query.Where(x => (x.Name.ToLower().Contains(keyWord.ToLower())
                                || x.Code.ToLower().Contains(keyWord.ToLower())) && !x.IsDeleted)
                         .Include(x => x.VehicleTypeDetails);
            return query;
        }

        public IQueryable<VehicleType> GetList()
        {
            return GetQueryable().Include(x => x.VehicleTypeDetails);
        }

        public IQueryable<VehicleType> GetById(Guid id)
        {
            return GetQueryable()
                .Where(x => !x.IsDeleted && x.Id == id)
                .Include(x => x.VehicleTypeDetails)
                .AsNoTracking();
        }

        public async Task CreateMultiple(List<VehicleType> list)
        {
            await DbContext.VehicleTypes.AddRangeAsync(list);

            await DbContext.SaveChangesAsync();
        }

        public async Task<VehicleType> UpdateMasterAsync(VehicleType vehicleType, List<Vehicle> vehicles)
        {
            var existingParent = await DbContext.VehicleTypes
                .Where(p => p.Id == vehicleType.Id)
                .Include(p => p.VehicleTypeDetails)
                .FirstOrDefaultAsync();

            if (existingParent != null)
            {
                // Update parent
                DbContext.Entry(existingParent).CurrentValues.SetValues(vehicleType);

                // Delete children
                foreach (var existingChild in existingParent.VehicleTypeDetails.ToList())
                {
                    if (!vehicleType.VehicleTypeDetails.Any(c => c.Id == existingChild.Id))
                    {
                        if(vehicles.Any(v => v.VehicleProperties.FirstOrDefault(vp => vp.VehicleTypeDetailId == existingChild.Id) != null))
                        {
                            throw new Exception("Fail to delete: Property: " + existingChild.Name + " is currently used.");
                        }
                        DbContext.VehicleTypeDetails.Remove(existingChild);
                    }
                }

                // Update and Insert children
                foreach (var childModel in vehicleType.VehicleTypeDetails)
                {
                    var existingChild = existingParent.VehicleTypeDetails
                                        .Where(c => c.Id == childModel.Id)
                                        .SingleOrDefault();

                    // Update child
                    if (existingChild != null)
                    {
                        DbContext.Entry(existingChild).CurrentValues.SetValues(childModel);
                    }
                    else
                    {
                        existingParent.VehicleTypeDetails.Add(childModel);
                    }
                }
            }
            DbContext.SaveChanges();

            return existingParent;
        }
    }
}
