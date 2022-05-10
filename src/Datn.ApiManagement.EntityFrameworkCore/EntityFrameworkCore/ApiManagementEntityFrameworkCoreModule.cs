using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Datn.ApiManagement.EntityFrameworkCore;

[DependsOn(
    typeof(ApiManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class ApiManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ApiManagementDbContext>(options =>
        {
            options.AddRepository<VehicleType, VehicleTypeRepository>();
            options.AddRepository<VehicleTypeDetail, VehicleTypeDetailRepository>();

            options.AddRepository<VehicleLine, VehicleLineRepository>();

            options.AddRepository<Vehicle, VehicleRepository>();
            options.AddRepository<VehicleProperty, VehiclePropertyRepository>();

            options.AddRepository<UserCart, UserCartRepository>();
            options.AddRepository<UserFavoriteVehicle, UserFavoriteVehicleRepository>();

            options.AddRepository<UserTransaction, UserTransactionRepository>();
            options.AddRepository<UserTransactionVehicle, UserTransactionVehicleRepository>();
        });
    }
}
