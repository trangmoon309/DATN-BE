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
    public class FileInformationAppService : CrudAppService<
            FileInformation,
            FileInformationResponse,
            Guid,
            PagedAndSortedResultRequestDto,
            FileInformationRequest,
            FileInformationRequest>, IFileInformationAppService
    {
        private readonly IFileInformationRepository _repository;
        private readonly IAsyncQueryableExecuter _asyncQueryableExecuter;
        public FileInformationAppService(IFileInformationRepository repository,
            IAsyncQueryableExecuter asyncQueryableExecuter) : base(repository)
        {
            _repository = repository;
            _asyncQueryableExecuter = asyncQueryableExecuter;
        }
    }
}