using Datn.ApiManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;
using Grpc.Core;
using Grpc.Net.Client;
using System.Threading.Tasks;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using Volo.Abp.Linq;
using System.Linq;
using Datn.ApiManagement.Entities;

namespace GrpcClient
{
    public class RecommendationAppService : ApplicationService, IRecommendationAppService
    {
        private readonly IVehicleRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;

        public RecommendationAppService(IVehicleRepository repository, 
            IAsyncQueryableExecuter asyncQueryableExecuter)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }

        public async Task<List<VehicleResponse>> GetVehicleTypeDetailRecommended(Guid userId)
        {
            try
            {
                var query = _repository.GetList();
                var toList = await _asyncQueryableExecuter.ToListAsync(query);

                var channel = GrpcChannel.ForAddress("http://localhost:50051");
                var input = new UserRequest
                { Id = userId.ToString() };

                var client = new Recommendation.RecommendationClient(channel);
                var reply = client.GetItemRecommended(input);
                var props = reply.ItemIds.ToList();

                toList = toList.Where(x => x.VehicleProperties.Any(y => props.Contains(y.VehicleTypeDetailId.ToString()))).ToList();
                return ObjectMapper.Map<List<Vehicle>,List< VehicleResponse >> (toList);
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
