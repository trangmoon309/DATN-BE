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
    [Route("api/vehicle-types")]
    public class VehicleTypeController : ApiManagementController
    {
        private readonly IVehicleTypeAppService _service;

        public VehicleTypeController(IVehicleTypeAppService service)
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
        public async Task<IActionResult> CreateAsync(VehicleTypeRequest request)
        {
            var result = await _service.CreateAsync(request);

            return CreatedAtAction(null, result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateVehicleTypeRequest request)
        {
            try
            {
                var result = await _service.UpdateAsync(id, request);

                return Ok(result);
            }
            catch (Exception e)
            {
                var exceptionError = new ExceptionHandlingResponse();
                exceptionError.ValidationErrors.Add(
                        new ValidationErrorsResponse
                        {
                            Message = e.Message,
                            Member = e.Source
                        });
                return StatusCode(StatusCodes.Status500InternalServerError, exceptionError);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            try
            {
                await _service.DeleteAsync(id);

                return Ok();
            }
            catch (Exception e)
            {
                var exceptionError = new ExceptionHandlingResponse();
                exceptionError.ValidationErrors.Add(
                        new ValidationErrorsResponse
                        {
                            Message = e.Message,
                            Member = e.Source
                        });
                return StatusCode(StatusCodes.Status500InternalServerError, exceptionError);
            }
        }
    }
}
