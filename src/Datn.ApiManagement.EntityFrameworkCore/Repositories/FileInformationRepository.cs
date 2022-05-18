using Datn.ApiManagement.Entities;
using Datn.ApiManagement.EntityFrameworkCore;
using Datn.ApiManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

public class FileInformationRepository : EfCoreRepository<IApiManagementDbContext, FileInformation, Guid>, IFileInformationRepository
{
    public FileInformationRepository(IDbContextProvider<IApiManagementDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
