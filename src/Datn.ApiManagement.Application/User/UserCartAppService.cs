using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Linq;

namespace Datn.ApiManagement.Services
{
    [RemoteService(IsMetadataEnabled = false)]
    public class UserCartAppService : CrudAppService<
            UserCart,
            UserCartResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            UserCartRequest,
            UserCartRequest>, IUserCartAppService
    {
        private readonly IUserCartRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public UserCartAppService(IUserCartRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }
    }
}
