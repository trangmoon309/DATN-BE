// See https://aka.ms/new-console-template for more information
using Grpc.Core;
using Grpc.Net.Client;
using System;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Greeter
            //var input = new HelloRequest
            //{
            //    Name = "Tim"
            //};
            //var channel = GrpcChannel.ForAddress("http://localhost:5127");
            //var client = new Greeter.GreeterClient(channel);

            //var reply = await client.SayHelloAsync(input);

            //Console.WriteLine(reply.Message);

            #endregion

            #region Customer
            //var channel = GrpcChannel.ForAddress("http://localhost:5127");
            //var client = new Customer.CustomerClient(channel);

            //var input = new CustometLookupModel()
            //{
            //    UserId = 1
            //};

            //var customer = await client.GetCustomerInfoAsync(input);

            //Console.WriteLine($"{customer.FirstName} {customer.LastName}");

            //Console.WriteLine("New customers:");

            //using(var call = client.GetNewCustomers(new NewCustomerRequest()))
            //{
            //    while(await call.ResponseStream.MoveNext())
            //    {
            //        var currentCustomer = call.ResponseStream.Current;
            //        Console.WriteLine($"{currentCustomer.FirstName} {currentCustomer.LastName}");
            //    }
            //}

            #endregion

            //var channel = GrpcChannel.ForAddress("http://localhost:50051");
            //var input = new HelloRequest
            //{
            //    Name = "Tim"
            //};
            //var client = new Greeting.GreetingClient(channel);
            //var reply = client.SayHello(input);
            //Console.WriteLine(reply.Message);

            var channel = GrpcChannel.ForAddress("http://localhost:50051");
            var input = new UserRequest
            { Id = "3a03c0bf-7649-7d45-9de9-661281763325" };

            var client = new Recommendation.RecommendationClient(channel);
            var reply = client.GetItemRecommended(input);
            Console.WriteLine(reply.ItemIds);
            Console.ReadLine();
        }
    }
}