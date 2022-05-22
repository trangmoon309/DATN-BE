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

        [HttpGet]
        [Route("byName/{name}")]
        public async Task<IActionResult> DownloadByNameAsync(string name)
        {
            var fileDto = await _fileAppService.GetProfileImageByNameAsync(name);

            return File(fileDto, "image/jpeg", "logo");
        }

        [HttpGet]
        [Route("byId/{id}")]
        public async Task<IActionResult> DownloadByIdAsync(Guid id)
        {
            var fileDto = await _fileAppService.GetProfileImageByIdAsync(id);

            return File(fileDto, "image/jpeg", "logo");
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync([FromForm] List<IFormFile> files)
        {
            await _fileAppService.SaveProfileImageAsync(files);

            return Ok();
        }
    }
}