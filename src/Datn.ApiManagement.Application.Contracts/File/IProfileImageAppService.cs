using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IProfileImageAppService : IApplicationService
    {
        Task<List<FileInformationResponse>> SaveProfileImageAsync(List<IFormFile> files);
    }
}
