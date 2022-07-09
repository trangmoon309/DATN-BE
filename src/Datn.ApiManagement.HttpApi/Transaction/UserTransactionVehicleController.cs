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
    [Route("api/user-transaction-vehicles")]
    public class UserTransactionVehicleController : ApiManagementController
    {
        private readonly IUserTransactionVehicleAppService _service;

        public UserTransactionVehicleController(IUserTransactionVehicleAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("by-condition")]
        public async Task<IActionResult> GetListAsync(SearchUserTransactionVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            var result = await _service.GetByConditionPagedListAsync(request, pageRequest);

            return Ok(result);
        }
    }
}
