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

        [HttpPost]
        [Route("payment/create")]
        public async Task<HttpResponseMessage> GetListAsync(double total)
        {
            var url = await _service.CreatePayment(total);
            var response = new HttpResponseMessage(HttpStatusCode.Moved);
            response.Headers.Location = new Uri(url);
            return response;
        }

        [HttpGet]
        [Route("payment/success")]
        public async Task<IActionResult> GetListAsync(string paymentId, string token, string PayerID)
        {
            await _service.GetResult(paymentId, token, PayerID);

            return Ok();
        }
    }
}
