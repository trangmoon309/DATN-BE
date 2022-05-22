using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class VehicleTypeDetail : FullAuditedAggregateRoot<Guid>
    {
        public Guid VehicleTypeId { get; set; }

        public string Name { get; set; }

        public VehicleType VehicleType { get; set; }
    }
}
