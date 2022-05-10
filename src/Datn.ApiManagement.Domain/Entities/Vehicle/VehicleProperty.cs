using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class VehicleProperty : FullAuditedAggregateRoot<Guid>
    {
        public Guid VehicleId { get; set; }

        public Guid VehicleTypeDetailId { get; set; }

        public Vehicle Vehicle { get; set; }

        public VehicleTypeDetail VehicleTypeDetail { get; set; }
    }
}
