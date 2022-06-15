using Datn.ApiManagement.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;
using System.Linq;
using Volo.Abp.Application.Services;

namespace Datn.ApiManagement.Services
{
    public class PayPalAppService : ApplicationService, IPayPalAppService
    {
        private readonly IConfiguration _config;
        private string clientId;
        private string secret;

        public PayPalAppService(IConfiguration config)
        {
            _config = config;
            clientId = _config["PayPal:clientId"];
            secret = _config["PayPal:secret"];
        }


        private static HttpClient GetPaypalHttpClient()
        {
            const string sandbox = "https://api-m.sandbox.paypal.com/";

            var http = new HttpClient
            {
                BaseAddress = new Uri(sandbox),
                Timeout = TimeSpan.FromSeconds(30),
            };

            return http;
        }

        private async Task<PaypalAccessToken> GetPayPalAccessTokenAsync(HttpClient http)
        {
            byte[] bytes = Encoding.GetEncoding("iso-8859-1").GetBytes($"{clientId}:{secret}");

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "/v1/oauth2/token");
            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(bytes));

            var form = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials"
            };

            request.Content = new FormUrlEncodedContent(form);

            HttpResponseMessage response = await http.SendAsync(request);

            string content = await response.Content.ReadAsStringAsync();
            PaypalAccessToken accessToken = JsonConvert.DeserializeObject<PaypalAccessToken>(content);
            return accessToken;
        }

        private static async Task<PayPalPaymentCreatedResponse> CreatePaypalPaymentAsync(HttpClient http, PaypalAccessToken accessToken, double total)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "v1/payments/payment");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.access_token);
            var id = Guid.NewGuid().ToString();

            var payment = JObject.FromObject(new
            {
                intent = "sale",
                redirect_urls = new
                {
                    return_url = "https://localhost:44383/api/paypals/payment/success",
                    cancel_url = "https://localhost:44383/user-cart"
                },
                payer = new {payment_method = "paypal", },
                transactions = JArray.FromObject(new[]
                {
                    new
                    {
                        amount = new
                        {
                            total = total,
                            currency = "USD"
                        }
                    }
                })
            });

            request.Content = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await http.SendAsync(request);

            string content = await response.Content.ReadAsStringAsync();
            PayPalPaymentCreatedResponse paypalPaymentCreated = JsonConvert.DeserializeObject<PayPalPaymentCreatedResponse>(content);
            return paypalPaymentCreated;
        }

        private static async Task<PayPalPaymentExecutedResponse> ExecutePaypalPaymentAsync(HttpClient http, PaypalAccessToken accessToken, string paymentId, string payerId)
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, $"v1/payments/payment/{paymentId}/execute");
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken.access_token);

            var payment = JObject.FromObject(new
            {
                payer_id = payerId
            });

            request.Content = new StringContent(JsonConvert.SerializeObject(payment), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await http.SendAsync(request);
            string content = await response.Content.ReadAsStringAsync();
            PayPalPaymentExecutedResponse executedPayment = JsonConvert.DeserializeObject<PayPalPaymentExecutedResponse>(content);
            return executedPayment;
        }

        public async Task<string> CreatePayment(double total)
        {
            HttpClient http = GetPaypalHttpClient();

            // Step 1: Get an access token
            PaypalAccessToken accessToken = await GetPayPalAccessTokenAsync(http);
            Log.Information("Access Token \n{@accessToken}", accessToken);

            // Step 2: Create the payment
            PayPalPaymentCreatedResponse createdPayment = await CreatePaypalPaymentAsync(http, accessToken, total);
            Log.Information("Created payment \n{@createdPayment}", createdPayment);

            // Step 3: Get the approval_url and paste it into a browser
            // It should look something like this: https://www.sandbox.paypal.com/cgi-bin/webscr?cmd=_express-checkout&token=EC-97965369EL8295114
            var approval_url = createdPayment.links.First(x => x.rel == "approval_url").href;
            Log.Information("approval_url\n{approval_url}", approval_url);

            return approval_url;
            //http://localhost:3000/user-transaction?paymentId=PAYID-MKULKUA9J247781BA604802A&token=EC-19012022J16193702&PayerID=LAXAPG2X2KH94
            // Step 4: When paypal redirects to the return_url, we need to grab the PayerID and the paymentId and execute the payment
        }

        public async Task<PayPalPaymentExecutedResponse> GetResult(string paymentId, string token, string PayerID)
        {
            HttpClient http = GetPaypalHttpClient();
            PaypalAccessToken accessToken = await GetPayPalAccessTokenAsync(http);

            PayPalPaymentExecutedResponse executedPayment = await ExecutePaypalPaymentAsync(http, accessToken, paymentId, paymentId);

            return executedPayment;
        }
    }
}
