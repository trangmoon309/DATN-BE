using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IVehicleImageAppService : IApplicationService
    {
        Task<List<FileInformationResponse>> SaveVehicleImageAsync(List<IFormFile> files);

        Task<byte[]> GetVehicleImageByNameAsync(string name);

        Task<byte[]> GetVehicleImageByIdAsync(Guid id);
    }
}
