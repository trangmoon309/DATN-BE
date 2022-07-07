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
using Volo.Abp.Application.Dtos;

namespace GrpcClient
{
    public class RecommendationAppService : ApplicationService, IRecommendationAppService
    {
        private readonly IVehicleRepository _repository;
        private readonly IUserTransactionRepository _transactionRepository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;

        public RecommendationAppService(IVehicleRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter, 
            IUserTransactionRepository transactionRepository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
            _transactionRepository = transactionRepository;
        }

        public async Task<PagedResultDto<VehicleResponse>> GetVehicleTypeDetailRecommended(Guid userId, SearchVehicleRequest request, PagedAndSortedResultRequestDto pageRequest)
        {
            try
            {
                var query = _repository.GetList();
                var transactions = await _transactionRepository.GetListAsync();
                if(!transactions.Any(x => x.UserId == userId))
                {
                    return new PagedResultDto<VehicleResponse>(0, new List<VehicleResponse>());
                }

                var channel = GrpcChannel.ForAddress("http://localhost:50051");
                var input = new UserRequest
                { Id = userId.ToString() };

                var client = new Recommendation.RecommendationClient(channel);
                var reply = client.GetItemRecommended(input);
                var props = reply.ItemIds.ToList();

                if (!request.KeyWord.IsNullOrEmpty()) query = _repository.SearchKeyWord(query, request.KeyWord);

                if (request.VehicleTypeId.HasValue) query = query.Where(x => x.VehicleTypeId == request.VehicleTypeId.Value);

                if (request.VehicleLineId.HasValue) query = query.Where(x => x.VehicleLineId == request.VehicleLineId.Value);

                var toList = await _asyncQueryableExecuter.ToListAsync(query);
                toList = toList.Where(x => x.VehicleProperties.Any(y => props.Contains(y.VehicleTypeDetailId.ToString()))).ToList();
                var total = toList.Count();

                toList = toList.Skip(pageRequest.SkipCount).Take(pageRequest.MaxResultCount).ToList();
                var items = ObjectMapper.Map<List<Vehicle>, List<VehicleResponse>>(toList);

                return new PagedResultDto<VehicleResponse>(total, items);
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
