using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class UserResponse : EntityDto<Guid>
    {
        public Guid? TenantId { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public bool IsExternal { get; set; }

        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEnd { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        public ExtraInfors ExtraInfors { get; set; } = new ExtraInfors();

        public List<UserRoleResponse> UserRoles { get; set; }
    }
}
