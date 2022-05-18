using Datn.ApiManagement.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Repositories;

namespace Datn.ApiManagement.Repositories
{
    public interface IFileInformationRepository : IRepository<FileInformation, Guid>
    {
    }
}
