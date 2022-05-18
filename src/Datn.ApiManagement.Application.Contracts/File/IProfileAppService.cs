using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IProfileAppService : IApplicationService
    {
        Task SaveProfilePictureAsync(List<IFormFile> files);

        Task<byte[]> GetProfilePictureAsync(string name);
    }
}
