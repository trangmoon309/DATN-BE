using Datn.ApiManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Grpc.Core;
using Grpc.Net.Client;
using System.Threading.Tasks;

namespace GrpcClient
{
    public class RecommendationAppService : ApplicationService, IRecommendationAppService
    {
        public RecommendationAppService()
        {
        }

        public string GetItemRecommended(Guid userId)
        {
            try
            {
                var channel = GrpcChannel.ForAddress("http://localhost:50051");
                var input = new UserRequest
                { Id = userId.ToString() };

                var client = new Recommendation.RecommendationClient(channel);
                var reply = client.GetItemRecommended(input);
                var result = reply.ItemIds.ToString();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string TrackChange()
        {
            try
            {
                var channel = GrpcChannel.ForAddress("http://localhost:50051");
                var input = new Check();

                var client = new Recommendation.RecommendationClient(channel);
                var reply = client.TrackChange(input);
                var result = reply.Message.ToString();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
