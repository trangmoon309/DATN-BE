using Datn.ApiManagement.Services;
using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using System.Net;
using System.Net.Http;
using Datn.ApiManagement.Mock;

namespace Datn.ApiManagement.Controllers
{
    [Route("api/mocks")]
    public class MockController : ApiManagementController
    {
        private readonly IMockAppService _service;

        public MockController(IMockAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("vehicle-types")]
        public async Task<IActionResult> MockVehicleTypes()
        {
            var result = await _service.MockVehicleTypes();
            return Ok(result);
        }

        [HttpGet]
        [Route("vehicle-lines")]
        public async Task<IActionResult> MockVehicleLines()
        {
            var result = await _service.MockVehicleLines();
            return Ok(result);
        }

        [HttpGet]
        [Route("vehicles")]
        public async Task<IActionResult> MockVehicles()
        {
            var result = await _service.MockVehicles();
            return Ok(result);
        }
    }
}
