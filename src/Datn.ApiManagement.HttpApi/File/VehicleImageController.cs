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
    [Route("api/vehicle-images")]
    public class VehicleImageController : ApiManagementController
    {
        private readonly IVehicleImageAppService _fileAppService;

        public VehicleImageController(IVehicleImageAppService fileAppService)
        {
            _fileAppService = fileAppService;
        }

        [HttpPost]
        public async Task<IActionResult> UploadAsync([FromForm] List<IFormFile> files)
        {
            var result = await _fileAppService.SaveVehicleImageAsync(files);

            return Ok(result);
        }
    }
}