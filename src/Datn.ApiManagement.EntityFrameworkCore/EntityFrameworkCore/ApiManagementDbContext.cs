using Datn.ApiManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore;

[ConnectionStringName(ApiManagementDbProperties.ConnectionStringName)]
public class ApiManagementDbContext : AbpDbContext<ApiManagementDbContext>, IApiManagementDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<FileInformation> FileInformations { get; set; }

    public DbSet<VehicleLine> VehicleLines { get; set; }

    public DbSet<VehicleType> VehicleTypes { get; set; }

    public DbSet<VehicleProperty> VehicleProperties { get; set; }

    public DbSet<VehicleTypeDetail> VehicleTypeDetails { get; set; }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<VehicleImage> VehicleImages { get; set; }

    public DbSet<UserCart> UserCarts { get; set; }

    public DbSet<UserFavoriteVehicle> UserFavoriteVehicles { get; set; }

    public DbSet<UserTransaction> UserTransactions { get; set; }

    public DbSet<UserTransactionVehicle> UserTransactionVehicles { get; set; }

    public ApiManagementDbContext(DbContextOptions<ApiManagementDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureApiManagement();
    }
}
