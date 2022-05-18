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
    public class ApiManagementIdentityDbContext : AbpDbContext<ApiManagementIdentityDbContext>, IApiManagementIdentityDbContext
    {
        public DbSet<User> AbpUsers { get; set; }

        public DbSet<Role> AbpRoles { get; set; }

        public DbSet<UserRole> AbpUserRoles { get; set; }

        public ApiManagementIdentityDbContext(DbContextOptions<ApiManagementIdentityDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserRole>().HasKey(table => new {
                table.RoleId,
                table.UserId
            });

            builder.ConfigureApiManagement();
        }
    }
}
