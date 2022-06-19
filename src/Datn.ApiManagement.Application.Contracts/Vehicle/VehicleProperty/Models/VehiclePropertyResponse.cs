using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehiclePropertyResponse : FullAuditedEntityDto<Guid>
    {
        public Guid VehicleId { get; set; }

        public Guid VehicleTypeDetailId { get; set; }

        public string Description { get; set; }

        public string Value { get; set; }

        public VehicleTypeDetailResponse VehicleTypeDetail { get; set; }
    }
}
