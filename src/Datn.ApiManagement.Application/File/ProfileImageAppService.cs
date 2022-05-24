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
    public class ProfileImageAppService : ApplicationService, IProfileImageAppService
    {
        private readonly IBlobContainer<ProfileImageContainer> _blobContainer;
        private readonly IFileInformationRepository _fileRepository;

        public ProfileImageAppService(IBlobContainer<ProfileImageContainer> blobContainer, 
            IFileInformationRepository fileRepository)
        {
            _blobContainer = blobContainer;
            _fileRepository = fileRepository;
        }

        public async Task<List<FileInformationResponse>> SaveProfileImageAsync(List<IFormFile> files)
        {
            var responses = new List<FileInformationResponse>();
            foreach (var file in files)
            {
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream).ConfigureAwait(false);
                var id = Guid.NewGuid();
                var newFile = new FileInformation()
                {
                    Name = file.FileName,
                    Type = file.ContentType
                };
                EntityHelper.TrySetId(newFile, GuidGenerator.Create);
                var created = await _fileRepository.InsertAsync(newFile);
                responses.Add(ObjectMapper.Map<FileInformation, FileInformationResponse>(created));
                await _blobContainer.SaveAsync(newFile.Id.ToString() + ".jpg", memoryStream.ToArray()).ConfigureAwait(false);
            }
            return responses;
        }
    }
}
