using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class RoleRequest
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public bool IsDefault { get; set; }

        public bool IsPublic { get; set; }

        public bool IsShowAllBranch { get; set; }
    }
}
