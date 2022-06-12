using Datn.ApiManagement.Services;
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
    [Route("api/user-carts")]
    public class UserCartController : ApiManagementController
    {
        private readonly IUserCartAppService _service;

        public UserCartController(IUserCartAppService service)
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
        public async Task<IActionResult> CreateAsync(UserCartRequest request)
        {
            var result = await _service.CreateAsync(request);

            return CreatedAtAction(null, result);
        }

        [HttpPut]
        [Route("{userId}")]
        public async Task<IActionResult> UpdateAsync(Guid userId, List<UpdateUserCartRequest> requests)
        {
            var result = await _service.UpdateMultipleByUserId(userId, requests);

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
