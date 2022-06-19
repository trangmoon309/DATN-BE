using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace Datn.ApiManagement.Entities
{
    public class VehicleType : FullAuditedAggregateRoot<Guid>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<VehicleTypeDetail> VehicleTypeDetails { get; set; }
    }
}
