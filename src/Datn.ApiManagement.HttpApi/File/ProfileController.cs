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
    [Route("api/file/profiles")]
    public class FileController : ApiManagementController
    {
        private readonly IProfileAppService _fileAppService;

        public FileController(IProfileAppService fileAppService)
        {
            _fileAppService = fileAppService;
        }

        [HttpGet]
        public async Task<IActionResult> DownloadByNameAsync(string name)
        {
            var fileDto = await _fileAppService.GetProfilePictureAsync(name);

            return File(fileDto, "image/jpeg", "logo");
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync([FromForm] List<IFormFile> files)
        {
            await _fileAppService.SaveProfilePictureAsync(files);

            return Ok();
        }
    }
}