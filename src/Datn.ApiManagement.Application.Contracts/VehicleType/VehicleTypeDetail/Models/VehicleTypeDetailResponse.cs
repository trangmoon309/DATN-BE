using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehicleTypeDetailResponse : FullAuditedEntityDto<Guid>
    {
        public string VehicleTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }
    }
}
