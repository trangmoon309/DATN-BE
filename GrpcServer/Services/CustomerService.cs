using Grpc.Core;
using GrpcServer;

namespace GrpcServer.Services
{
    public class CustomerService : Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ILogger<CustomerService> logger)
        {
            _logger = logger;
        }

        public override Task<CustomerModel> GetCustomerInfo(CustometLookupModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();
            if(request.UserId == 1)
            {
                output.FirstName = "Trang";
                output.LastName = "Huynh";
            }
            return Task.FromResult(output);
        }

        public override async Task GetNewCustomers(NewCustomerRequest request, IServerStreamWriter<CustomerModel> responseStream, ServerCallContext context)
        {
            List<CustomerModel> customers = new List<CustomerModel>()
            {
                new CustomerModel
                {
                    FirstName = "Trang1",
                    LastName =  "Huynh",
                    Email = "aa@gmail.com",
                    Age = 41,
                    IsAlive = true,
                },
                new CustomerModel
                {
                    FirstName = "Trang2",
                    LastName =  "Huynh",
                    Email = "aa@gmail.com",
                    Age = 41,
                    IsAlive = true,
                },
                new CustomerModel
                {
                    FirstName = "Trang3",
                    LastName =  "Huynh",
                    Email = "aa@gmail.com",
                    Age = 41,
                    IsAlive = true,
                }
            };

            foreach(var item in customers)
            {
                await responseStream.WriteAsync(item);
            }
        }
    }
}
