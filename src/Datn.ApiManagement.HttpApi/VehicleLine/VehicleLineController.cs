﻿using Datn.ApiManagement.Services;
using Datn.ApiManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Controllers
{
    [Route("api/vehicle-lines")]
    public class VehicleLineController : ApiManagementController
    {
        private readonly IVehicleLineAppService _service;

        public VehicleLineController(IVehicleLineAppService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetListAsync(string keyWord, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetPagedListAsync(keyWord, pageRequest);

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
        public async Task<IActionResult> CreateAsync(VehicleLineRequest request)
        {
            var result = await _service.CreateAsync(request);

            return CreatedAtAction(null, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, VehicleLineRequest request)
        {
            var result = await _service.UpdateAsync(id, request);

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
