using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehicleTypeResponse : FullAuditedEntityDto<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<VehicleTypeDetailResponse> VehicleTypeDetails { get; set; }
    }
}
