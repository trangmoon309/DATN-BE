using Datn.ApiManagement.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.BlobStoring;

namespace Datn.ApiManagement.Services
{
    public class ProfileAppService : ApplicationService, IProfileAppService
    {
        private readonly IBlobContainer<ProfilePictureContainer> _blobContainer;
        private readonly IFileInformationRepository _fileRepository;

        public ProfileAppService(IBlobContainer<ProfilePictureContainer> blobContainer, 
            IFileInformationRepository fileRepository)
        {
            _blobContainer = blobContainer;
            _fileRepository = fileRepository;
        }

        public async Task SaveProfilePictureAsync(List<IFormFile> files)
        {
            //var blobName = CurrentUser.GetId().ToString();
            //var output = new List<DocumentDto>();
            foreach (var file in files)
            {
                using var memoryStream = new MemoryStream();
                await file.CopyToAsync(memoryStream).ConfigureAwait(false);
                var id = Guid.NewGuid();
                //var newFile = new Document(id, file.Length, file.ContentType, CurrentTenant.Id);
                //var created = await _repository.InsertAsync(newFile);
                await _blobContainer.SaveAsync(id.ToString(), memoryStream.ToArray()).ConfigureAwait(false);

                //output.Add(ObjectMapper.Map<Document, DocumentDto>(newFile));
            }
        }

        public async Task<byte[]> GetProfilePictureAsync(string name)
        {
            var x = await _blobContainer.GetAllBytesOrNullAsync(name);
            return x;
        }
    }
}
