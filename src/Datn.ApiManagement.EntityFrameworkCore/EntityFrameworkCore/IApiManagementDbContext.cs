using Datn.ApiManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public interface IApiManagementDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
    DbSet<FileInformation> FileInformations { get; set; }

    DbSet<VehicleLine> VehicleLines { get; set; }

    DbSet<VehicleType> VehicleTypes { get; set; }

    DbSet<VehicleProperty> VehicleProperties { get; set; }

    DbSet<VehicleTypeDetail> VehicleTypeDetails { get; set; }

    DbSet<Vehicle> Vehicles { get; set; }

    DbSet<VehicleImage> VehicleImages { get; set; }

    DbSet<UserCart> UserCarts { get; set; }

    DbSet<UserFavoriteVehicle> UserFavoriteVehicles { get; set; }

    DbSet<UserTransaction> UserTransactions { get; set; }

    DbSet<UserTransactionVehicle> UserTransactionVehicles { get; set; }
}
