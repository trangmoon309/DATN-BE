using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public interface IPayPalAppService : IApplicationService
    {
        Task<PayPalPaymentExecutedResponse> GetResult(string paymentId, string token, string PayerID);

        Task<string> CreatePayment(double total);
    }
}
