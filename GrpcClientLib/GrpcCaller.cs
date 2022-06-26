using Grpc.Core;
using Grpc.Net.Client;
using GrpcClient;
using System;

namespace GrpcClientLib
{
    public class GrpcCaller
    {
        public void GetItemRecommend()
        {
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