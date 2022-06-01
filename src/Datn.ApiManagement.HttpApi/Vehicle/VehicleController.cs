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
    [Route("api/vehicles")]
    public class VehicleController : ApiManagementController
    {
        private readonly IVehicleAppService _service;

        public VehicleController(IVehicleAppService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetListAsync(SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetPagedListAsync(request, pageRequest);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var result = await _service.GetAsync(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(VehicleRequest request)
        {
            var result = await _service.CreatesAsync(request);

            return CreatedAtAction(null, result);
        }

        [HttpPost]
        [Route("{vehicleId}/upload-vehicle-images")]
        public async Task<IActionResult> CreatVehicleImagesAsync([FromForm] List<IFormFile> images, Guid vehicleId)
        {
            var result = await _service.CreatVehicleImagesAsync(vehicleId, images);

            return CreatedAtAction(null, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateVehicleRequest request)
        {
            var result = await _service.UpdatesAsync(id, request);

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await _service.DeleteAsync(id);

            return Ok();
        }
    }
}
