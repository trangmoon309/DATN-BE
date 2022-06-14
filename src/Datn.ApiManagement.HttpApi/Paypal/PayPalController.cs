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
    [Route("api/paypals")]
    public class PayPalController : ApiManagementController
    {
        private readonly IPayPalAppService _service;

        public PayPalController(IPayPalAppService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        {
            await _service.Test();

            return Ok();
        }

        [HttpGet]
        [Route("payment/success")]
        public async Task<IActionResult> GetListAsync(string paymentId, string token, string PayerID)
        {
            _service.GetResult(paymentId, token, PayerID);

            return Ok();
        }
    }
}
