using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Repositories;
using Microsoft.Extensions.DependencyInjection;
using PBL6.Hreo.Repository;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Datn.ApiManagement.EntityFrameworkCore;

[DependsOn(
    typeof(ApiManagementDomainModule),
    typeof(AbpEntityFrameworkCoreModule),
    typeof(AbpIdentityEntityFrameworkCoreModule)
)]
public class ApiManagementEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<ApiManagementIdentityDbContext>(options =>
        {
            options.AddRepository<User, UserRepository>();
        });

        context.Services.AddAbpDbContext<ApiManagementDbContext>(options =>
        {
            options.AddRepository<FileInformation, FileInformationRepository>();

            options.AddRepository<VehicleType, VehicleTypeRepository>();
            options.AddRepository<VehicleTypeDetail, VehicleTypeDetailRepository>();

            options.AddRepository<VehicleLine, VehicleLineRepository>();

            options.AddRepository<Vehicle, VehicleRepository>();
            options.AddRepository<VehicleImage, VehicleImageRepository>();
            options.AddRepository<VehicleProperty, VehiclePropertyRepository>();

            options.AddRepository<UserCart, UserCartRepository>();
            options.AddRepository<UserFavoriteVehicle, UserFavoriteVehicleRepository>();

            options.AddRepository<UserTransaction, UserTransactionRepository>();
            options.AddRepository<UserTransactionVehicle, UserTransactionVehicleRepository>();
        });
    }
}
