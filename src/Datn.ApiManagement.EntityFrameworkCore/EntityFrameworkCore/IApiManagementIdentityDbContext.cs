using Datn.ApiManagement.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Datn.ApiManagement.EntityFrameworkCore
{
    [ConnectionStringName(ApiManagementDbProperties.IdentityConnectionStringName)]
    public interface IApiManagementIdentityDbContext : IEfCoreDbContext
    {
        DbSet<User> AbpUsers { get; set; }

        DbSet<Role> AbpRoles { get; set; }

        DbSet<UserRole> AbpUserRoles { get; set; }
    }
}
