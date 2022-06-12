using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class UserRoleRequest
    {
        public Guid UserId { get; set; }

        public Guid RoleId { get; set; }
    }
}
