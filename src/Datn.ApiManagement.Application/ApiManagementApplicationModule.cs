using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.Identity;
using Datn.ApiManagement.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.BlobStoring.FileSystem;

namespace Datn.ApiManagement;

[DependsOn(
    typeof(ApiManagementDomainModule),
    typeof(ApiManagementApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpBlobStoringFileSystemModule)
    )]
public class ApiManagementApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<ApiManagementApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<ApiManagementApplicationModule>(validate: true);
        });

        Configure<AbpBlobStoringOptions>(options =>
        {
            options.Containers.ConfigureDefault(container =>
            {
                container.UseFileSystem(fileSystem =>
                {
                    fileSystem.BasePath = "D:\\Selflearning\\DATN\\files";
                });
            });
        });
    }
}
