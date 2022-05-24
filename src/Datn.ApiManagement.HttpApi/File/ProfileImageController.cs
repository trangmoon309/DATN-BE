using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Datn.ApiManagement.Controllers
{
    [Route("api/profile-images")]
    public class ProfileImageController : ApiManagementController
    {
        private readonly IProfileImageAppService _fileAppService;

        public ProfileImageController(IProfileImageAppService fileAppService)
        {
            _fileAppService = fileAppService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync([FromForm] List<IFormFile> files)
        {
            await _fileAppService.SaveProfileImageAsync(files);

            return Ok();
        }
    }
}