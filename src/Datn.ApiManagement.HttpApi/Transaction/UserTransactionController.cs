﻿using Datn.ApiManagement.Services;
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
    [Route("api/user-transactions")]
    public class UserTransactionController : ApiManagementController
    {
        private readonly IUserTransactionAppService _service;

        public UserTransactionController(IUserTransactionAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync(SearchUserTransactionRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetByUserPagedListAsync(request, pageRequest);

            return Ok(result);
        }

        [HttpGet]
        [Route("summary")]
        public async Task<IActionResult> SummaryAsync()
        {
            var result = await _service.SummaryInfors();

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
        public async Task<IActionResult> CreateAsync(UserTransactionRequest request)
        {
            try
            {
                var result = await _service.CreateAsync(request);

                return CreatedAtAction(null, result);
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

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, UpdateUserTransactionRequest request)
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
            await _service.DeleteAsync(id);

            return Ok();
        }
    }
}
