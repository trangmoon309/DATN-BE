using Datn.ApiManagement.Entities;
using Datn.ApiManagement.Models;
using Datn.ApiManagement.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;
using Volo.Abp.Content;
using Volo.Abp.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace Datn.ApiManagement.Services
{
    public class VehicleImageAppService : ApplicationService, IVehicleImageAppService
    {
        private readonly IBlobContainer<VehicleImageContainer> _blobContainer;
        private readonly IFileInformationRepository _fileRepository;

        public VehicleImageAppService(IBlobContainer<VehicleImageContainer> blobContainer,
            IFileInformationRepository fileRepository)
        {
            _blobContainer = blobContainer;
            _fileRepository = fileRepository;
        }

        public async Task<List<FileInformationResponse>> SaveVehicleImageAsync(List<IFormFile> files)
        {
            var responses = new List<FileInformationResponse>();
            foreach (var file in files)
            {
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream).ConfigureAwait(false);

                var newFile = new FileInformation()
                {
                    Name = file.FileName,
                    Type = file.ContentType
                };
                EntityHelper.TrySetId(newFile, GuidGenerator.Create);
                var created = await _fileRepository.InsertAsync(newFile);
                responses.Add(ObjectMapper.Map<FileInformation, FileInformationResponse>(created));

                await _blobContainer.SaveAsync(newFile.Id.ToString(), memoryStream.ToArray()).ConfigureAwait(false);
            }
            return responses;
        }

        public async Task<byte[]> GetVehicleImageByNameAsync(string name)
        {
            var x = await _blobContainer.GetAllBytesOrNullAsync(name);
            return x;
        }

        public async Task<byte[]> GetVehicleImageByIdAsync(Guid id)
        {
            var x = await _blobContainer.GetAllBytesOrNullAsync(id.ToString());
            return x;
        }
    }
}
