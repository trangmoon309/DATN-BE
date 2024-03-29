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
    [Route("api/user-favorite-vehicles")]
    public class UserFavoriteVehicleController : ApiManagementController
    {
        private readonly IUserFavoriteVehicleAppService _service;

        public UserFavoriteVehicleController(IUserFavoriteVehicleAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("by-user/{userId}")]
        public async Task<IActionResult> GetListAsync(Guid userId, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetByUserPagedListAsync(userId, pageRequest);

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
        public async Task<IActionResult> CreateAsync(UserFavoriteVehicleRequest request)
        {
            var result = await _service.CreateAsync(request);

            return CreatedAtAction(null, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UserFavoriteVehicleRequest request)
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
