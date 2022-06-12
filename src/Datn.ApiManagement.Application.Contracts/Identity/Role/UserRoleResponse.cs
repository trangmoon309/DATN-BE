using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Data;

namespace Datn.ApiManagement.Models
{
    public class UserRoleResponse : EntityDto<string>
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }

        public RoleResponse Role { get; set; }
    }
}
