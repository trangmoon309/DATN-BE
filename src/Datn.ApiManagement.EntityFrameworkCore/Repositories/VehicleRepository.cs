using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.Repositories
{
    public class VehicleRepository : EfCoreRepository<IApiManagementDbContext, Vehicle, Guid>, IVehicleRepository
    {
        public VehicleRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public IQueryable<Vehicle> SearchKeyWord(IQueryable<Vehicle> query, string keyWord)
        {
            query = query.Where(x => (x.Name.ToLower().Contains(keyWord.ToLower())
                                || x.Code.ToLower().Contains(keyWord.ToLower())) && !x.IsDeleted);
            return query;
        }

        public IQueryable<Vehicle> GetList()
        {
            return GetQueryable()
                .Include(x => x.VehicleProperties)
                .Include(x => x.VehicleImages)
                .Include(x => x.VehicleLine)
                .Include(x => x.VehicleType);
        }

        public IQueryable<Vehicle> GetById(Guid id)
        {
            return GetQueryable()
                .Where(x => !x.IsDeleted && x.Id == id)
                .Include(x => x.VehicleProperties)
                .Include(x => x.VehicleImages)
                .AsNoTracking();
        }

        public async Task<Vehicle> UpdateMasterAsync(Vehicle vehicle)
        {
            var existingParent = await DbContext.Vehicles
                .Where(p => p.Id == vehicle.Id)
                .Include(p => p.VehicleProperties)
                .Include(p => p.VehicleImages)
                .FirstOrDefaultAsync();

            if (existingParent != null)
            {
                // Update parent
                ///// Vehicle Properties
                DbContext.Entry(existingParent).CurrentValues.SetValues(vehicle);

                // Delete children
                foreach (var existingChild in existingParent.VehicleProperties.ToList())
                {
                    if (!vehicle.VehicleProperties.Any(c => c.Id == existingChild.Id))
                    {
                        DbContext.VehicleProperties.Remove(existingChild);
                    }

                    if (!vehicle.VehicleProperties.Any(c => c.Id == existingChild.Id))
                    {
                        DbContext.VehicleProperties.Remove(existingChild);
                    }
                }

                // Update and Insert children
                foreach (var childModel in vehicle.VehicleProperties)
                {
                    var existingChild = existingParent.VehicleProperties
                                        .Where(c => c.Id == childModel.Id)
                                        .SingleOrDefault();

                    // Update child
                    if (existingChild != null)
                    {
                        DbContext.Entry(existingChild).CurrentValues.SetValues(childModel);
                    }
                    else
                    {
                        existingParent.VehicleProperties.Add(childModel);
                    }
                }

                ///// Vehicle Images
                // Delete children
                foreach (var existingChild in existingParent.VehicleImages.ToList())
                {
                    if (!vehicle.VehicleImages.Any(c => c.Id == existingChild.Id))
                    {
                        DbContext.VehicleImages.Remove(existingChild);
                    }

                    if (!vehicle.VehicleImages.Any(c => c.Id == existingChild.Id))
                    {
                        DbContext.VehicleImages.Remove(existingChild);
                    }
                }

                // Update and Insert children
                foreach (var childModel in vehicle.VehicleImages)
                {
                    var existingChild = existingParent.VehicleImages
                                        .Where(c => c.Id == childModel.Id)
                                        .SingleOrDefault();

                    // Update child
                    if (existingChild != null)
                    {
                        DbContext.Entry(existingChild).CurrentValues.SetValues(childModel);
                    }
                    else
                    {
                        existingParent.VehicleImages.Add(childModel);
                    }
                }
            }
            DbContext.SaveChanges();

            return existingParent;
        }
    }
}
