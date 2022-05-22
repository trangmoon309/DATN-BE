using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Datn.ApiManagement.Models
{
    public class VehicleImageResponse : FullAuditedEntityDto<Guid>
    {
        public Guid VehicleId { get; set; }

        public Guid FileInformationId { get; set; }

        public VehicleResponse Vehicle { get; set; }

        public FileInformationResponse FileInformation { get; set; }
    }
}
