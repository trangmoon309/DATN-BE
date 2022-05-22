using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class VehicleImage : FullAuditedAggregateRoot<Guid>
    {
        public Guid VehicleId { get; set; }

        public Guid FileInformationId { get; set; } 

        public Vehicle Vehicle { get; set; }

        public FileInformation FileInformation { get; set; }
    }
}
