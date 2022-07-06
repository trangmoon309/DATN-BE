using Datn.ApiManagement.Services;
using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Microsoft.AspNetCore.Http;

namespace Datn.ApiManagement.Controllers
{
    [Route("api/vehicle-image2")]
    public class VehicleImage2Controller : ApiManagementController
    {
        private readonly IVehicleImage2AppService _service;

        public VehicleImage2Controller(IVehicleImage2AppService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(VehicleImageRequest re)
        {
            var result = await _service.CreateAsync(re);

            return CreatedAtAction(null, result);
        }
    }
}
