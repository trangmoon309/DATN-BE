using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class VehicleTypeDetail : FullAuditedAggregateRoot<Guid>
    {
        public string VehicleTypeId { get; set; }

        public string Name { get; set; }
    }
}
