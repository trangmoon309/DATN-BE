using Datn.ApiManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Datn.ApiManagement.EntityFrameworkCore;

public static class ApiManagementDbContextModelCreatingExtensions
{
    public static void ConfigureApiManagement(
            this ModelBuilder builder,
            Action<ApiManagementModelBuilderConfigurationOptions> optionsAction = null)
    {
        Check.NotNull(builder, nameof(builder));

        var options = new ApiManagementModelBuilderConfigurationOptions(
            ApiManagementDbProperties.DbTablePrefix,
            ApiManagementDbProperties.DbSchema
        );

        optionsAction?.Invoke(options);

        builder.Entity<FileInformation>(b =>
        {
            b.ToTable("FileInformations", "files");
            b.ConfigureByConvention();
        });

        builder.Entity<VehicleType>(b =>
        {
            b.ToTable("VehicleTypes", "vehicleType");
            b.ConfigureByConvention();
        });

        builder.Entity<VehicleTypeDetail>(b =>
        {
            b.ToTable("VehicleTypeDetails", "vehicleType");
            b.ConfigureByConvention();
        });

        builder.Entity<VehicleLine>(b =>
        {
            b.ToTable("VehicleLines", "vechielLine");
            b.ConfigureByConvention();
        });

        builder.Entity<Vehicle>(b =>
        {
            b.ToTable("Vehicles", "vehicle");
            b.ConfigureByConvention();
        });

        builder.Entity<VehicleImage>(b =>
        {
            b.ToTable("VehicleImages", "vehicle");
            b.ConfigureByConvention();
        });

        builder.Entity<VehicleProperty>(b =>
        {
            b.ToTable("VehicleProperties", "vehicle");
            b.ConfigureByConvention();
        });

        builder.Entity<UserCart>(b =>
        {
            b.ToTable("UserCarts", "cart");
            b.ConfigureByConvention();
        });

        builder.Entity<UserFavoriteVehicle>(b =>
        {
            b.ToTable("UserFavoriteVehicles", "cart");
            b.ConfigureByConvention();
        });

        builder.Entity<UserTransaction>(b =>
        {
            b.ToTable("UserTransactions", "transaction");
            b.ConfigureByConvention();
        });

        builder.Entity<UserTransactionVehicle>(b =>
        {
            b.ToTable("UserTransactionVehicles", "transaction");
            b.ConfigureByConvention();
        });
    }
}
