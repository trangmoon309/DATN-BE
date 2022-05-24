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
    [Route("api/users")]
    public class UserController : ApiManagementController
    {
        private readonly IUserAppService _service;

        public UserController(IUserAppService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetListAsync(PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetListAsync(pageRequest);

            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var result = await _service.GetAsync(id);

            return Ok(result);
        }

        [HttpGet]
        [Route("current")]
        public async Task<IActionResult> GetCurrentUser()
        {
            var result = await _service.GetCurrentUser();

            return Ok(result);
        }

        [HttpPut]
        [Route("current")]
        public async Task<IActionResult> UpdateCurrentProfile(ProfileRequest request)
        {
            var result = await _service.UpdateCurrentProfile(request);

            return Ok(result);
        }

        [HttpPut]
        [Route("avatar/current")]
        public async Task<IActionResult> UpdateCurrentProfileAvatar(IFormFile file)
        {
            var result = await _service.UpdateCurrentProfileAvatar(file);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> SignUpAsync(UserRequest request)
        {
            try
            {
                var result = await _service.SignUpCustom(request);

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
    }
}
